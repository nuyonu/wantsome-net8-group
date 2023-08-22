namespace Week11GenericsAndAsync.Generics
{
    public static class ExerciseOne
    {
        // Predicate<??>
        // Func<??, bool>
        public static List<T> Filter<T>(this List<T> input, Predicate<T> predicate)
        {
            var result = new List<T>();

            foreach(T element in input)
            {
                if (predicate(element))
                {
                    result.Add(element);
                }
            }

            return result;
        }

        //public static List<int> Filter(this List<int> input, Func<int, bool> predicate)
        //{

        //}

        public static List<T> MelaniaSolution<T>(this List<T> input, Predicate<T> pred)
        {
            return input.Where(x => pred(x)).ToList();
        }
    }
}
