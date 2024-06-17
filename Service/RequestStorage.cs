using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

public class RequestStorage
{
    private readonly string _directoryPath = "/app/data";
    private readonly string _filePath;

    public RequestStorage()
    {
        // Ensure the directory exists
        if (!Directory.Exists(_directoryPath))
        {
            Directory.CreateDirectory(_directoryPath);
        }

        _filePath = Path.Combine(_directoryPath, "requests.txt");

        // Ensure the file exists
        if (!File.Exists(_filePath))
        {
            File.Create(_filePath).Dispose();
        }
    }

    public async Task AddRequestAsync(string request)
    {
        await File.AppendAllTextAsync(_filePath, request + "\n");
    }

    public async Task<IEnumerable<string>> GetRequestsAsync()
    {
        var requests = await File.ReadAllLinesAsync(_filePath);
        return requests;
    }
}