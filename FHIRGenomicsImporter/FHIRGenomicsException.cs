using System;
using System.Runtime.Serialization;

namespace FHIRGenomicsImporter
{
	[Serializable]
	internal class FHIRGenomicsException : Exception
	{
		public FHIRGenomicsException()
		{
		}

		public FHIRGenomicsException(string message) : base(message)
		{
		}

		public FHIRGenomicsException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected FHIRGenomicsException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}