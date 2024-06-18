using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
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

        public Ship(int Length, int Width)
        {
            this.width = Width;
            this.length = Length;
            maxWeight = (Length * Width) * 150;
            minWeight = maxWeight / 2;
            Containers = new List<Container>();
            SortedContainers = new List<Container>();
            CheckIfRowsAreEvenOrUneven();
        }

        private double WeightDifferencePercentage
        {
            get
            {
                if (TotalWeight == 0) return 0;
                return Math.Abs(((double)WeightLeft / TotalWeight * 100) - ((double)WeightRight / TotalWeight * 100));
            }
        }

        private int TotalWeight
        {
            get
            {
                return Containers.Sum(container => container.Weight);
            }
        }

        public bool DistributeContainers()
        {
            SortedContainers = Containers.OrderByDescending(o => o.Type).ThenBy(o => o.Weight).ToList(); // Sorting List

            foreach (Container container in SortedContainers) // Putting Containers on ship
            {
                if (!AddContainerCenter(container))
                {
                    AddContainerLeftOrRight(container);
                }
            }

            return true;
        }

        private bool AddContainerLeftOrRight(Container container)
        {
            foreach (Row row in firstRow)
            {
                if ((WeightLeft < WeightRight && row.Side == RowSides.Left) || (WeightLeft >= WeightRight && row.Side == RowSides.Right)) // Which side is heavier.
                {
                    if (row.TryAddingContainer(container)) // Adds Container to that Side
                    {
                        if (row.Side == RowSides.Left)
                        {
                            WeightLeft += container.Weight; // Summarizes New Left side
                        }
                        else
                        {
                            WeightRight += container.Weight; // Summarizes New Right side
                        }

                        return true;
                    }
                }
            }

            return false;
        }

        private bool AddContainerCenter(Container container)
        {
            foreach (Row row in firstRow)
            {
                if (row.Side == RowSides.Centre)
                {
                    if (row.TryAddingContainer(container))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void CheckIfRowsAreEvenOrUneven()
        {
            for (int i = 0; i < width; i++)
            {
                RowSides side;

                if (width % 2 == 0)
                {
                    side = CalculateEvenRows(i);
                }
                else
                {
                    side = CalculateUnevenRows(i);
                }

                firstRow.Add(new Row(length, side));
            }
        }

        private RowSides CalculateEvenRows(int i)
        {
            return i < width / 2 ? RowSides.Left : RowSides.Right;
        }

        private RowSides CalculateUnevenRows(int i)
        {
            if (i < width / 2)
            {
                return RowSides.Left;
            }
            else if (i > width / 2)
            {
                return RowSides.Right;
            }
            else
            {
                return RowSides.Centre;
            }
        }

        public void Run()
        {
            try
            {
                if (firstRow.Count == 0)
                {
                    CheckIfRowsAreEvenOrUneven();
                }

                int totalWeightFirstRow = width * 150;
                int totalWeightCoolables = Containers
                    .Where(container => container.Type == ContainerType.Coolable || container.Type == ContainerType.CoolableValuable)
                    .Sum(container => container.Weight);

                if (totalWeightFirstRow < totalWeightCoolables)
                {
                    throw new ShipError("Ship has too many coolable");
                }

                if (TotalWeight > maxWeight)
                {
                    throw new ShipError("Ship Too Heavy");
                }

                if (TotalWeight < minWeight)
                {
                    throw new ContainerError("Containers Too Light");
                }

                if (WeightDifferencePercentage > 20)
                {
                    throw new ShipError("Ship is capzizing");
                }

                if (DistributeContainers())
                {
                    StartVisualizer();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
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

                for (int x = 0; x < firstRow[z].RowofStacks.Count; x++)
                {
                    if (x > 0)
                    {
                        stack += ",";
                        weight += ",";
                    }

                    if (firstRow[z].RowofStacks[x].containers.Count > 0)
                    {
                        for (int y = 0; y < firstRow[z].RowofStacks[x].containers.Count; y++)
                        {
                            Container container = firstRow[z].RowofStacks[x].containers[y];

                            stack += Convert.ToString((int)container.Type);
                            weight += Convert.ToString(container.Weight);
                            if (y < (firstRow[z].RowofStacks[x].containers.Count - 1))
                            {
                                weight += "-";
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"https://i872272.luna.fhict.nl/ContainerVisualizer/index.html?length=" + length + "&width=" + width + "&stacks=" + stack + "&weights=" + weight + "");
            Console.WriteLine();            
            return $"https://i872272.luna.fhict.nl/ContainerVisualizer/index.html?length=" + length + "&width=" + width + "&stacks=" + stack + "&weights=" + weight + "";
        }
    }
}
