using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FHIRGenomicsImporter
{
    public class MicrosoftFhirLoader
    {
		private string FhirBaseUrl { get; set; }
        private readonly HttpClient client = new HttpClient();

        public MicrosoftFhirLoader(string fhirBaseUrl)
        {
            this.FhirBaseUrl = fhirBaseUrl;
        }

        public async Task ProcessBundles(string inputDirectory)
        {
			if (!Directory.Exists(inputDirectory)) {
                throw new FHIRGenomicsException(string.Format("The input direcctory {0} could not be found or this program does not have permissions to access it.", inputDirectory));
			}

            int fileCounter = 0;
            var files = Directory.EnumerateFiles(inputDirectory, "*.json");
			foreach (var file in files) {
                using (var client = new HttpClient())
                using (var request = new HttpRequestMessage(HttpMethod.Post, this.FhirBaseUrl)) {
                    using (var stringContent = new StringContent(File.ReadAllText(file), Encoding.UTF8, "application/fhir+json")) {
                        request.Content = stringContent;

                        try {
                            using (var response = await client
                                .SendAsync(request, HttpCompletionOption.ResponseContentRead)
                                .ConfigureAwait(false)) {
                                response.EnsureSuccessStatusCode();
                                Console.WriteLine("Successfully POSTed {0}", file);
                            }
                            fileCounter++;
                        }
						catch (Exception exc) {
                            throw new FHIRGenomicsException(string.Format("Failed to POST {0}", file), exc);
						}
                    }
                }
            }

            Console.WriteLine("Imported {0} bundles to the FHIR server", fileCounter);
        }
	}
}
