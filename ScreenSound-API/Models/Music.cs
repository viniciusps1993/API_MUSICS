using System.Text.Json.Serialization;

namespace ScreenSound_API.Models;

internal class Music
{
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("song")]
    public string? Name { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Seconds_Duration{ get; set; }

    [JsonPropertyName("year")]
    public String? Year { get; set; }

    [JsonPropertyName("genre")]
    public String? Genre { get; set; }

    public void TechnicalSheet()
    {
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Music Name: {Name}");
        Console.WriteLine($"Seconds Duration: {Seconds_Duration / 1000}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Genre: {Genre}");
    }
}
