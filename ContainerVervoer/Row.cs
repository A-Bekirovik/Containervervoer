using System;
using System.Collections.ObjectModel;

namespace ContainerVervoer
{
	public class Row
	{
        private List<Stack> RowofStacks = new List<Stack>();
        public ReadOnlyCollection<Stack> StackReadable
        {
            get { return RowofStacks.AsReadOnly(); }
        }

        public int Width { get; private set; }
        public RowSide Side { get; private set; }
        public int MaxHeight { get; private set; }

        public Row()
		{
		}
	}
}

