using System;
using System.Collections.Generic;
using System.Linq;

namespace ContainerVervoer
{
    public class Stack
    {
        public int Position { get; set; }
        public bool IsFront { get; private set; }
        public bool IsBack { get; private set; }
        public bool Reserved { get; set; }
        public bool StackIsFull { get; set; }

        public List<Container> containers = new List<Container>(); // Bepaalt welke container op welke plaats staat
        private readonly int FirstMaxWeight = (int)ContainerWeight.Max * 4; // Max weight that the first container can have on top

        public Stack(int position, bool isFront, bool isBack)
        {
            Position = position;
            IsFront = isFront;
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
                return containers.Sum(container => container.Weight);
            }
        }

        public bool TryAddingContainer(Container container)
        {
            if ((container.Type == ContainerType.Coolable && Position > 0) || Reserved)
            {
                return false;
            }

            if (ContainersWeight + container.Weight <= MaxWeight)
            {
                if (container.Type == ContainerType.Valuable || container.Type == ContainerType.CoolableValuable)
                {
                    if (containers.Count == 0 || containers.LastOrDefault().Type != ContainerType.Valuable)
                    {
                        containers.Add(container);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    containers.Insert(0, container);
                }

                if (ContainersWeight >= MaxWeight)
                {
                    StackIsFull = true;
                }

                return true;
            }

            return false;
        }
    }
}
