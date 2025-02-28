using ScreenSound_API.Models;

namespace ScreenSound_API.Filters;

internal class FilterByGenre
{
    public static void AllGeneresFilter(List<Music> musics)
    {
        var allMusicGeneres = musics.Select(generes => generes.Genre).Distinct().ToList();
        Console.WriteLine("List Organized by Gener: \n");
        foreach (var genre in allMusicGeneres)
        {
            Console.WriteLine($"- {genre}");
        }
    }
}