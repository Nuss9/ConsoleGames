using System;
using System.Runtime.Serialization;

namespace GamesLibrary.Battleships
{
	[Serializable]
	public class InvalidShipLocationException : Exception
	{
		public InvalidShipLocationException()
		{
		}

		public InvalidShipLocationException(string message) : base(message)
		{
		}

		public InvalidShipLocationException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected InvalidShipLocationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}