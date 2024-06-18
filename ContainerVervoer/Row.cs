using System;
using System.Collections.ObjectModel;

namespace ContainerVervoer
{
	public class Row
	{
        public List<Stack> RowofStacks = new List<Stack>();

        public int Width { get; private set; }
        public RowSides Side { get; private set; }
        public int MaxHeight { get; private set; }

        public Row(int width, RowSides side)
        {
            Width = width;
            RowofStacks = GetAllStackInRow();
            Side = side;
        }

        public bool TryAddingContainer(Container container)
        {
            for (int i = 0; i < RowofStacks.Count; i++)
            {
                Stack stack = RowofStacks[i];
                if (stack.TryAddingContainer(container))
                {
                    if (CheckIfContainerNeedsReservedSpace(container, stack, i))
                    {
                        return true;
                    }

                    return true;
                }
            }

            return false;
        }

        private bool CheckIfContainerNeedsReservedSpace(Container container, Stack stack, int index) // For V
        {
            if (container.Type == ContainerType.Valuable || container.Type == ContainerType.CoolableValuable)
            {
                if (stack.IsFront)
                {
                    return true;
                }
                else if (index > 0 && !RowofStacks[index - 1].Reserved && index + 1 < RowofStacks.Count)
                {
                    RowofStacks[index + 1].Reserved = true;
                    return true;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private List<Stack> GetAllStackInRow()
        {
            List<Stack> stacks = new List<Stack>();

            for (int i = 0; i < Width; i++)
            {
                bool isFront = false;

                if (i == 0)
                {
                    isFront = true;
                }

                stacks.Add(new Stack(i, isFront));
            }

            return stacks;
        }
    }
}

