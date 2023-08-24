using System.Diagnostics;

namespace Week11GenericsAndAsync.AsyncProgramming
{
    public class CoffeMaker
    {
        public void MakeCoffe()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();


            string boiledWater = BoilWater();
            string grindedCoffe = GrindCoffe();
            string boiledMilk = BoilMilk();

            Console.WriteLine($"Add {boiledWater} to the cup.");
            Console.WriteLine($"Add {grindedCoffe} to the cup.");
            Console.WriteLine($"Add {boiledMilk} to the cup.");


            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}");
        }

        private string GrindCoffe()
        {
            Console.WriteLine("[Start] Grind the coffe.");

            Thread.Sleep(5_000);

            Console.WriteLine("[End] Grind the coffe.");

            return "grindedCoffe";
        }

        public string BoilWater()
        {
            Console.WriteLine("[Start] Boil water.");

            Thread.Sleep(6_000);

            Console.WriteLine("[End] Boil water.");

            return "boiledWater";
        }

        public string BoilMilk()
        {
            Console.WriteLine("[Start] Boil milk.");

            Thread.Sleep(4_000);

            Console.WriteLine("[End] Boil milk.");

            return "boiledMilk";
        }
    }
}
