namespace AsyncProgrammingAndGenerics.Homework.Solution.ExerciseFour;

public static class ExerciseFourRunner
{
    public static async Task RunAsync()
    {
        List<string> urls = new List<string>
        {
            "https://github.com/",
            "https://google.com"
        };

        var firstCompleted = await GetFirstCompletedUrlAsync(urls);

        if (firstCompleted != null)
        {
            Console.WriteLine(await firstCompleted.Content.ReadAsStringAsync());
        }
    }

    public static async Task<HttpResponseMessage> GetFirstCompletedUrlAsync(List<string> urls)
    {
        var httpClient = new HttpClient();

        var tasks = urls.Select(url => httpClient.GetAsync(url)).ToList();

        while (tasks.Count > 0)
        {
            var firstCompletedTask = await Task.WhenAny(tasks);
            tasks.Remove(firstCompletedTask);

            return firstCompletedTask.Result;
            
            // OR
            
            return await firstCompletedTask;
        }

        return null;
    }
}