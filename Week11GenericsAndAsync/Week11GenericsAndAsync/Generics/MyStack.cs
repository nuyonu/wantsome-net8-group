namespace Week11GenericsAndAsync.Generics
{
    public class MyStack<T>
    {
        private List<T> storage = new List<T>();

        public MyStack(T firstElement)
        {
            storage.Add(firstElement);
        }

        public void Push(T element)
        {
            storage.Add(element);
        }

        public T Pop()
        {
            T lastValue = storage[storage.Count - 1];

            storage.RemoveAt(storage.Count - 1);

            return lastValue;
        }

        public T Top
        {
            get
            {
                if (storage.Count > 0)
                {
                    return storage[storage.Count - 1];
                }

                throw new CustomException();
            }
        }
    }
}
