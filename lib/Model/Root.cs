using System.Text.Json.Serialization;

namespace lib.Model;

/// <summary>
/// 
/// </summary>
public sealed class Root
{
    /// <summary>
    ///     Ctor.
    /// </summary>
    /// <param name="coordinates"></param>
    /// <param name="weather"></param>
    [JsonConstructor]
    public Root(Coordinates coordinates, List<Weather> weather)
    {
        Coordinates = coordinates;
        Weather = weather;
    }

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("coord")] [JsonInclude]
    public readonly Coordinates Coordinates;

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("weather")] [JsonInclude]
    public readonly List<Weather> Weather;

    public override string ToString()
    {
        return string.Join('\n', Weather);
    }
}