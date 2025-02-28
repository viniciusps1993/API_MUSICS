using ScreenSound_API.Models;
using ScreenSound_API.Filters;
using System.Text.Json;



using (HttpClient client = new HttpClient())
{

    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(response);
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;
        //musics[].TechnicalSheet();
        //FilterByGener.AllGeneresFilter(musics);
        //FilterByYear.YearsFilter(musics);
        //FilterByArtist.OrderByArtistList(musics);
        //FilterMusicsByOneArtist.FilterMusicOfOneArtist(musics, "A$AP Rocky");
        FilterArtistsByGenre.FilterArtistForMusicGener(musics, "rock");

    }

    catch (Exception ex)
    {
        Console.WriteLine($"Problem to connect API: {ex.Message}");
    }

}
    

