using System;
namespace ContainerVervoer.Error
{
	public class ContainerError : Exception
	{
        public ContainerError(string message, Exception exception) : base(message,exception)
		{
		}

        public ContainerError(string message) : base(message)
        { 
	    }
	}
}