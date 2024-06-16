using System;
namespace ContainerVervoer.Error
{
	public class ShipError : Exception
	{
		public ShipError(string message, Exception exception) : base(message,exception)
		{
		}

		public ShipError(string message) : base(message) 
		{ 
		}
	}
}

