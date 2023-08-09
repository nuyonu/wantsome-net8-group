namespace ExceptionsAndLINQ.Homework.Solution.LINQExercises
{
    internal static class LINQExercises
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 7");

            // Exercise 7
            var numbersEx7 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sum = numbersEx7.Where(x => x % 2 == 0).Sum(x => x * x);
            Console.WriteLine("Sum of squares of even numbers: " + sum);

            Console.WriteLine("\nExercise 8");

            // Exercise 8
            var numbersEx8 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var squares = numbersEx8.Select(x => x * x).ToList();
            Console.WriteLine("Squares of numbers: " + string.Join(", ", squares));

            Console.WriteLine("\nExercise 9");

            // Exercise 9
            var students = new List<Student>
            {
                new Student { Name = "Charlie", Grade = "A" },
                new Student { Name = "Alice", Grade = "A" },
                new Student { Name = "Bob", Grade = "B" },
                new Student { Name = "Dave", Grade = "C" }
            };

            var studentsWithGradeA = students.Where(x => x.Grade == "A").OrderByDescending(x => x.Name);

            Console.WriteLine("Students with Grade A:");
            foreach (var student in studentsWithGradeA)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("\nExercise 10");

            // Exercise 10
            var products = new List<Product> 
            {
                new Product { Name = "Product 1", Category = "Category 1", Price = 10 },
                new Product { Name = "Product 2", Category = "Category 2", Price = 20 },
                new Product { Name = "Product 3", Category = "Category 1", Price = 15 },
                new Product { Name = "Product 4", Category = "Category 3", Price = 5 },
                new Product { Name = "Product 5", Category = "Category 3", Price = 5 }
            };

            var sortedCategories = products
                .OrderBy(x => x.Price)
                .ThenBy(x => x.Name)
                .Select(x => x.Category)
                .Distinct()
                .ToList();

            Console.WriteLine("Sorted Categories:");
            foreach (var category in sortedCategories)
            {
                Console.WriteLine(category);
            }

            Console.WriteLine("\nExercise 11");

            // Exercise 11
            var categoriesWithAvgPrice = products
                .GroupBy(x => x.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    AveragePrice = g.Average(p => p.Price)
                })
                .OrderByDescending(x => x.AveragePrice)
                .ToList();

            Console.WriteLine("Categories sorted by average price in descending order:");
            foreach (var category in categoriesWithAvgPrice)
            {
                Console.WriteLine("{0} - Average Price: {1}", category.Category, category.AveragePrice);
            }
        }
    }
}
