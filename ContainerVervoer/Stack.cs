using System;
namespace ContainerVervoer
{
	public class Stack
	{

        public int Position { get; set; }
        public bool IsFront { get; private set; }
        public bool IsBack { get; private set; }
        public bool Reserved { get; set; }
        public bool StackIsFull { get; set; }

        List<Container> containers = new List<Container>(); // Bepaalt welke container op welke plaats staat
        private readonly int FirstMaxWeight = (int)ContainerWeight.Max * 4; // Max weight that the first container can have on top

        public Stack(int position, bool isfront, bool isBack)
        {
            Position = position;
            IsFront = isfront;
            IsBack = isBack;
        }

        public int MaxWeight
        {
            get
            {
                if (containers.Count > 0)
                {
                    return FirstMaxWeight + containers[0].Weight;
                }
                return FirstMaxWeight;
            }
        }

        public int ContainersWeight
        {
            get
            {
                int totalWeight = 0;
                foreach (var container in containers)
                {
                    totalWeight += container.Weight;
                }
                return totalWeight;
            }
        }
    }
}

