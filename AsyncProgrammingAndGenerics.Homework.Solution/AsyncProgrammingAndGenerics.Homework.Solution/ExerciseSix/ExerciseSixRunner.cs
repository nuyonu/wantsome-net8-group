namespace AsyncProgrammingAndGenerics.Homework.Solution.ExerciseSix;

public static class ExerciseSixRunner
{
    public static async Task RunAsync()
    {
        string url = "https://google.com";
        string response = await GetHttpResponseAsync(url);

        Console.WriteLine(response);
    }

    public static async Task<string> GetHttpResponseAsync(string url)
    {
        using (var httpClient = new HttpClient())
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new HttpRequestException($"HTTP request failed with status code {response.StatusCode}");
            }
        }
    }
}