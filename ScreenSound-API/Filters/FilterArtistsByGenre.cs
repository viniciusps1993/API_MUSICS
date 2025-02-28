using ScreenSound_API.Models;

namespace ScreenSound_API.Filters;

internal class FilterArtistsByGenre
{
    public static void FilterArtistForMusicGener(List<Music> musics, string genre)
    {
        var artistsOrMusicGener = musics.Where(music => music.Genre!
            .Contains(genre))
            .Select(music => music.Artist)
            .Distinct().ToList();
        Console.WriteLine($"Artists By Musical Genre: {genre}");
        foreach (var artist in artistsOrMusicGener)
        {
            Console.WriteLine(artist);
        }
    }
}
