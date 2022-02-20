using System.Text.Json.Serialization;

namespace lib.Model;

/// <summary>
///     Coordinates data storage.
/// </summary>
public sealed class Coordinates
{
    /// <summary>
    ///     Ctor.
    /// </summary>
    /// <param name="longitude">City geo location, longitude.</param>
    /// <param name="latitude">City geo location, latitude.</param>
    [JsonConstructor]
    public Coordinates(double longitude, double latitude)
    {
        Longitude = longitude;
        Latitude = latitude;
    }

    /// <summary>
    ///     City geo location, longitude.
    /// </summary>
    [JsonPropertyName("lon")] [JsonInclude]
    public readonly double Longitude;

    /// <summary>
    ///     City geo location, latitude.
    /// </summary>
    [JsonPropertyName("lat")] [JsonInclude]
    public readonly double Latitude;
}