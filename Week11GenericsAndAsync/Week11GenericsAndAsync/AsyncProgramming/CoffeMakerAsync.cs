using System.Diagnostics;

namespace Week11GenericsAndAsync.AsyncProgramming
{
    public class CoffeMakerAsync
    {
        public async Task MakeCoffeAsync()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // Oarecum echivalent cu MakeCoffe Sync
            //string boiledWater = await BoilWaterAsync();
            //string grindedCoffe = await GrindCoffeAsync();
            //string boiledMilk = await BoilMilkAsync();

            //Console.WriteLine($"Add { boiledWater} to the cup.");
            //Console.WriteLine($"Add { grindedCoffe} to the cup.");
            //Console.WriteLine($"Add { boiledMilk} to the cup.");

            Task<string> boiledWaterTask = BoilWaterAsync();
            Task<string> grindedCoffeTask = GrindCoffeAsync();
            Task<string> boiledMilkTask = BoilMilkAsync();

            //var resultTask = await Task.WhenAny(boiledWaterTask, grindedCoffeTask, boiledMilkTask);
            //var result = await resultTask;
            //Console.WriteLine($"Completed task result: {result}.");

            var result = await Task.WhenAll(boiledWaterTask, grindedCoffeTask, boiledMilkTask);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Add {await boiledWaterTask} to the cup.");
            Console.WriteLine($"Add {await grindedCoffeTask} to the cup.");
            Console.WriteLine($"Add {await boiledMilkTask} to the cup.");


            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}");
        }

        private async Task<string> GrindCoffeAsync()
        {
            Console.WriteLine("[Start] Grind the coffe.");

            await Task.Delay(5_000);

            Console.WriteLine("[End] Grind the coffe.");

            return "grindedCoffe";
        }

        public async Task<string> BoilWaterAsync()
        {
            Console.WriteLine("[Start] Boil water.");

            await Task.Delay(6_000);

            Console.WriteLine("[End] Boil water.");

            return "boiledWater";
        }

        public async Task<string> BoilMilkAsync()
        {
            Console.WriteLine("[Start] Boil milk.");

            await Task.Delay(4_000);

            Console.WriteLine("[End] Boil milk.");

            return "boiledMilk";
        }
    }
}
