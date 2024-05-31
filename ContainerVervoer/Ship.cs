using System;
namespace ContainerVervoer
{
	public class Ship
	{
		public bool isCapsizing { get; set; }
		public bool firstHalf { get; set; } // Checks first half
		public bool secondHalf { get; set; } // Checks the second half of the boat

		public Ship()
		{
		}
	}
}