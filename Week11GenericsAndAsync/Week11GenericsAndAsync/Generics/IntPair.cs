namespace Week11GenericsAndAsync.Generics
{
    public class IntPair
    {
        private int firstValue;
        private int secondValue;

        public IntPair(int firstValue, int secondValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
        }

        public int First
        {
            get
            {
                return firstValue;
            }
            set
            {
                firstValue = value;
            }
        }

        public int Second { get { return secondValue; } }
    }
}
