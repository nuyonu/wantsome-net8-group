using System.Collections.Generic;

namespace Week11GenericsAndAsync.Generics
{
    public static class GenericsRunner
    {
        public static void Run()
        {
            //RunGenericsWithIntPair();
            //RunGenericsWithStringPair();
            //RunGenericsWithPair();
            ExerciseTwo();
        }

        private static void ExerciseTwo()
        {
            try
            {
                MyStack<int> numberStack = new MyStack<int>(5);

                numberStack.Push(10);
                numberStack.Push(20);
                numberStack.Push(30);

                Console.WriteLine("Top element: " + numberStack.Top);

                int poppedValue = numberStack.Pop();
                Console.WriteLine("Popped value: " + poppedValue);

                Console.WriteLine("Top element after pop: " + numberStack.Top);

                poppedValue = numberStack.Pop();
                Console.WriteLine("Popped value: " + poppedValue);

                Console.WriteLine("Top element after pop: " + numberStack.Top);

                poppedValue = numberStack.Pop();
                Console.WriteLine("Popped value: " + poppedValue);

                Console.WriteLine("Top element after pop: " + numberStack.Top);

                poppedValue = numberStack.Pop();
                Console.WriteLine("Popped value: " + poppedValue);

                Console.WriteLine("Top element after pop: " + numberStack.Top);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private static void ExerciseOneRun()
        {
            try
            {
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Predicate<int> evenPredicate = x => x % 2 == 0;
                Predicate<int> oddPredicate = x => x % 2 != 0;

                List<int> evenNumbers = numbers.Filter(evenPredicate);
                List<int> oddNumbers = numbers.Filter(oddPredicate);

                Console.WriteLine("Original list: " + string.Join(", ", numbers));
                Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
                Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private static void RunGenericsWithPair()
        {
            Pair<int> myIntPair = new Pair<int>(10, 30);

            Console.WriteLine(myIntPair.First);
            Console.WriteLine(myIntPair.Second);

            List<Pair<int>> myPairIntegers = new List<Pair<int>>
            {
                new Pair<int>(1, 5),
                new Pair<int>(2, 6),
                new Pair<int>(3, 7),
            };

            foreach (var item in myPairIntegers)
            {
                Console.WriteLine($"First: {item.First}, Second: {item.Second}");
            }
        }

        private static void RunGenericsWithIntPair()
        {
            IntPair myIntPair = new IntPair(10, 30);

            Console.WriteLine(myIntPair.First);
            Console.WriteLine(myIntPair.Second);

            List<IntPair> myPairIntegers = new List<IntPair>
            {
                new IntPair(1, 5),
                new IntPair(2, 6),
                new IntPair(3, 7),
            };

            foreach (var item in myPairIntegers)
            {
                Console.WriteLine($"First: {item.First}, Second: {item.Second}");
            }
        }

        private static void RunGenericsWithStringPair()
        {
            StringPair myStringPair = new StringPair("Alex", "Popescu");

            Console.WriteLine(myStringPair.First);
            Console.WriteLine(myStringPair.Second);

            List<StringPair> myPairStrings = new List<StringPair>
            {
                new StringPair("Alex2", "Popescu2"),
                new StringPair("Alex3", "Popescu3"),
                new StringPair("Alex4", "Popescu4")
            };

            foreach (var item in myPairStrings)
            {
                Console.WriteLine($"First: {item.First}, Second: {item.Second}");
            }
        }
    }
}
