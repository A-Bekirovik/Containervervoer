using System;
namespace ContainerVervoer
{
	public class Ship
	{
        public readonly List<Container> Containers;
        public List<Container> SortedContainers;
        public readonly List<Row> firstRow = new List<Row>();


        public int width { get; set; }
        public int length { get; set; } 
	    public int maxWeight { get; set; }
	    public int minWeight { get; set; }       

        private int WeightLeft;
        private int WeightRight;

        public Ship(int Length, int Width) // Length bepaal de hoeveelheid plekken op de X-as, Width bepaald op de Y-as
		{
            Width = width;
            Length = length;
            maxWeight = (length * width) * 150;
            minWeight = maxWeight / 2;
            Containers = new List<Container>();
            SortedContainers = new List<Container>();
        }

        private double WeightDifferencePercentage
        {
            get
            {
                return ((WeightLeft / TotalWeight) * 100) - ((WeightRight / TotalWeight) * 100);
            }
        }

        private int TotalWeight
        {
            get
            {
                int totalWeight = 0;
                foreach (Container container in Containers)
                {
                    totalWeight += container.Weight;
                }
                return totalWeight;
            }
        }
    }
}