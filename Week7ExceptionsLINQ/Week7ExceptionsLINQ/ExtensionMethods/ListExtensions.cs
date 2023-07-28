using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7ExceptionsLINQ.LINQExercices;

namespace Week7ExceptionsLINQ.ExtensionMethods
{
    public static class ListExtensions
    {
        public static void Print(this List<string> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }

        public static void Print(this List<Car> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
