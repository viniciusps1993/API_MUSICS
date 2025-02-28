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
        Console.WriteLine($"This is the favorited songs {Song}");
        foreach (var music in ListOfPrefererSongs)
        {
            Console.WriteLine($"{music.Name} from {music.Artist}");
        }
    }

}


