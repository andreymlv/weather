using System.Text.Json;
using lib.Model;

namespace lib;

public sealed class Service
{
    private readonly Uri _uri;

    public Service(Uri uri)
    {
        _uri = uri;
    }

    public async Task<Root?> Weather()
    {
        using var client = new HttpClient();
        var json = await client.GetStringAsync(_uri);
        return JsonSerializer.Deserialize<Root>(json);
    }
}