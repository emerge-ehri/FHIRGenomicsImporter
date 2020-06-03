# FHIR Genomics Importer

This is a proof-of-concept application developed to demonstrate importing FHIR bundles adhering to [eMERGE's specification for the Genomics Reporting Implementation Guidelines](https://emerge-fhir-spec.readthedocs.io/en/latest/).

Due to limitations in the proof-of-concept use case, this program simulates the process of "receiving" results from an external laboratory by loading FHIR bundles from disk.

The program demonstrates the ability to read resources from a FHIR server in order to populate our AGS with necessary pharmacogenomic (PGx) data.  From here, the AGS is able to process and return results to the EHR using established processes (that code is not part of this repository).

## Setup

This program requires you to have a running version of the Microsoft fhir-server instance, as well as an additional SQL Server database to simulate Northwestern's [Ancillary Genomics System](https://pubmed.ncbi.nlm.nih.gov/30778576/) schema.

Instructions for setting this up on macOS are available from our [fhir-server fork](https://github.com/emerge-ehri/fhir-server/blob/emerge-pilot/docs/Commands.md) and won't be duplicated here.

## Running

This is a command line program with the following run parameters across two different modes (simulating loading FHIR bundles to the FHIR server, and loading FHIR bundles to the AGS for pharmacogenomics).

```
Load bundles into MS FHIR server (--loadFhir)
   Given a directory of JSON files (assumed to be FHIR bundles representing
   Clinical Genomic compliant reports), load them to a MS FHIR server.
   --loadFhir - Enable loading to FHIR server
   --fhirUrl  - The base URL of the FHIR server, e.g. http://localhost:5000
   --inputDir - The directory where the FHIR bundles (.json files) are stored

Load PGx data into AGS (--loadAgs)
   Given a FHIR server populated with Clinical Genomic bundles, extract the
   data for PGx results and load them to the AGS's SQL Server database.
   --loadAgs  - Enable loading to AGS
   --fhirUrl  - The base URL of the FHIR server, e.g. http://localhost:5000
   --agsDb    - Database connection string for the AGS

```

For the `--agsDb` parameter, an example connection string would look like: 

```
"Server=localhost,1434;Initial Catalog=AGS;Persist Security Info=False;User Id=SA;Password=tMk%e9?FsE7=tsSz"
```

_The password isn't a real one, don't worry.  It's the example one we provide in all of our documentation_