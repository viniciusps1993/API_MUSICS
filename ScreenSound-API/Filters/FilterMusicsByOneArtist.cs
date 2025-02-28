using ScreenSound_API.Models;

namespace ScreenSound_API.Filters;

internal class FilterMusicsByOneArtist
{
    public static void FilterMusicOfOneArtist(List<Music> musics, string artistName)
    {
        var musicsByArtist = musics.Where(music => music.Artist!.Equals(artistName)).ToList();
        Console.WriteLine($"Musics filtered by Artist: {artistName}");
        foreach (var music in musicsByArtist)
        {
            Console.WriteLine(music.Name );
        }
    }
}
