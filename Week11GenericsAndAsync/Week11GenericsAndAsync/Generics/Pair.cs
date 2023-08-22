namespace Week11GenericsAndAsync.Generics
{
    public class Pair<T>
    {
        private T firstValue;
        private T secondValue;

        public Pair(T firstValue, T secondValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
        }

        public T First
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

        public T Second { get { return secondValue; } }
    }
}
