using System.Text.Json.Serialization;

namespace lib.Model;

/// <summary>
///     Weather data storage.
/// </summary>
public sealed class Weather
{
    /// <summary>
    ///     Ctor.
    /// </summary>
    /// <param name="id">Weather condition id.</param>
    /// <param name="main">Group of weather parameters.</param>
    /// <param name="description">Weather condition within the group.</param>
    /// <param name="icon">Weather icon id.</param>
    [JsonConstructor]
    public Weather(int id, string main, string description, string icon)
    {
        Id = id;
        Main = main;
        Description = description;
        Icon = icon;
    }

    /// <summary>
    ///     Weather condition id.
    /// </summary>
    [JsonPropertyName("id")] [JsonInclude] public readonly int Id;

    /// <summary>
    ///     Group of weather parameters (Rain, Snow, Extreme etc.).
    /// </summary>
    [JsonPropertyName("main")] [JsonInclude]
    public readonly string Main;

    /// <summary>
    ///     Weather condition within the group.
    /// </summary>
    [JsonPropertyName("description")] [JsonInclude]
    public readonly string Description;

    /// <summary>
    ///     Weather icon id.
    /// </summary>
    [JsonPropertyName("icon")] [JsonInclude]
    public readonly string Icon;

    public override string ToString()
    {
        return $"id: {Id}, main: {Main}, description: {Description}, icon: {Icon}";
    }
}