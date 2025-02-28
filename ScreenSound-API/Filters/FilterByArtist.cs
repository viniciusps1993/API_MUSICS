using ScreenSound_API.Models;

namespace ScreenSound_API.Filters;

internal class FilterByArtist
{
    public static void OrderByArtistList(List<Music> musics)
    {
        var organizedArtists = musics.OrderBy(music => music.Artist).Select
            (music  => music.Artist).Distinct().ToList();
        Console.WriteLine("List of Organized Artists: \n");
        foreach (var artist in organizedArtists)
        {
            Console.WriteLine($"-{artist}");
        }
    }
}


