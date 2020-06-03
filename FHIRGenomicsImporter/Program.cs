using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace FHIRGenomicsImporter
{
    class Program
    {
        private const string LOAD_FHIR_COMMAND = "--loadFhir";
        private const int FHIR_COMMAND_PARAM_COUNT = 5;
        private const string LOAD_AGS_COMMAND = "--loadAgs";
        private const int AGS_COMMAND_PARAM_COUNT = 5;
        private const string FHIR_URL_PARAM = "--fhirUrl";
        private const string AGS_DB_PARAM = "--agsDb";
        private const string FHIR_BUNDLE_INPUT_DIR_PARAM = "--inputDir";

        private static IConfiguration configuration;

        static async Task Main(string[] args)
        {
			if (args.Length == 0) {
                PrintUsage();
                Environment.Exit(-1);
            }

            LoadAppSettingsFile();

            try {
                if (args[0].Equals(LOAD_FHIR_COMMAND, StringComparison.CurrentCultureIgnoreCase)
                    && args.Length == FHIR_COMMAND_PARAM_COUNT) {
                    var fhirBaseUrl = "";
                    var inputDir = "";
                    for (int index = 1; index < (FHIR_COMMAND_PARAM_COUNT - 1); index++) {
                        if (args[index].Equals(FHIR_URL_PARAM, StringComparison.CurrentCultureIgnoreCase)) {
                            fhirBaseUrl = args[index + 1];
                        } else if (args[index].Equals(FHIR_BUNDLE_INPUT_DIR_PARAM, StringComparison.CurrentCultureIgnoreCase)) {
                            inputDir = args[index + 1];
                        }
                    }

                    if (string.IsNullOrWhiteSpace(fhirBaseUrl) || string.IsNullOrWhiteSpace(inputDir)) {
                        PrintUsage();
                        Environment.Exit(-1);
                    }

                    var loader = new MicrosoftFhirLoader(fhirBaseUrl);
                    await loader.ProcessBundles(inputDir);
                } else if (args[0].Equals(LOAD_AGS_COMMAND, StringComparison.CurrentCultureIgnoreCase)
                      && args.Length == AGS_COMMAND_PARAM_COUNT) {
                    var fhirBaseUrl = "";
                    var agsDbConnection = "";
                    for (int index = 1; index < (FHIR_COMMAND_PARAM_COUNT - 1); index++) {
                        if (args[index].Equals(FHIR_URL_PARAM, StringComparison.CurrentCultureIgnoreCase)) {
                            fhirBaseUrl = args[index + 1];
                        } else if (args[index].Equals(AGS_DB_PARAM, StringComparison.CurrentCultureIgnoreCase)) {
                            agsDbConnection = args[index + 1];
                        }
                    }

                    if (string.IsNullOrWhiteSpace(fhirBaseUrl) || string.IsNullOrWhiteSpace(agsDbConnection)) {
                        PrintUsage();
                        Environment.Exit(-1);
                    }

                    var loader = new AgsFhirLoader(fhirBaseUrl, agsDbConnection);
                    await loader.ProcessBundles();
                } else {
                    PrintUsage();
                    Environment.Exit(-1);
                }
            } catch (Exception exc) {
                Console.WriteLine("*** Error ***");
                Console.WriteLine(exc.Message);
                Console.WriteLine();
                Console.WriteLine(exc.StackTrace);
                Console.WriteLine();
                if (exc.InnerException != null) {
                    Console.WriteLine(exc.InnerException.Message);
                    Console.WriteLine();
                    Console.WriteLine(exc.StackTrace);
				}
			}

        }

        private static void PrintUsage()
        {
            Console.WriteLine("FHIRGenomicsImporter v{0}", Assembly.GetEntryAssembly().GetName().Version);
            Console.WriteLine("");
            Console.WriteLine("This program has two modes of operations, set by command line parameters:");
            Console.WriteLine("");
            Console.WriteLine("Load bundles into MS FHIR server ({0})", LOAD_FHIR_COMMAND);
            Console.WriteLine("   Given a directory of JSON files (assumed to be FHIR bundles representing");
            Console.WriteLine("   Clinical Genomic compliant reports), load them to a MS FHIR server.");
            Console.WriteLine("   {0} - Enable loading to FHIR server", LOAD_FHIR_COMMAND);
            Console.WriteLine("   {0}  - The base URL of the FHIR server, e.g. http://localhost:5000", FHIR_URL_PARAM);
            Console.WriteLine("   {0} - The directory where the FHIR bundles (.json files) are stored", FHIR_BUNDLE_INPUT_DIR_PARAM);
            Console.WriteLine("");
            Console.WriteLine("Load PGx data into AGS ({0})", LOAD_AGS_COMMAND);
            Console.WriteLine("   Given a FHIR server populated with Clinical Genomic bundles, extract the");
            Console.WriteLine("   data for PGx results and load them to the AGS's SQL Server database.");
            Console.WriteLine("   {0}  - Enable loading to AGS", LOAD_AGS_COMMAND);
            Console.WriteLine("   {0}  - The base URL of the FHIR server, e.g. http://localhost:5000", FHIR_URL_PARAM);
            Console.WriteLine("   {0}    - Database connection string for the AGS", AGS_DB_PARAM);
            Console.WriteLine("");

        }

        private static void LoadAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                                 .SetBasePath(Directory.GetCurrentDirectory())
                                 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            configuration = builder.Build();
        }
    }
}
