using System.Text.Json;
using System.Text.Json.Nodes;
using lib.Model;

namespace lib;

public sealed class Service
{
    private readonly Uri _uri;

    public Service(Uri uri)
    {
        _uri = uri;
    }

    public async Task<string> Weather()
    {
        using var client = new HttpClient();
        var json = await client.GetStringAsync(_uri);
        var forecastNode = JsonNode.Parse(json);
        var options = new JsonSerializerOptions { WriteIndented = true };
        return forecastNode!.ToJsonString(options);
    }
}