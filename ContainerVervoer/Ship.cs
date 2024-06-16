using System;
using System.Diagnostics;
using ContainerVervoer.Error;

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

        public void Run()
        {
            int totalWeightFirstRow = width * 150;
            int totalWeightCoolables = 0;

            foreach (Container container in Containers)
            {
                if (container.Type == ContainerType.Coolable || container.Type == ContainerType.CoolableValuable)
                {
                    totalWeightCoolables += container.Weight;
                }
            }

            if (totalWeightFirstRow < totalWeightCoolables)
            {
                throw new ShipError("Too many coolables!!!!");
            }

            if (TotalWeight > maxWeight)
            {
                throw new ShipError("Load is too heavy");
            }

            if (TotalWeight < minWeight)
            {
                throw new ContainerError("Containers are too light");
            }

            if (WeightDifferencePercentage > 20)
            {
                throw new ShipError("Ship is capsizing");
            }

            if (DistributeContainers())
            {
                StartVisualizer();
            }
        }

        public string StartVisualizer()
        {
            string stack = "";
            string weight = "";
            for (int z = 0; z < firstRow.Count; z++)
            {
                if (z > 0)
                {
                    stack += '/';
                    weight += '/';
                }

                for (int x = 0; x < firstRow[z].Row.Count; x++)
                {
                    if (x > 0)
                    {
                        stack += ",";
                        weight += ",";
                    }

                    if (firstRow[z].stackList[x].containers.Count > 0)
                    {
                        for (int y = 0; y < firstRow[z].stackList[x].containers.Count; y++)
                        {
                            Container container = firstRow[z].stackList[x].containers[y];

                            stack += Convert.ToString((int)container.ContainerType);
                            weight += Convert.ToString(container.Weight);
                            if (y < (firstRow[z].stackList[x].containers.Count - 1))
                            {
                                weight += "-";
                            }
                        }
                    }
                }
            }

            Process.Start($"https://i872272.luna.fhict.nl/ContainerVisualizer/index.html?length=" + Length + "&width=" + Width + "&stacks=" + stack + "&weights=" + weight + "");
            return $"https://i872272.luna.fhict.nl/ContainerVisualizer/index.html?length=" + Length + "&width=" + Width + "&stacks=" + stack + "&weights=" + weight + "";
        }
    }
}