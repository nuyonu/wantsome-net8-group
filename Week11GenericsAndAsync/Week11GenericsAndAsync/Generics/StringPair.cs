namespace Week11GenericsAndAsync.Generics
{
    public class StringPair
    {
        private string firstValue;
        private string secondValue;

        public StringPair(string firstValue, string secondValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
        }

        public string First { get { return firstValue; } }

        public string Second { get { return secondValue; } }
    }
}
