public static class Program
{
    public static void Main()
    {
        DownloadHistory("scottplot", "./", 12).Wait();
    }

    public static async Task DownloadHistory(string package, string saveFolder, int months, bool overwrite = false)
    {
        string saveFilePath = Path.GetFullPath(Path.Combine(saveFolder, package + ".json"));
        if (overwrite == false && File.Exists(saveFilePath))
        {
            Console.WriteLine($"Exists: {saveFilePath}");
            return;
        }
        string url = $"https://nugettrends.com/api/package/history/{package}?months{months}";
        using HttpClient client = new();
        using HttpResponseMessage response = await client.GetAsync(url);
        using HttpContent content = response.Content;
        byte[] bytes = await content.ReadAsByteArrayAsync();
        File.WriteAllBytes(saveFilePath, bytes);
        Console.WriteLine($"Saved: {saveFilePath}");
    }
}