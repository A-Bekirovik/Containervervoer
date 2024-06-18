using System;
using System.Linq.Expressions;

namespace ContainerVervoer
{
	public class Container
	{
		public int Weight { get; set; }
		public int maxWeight { get; private set; } = (int)ContainerWeight.Max;
        public int minWeight { get; private set; } = (int)ContainerWeight.Min;

        public ContainerType Type { get; set; }
	    public bool isCoolable { get; set; }
		public bool isValuable { get; set; }
	 

        public Container(int weight, bool valuable, bool coolable)
		{
            Weight = SetWeight(weight);
            isCoolable = coolable;
            isValuable = valuable;
            Type = SetType();
		}

        private int SetWeight(int weight)
        {
            switch (weight)
            {
                case < 4:
                    throw new Exception("Weight minimum is 4 tons");
                case > 30:
                    throw new Exception("Weight maximum is 30 tons");
                default:
                    return weight;
            }
        }

        private ContainerType SetType()
        {
            switch ((isValuable, isCoolable))
            {
                case (false, false):
                    return ContainerType.Normal;
                case (true, false):
                    return ContainerType.Valuable;
                case (false, true):
                    return ContainerType.Coolable;
                case (true, true):
                    return ContainerType.CoolableValuable;
            }
        }

        public string ReturnContainerInfoString()
        {
            return $"Weight: {Weight}, Valuable: {isValuable}, Coolable: {isCoolable}";
        }
    }
}