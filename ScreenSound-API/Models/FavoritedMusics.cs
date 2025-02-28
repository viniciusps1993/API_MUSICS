using System.Text.Json;

namespace ScreenSound_API.Models;

internal class FavoritedMusics
{
    public string? Song { get; set; }
    public List<Music> ListOfPrefererSongs { get;}

    public FavoritedMusics(string songName)
    {
        Song = songName;
        ListOfPrefererSongs = new List<Music>();
    }

    public void AddPrefererSongs(Music music)
    {
        ListOfPrefererSongs.Add(music);
    }

    public void ViewFavoritedSongs()
    {
        Console.WriteLine($"This is your favorite songs {Song}");
        foreach (var music in ListOfPrefererSongs)
        {
            Console.WriteLine($"{music.Name} from {music.Artist}");
        }
        Console.WriteLine();
    }

    public void buildNewJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Song,
            musics = ListOfPrefererSongs,
        });
        string jsonFile = $"musicas-favoritas-{Song}.json";

        File.WriteAllText(jsonFile, json);
        Console.WriteLine($"Json Created! {Path.GetFullPath(jsonFile)}");
    }
}   


