﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ContainerVervoer
{
    public class Stack
    {
        public int Position { get; set; }
        public bool IsFront { get; private set; }
        public bool Reserved { get; set; }
        public bool StackIsFull { get; set; }

        public List<Container> containers = new List<Container>();
        private readonly int FirstMaxWeight = (int)ContainerWeight.Max * 4;

        public Stack(int position, bool isFront)
        {
            Position = position;
            IsFront = isFront;
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
                if (container.Type == ContainerType.CoolableValuable)
                {
                    if (containers.Count == 0 || containers.LastOrDefault().Type != ContainerType.CoolableValuable)
                    {
                        containers.Add(container);
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (container.Type == ContainerType.Valuable)
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
                    if (containers.Count == 0 || containers.LastOrDefault().Type != ContainerType.CoolableValuable)
                    {
                        containers.Insert(0, container);
                    }
                    else
                    {
                        containers.Insert(containers.Count - 1, container);
                    }
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
