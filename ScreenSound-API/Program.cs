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
        //FilterArtistsByGenre.FilterArtistForMusicGener(musics, "rock");


        var myFavoritedRockSongs = new FavoritedMusics("Rock Gener");
        myFavoritedRockSongs.AddPrefererSongs(musics[71]);
        myFavoritedRockSongs.AddPrefererSongs(musics[31]);
        myFavoritedRockSongs.AddPrefererSongs(musics[35]);
        myFavoritedRockSongs.AddPrefererSongs(musics[71]);
        myFavoritedRockSongs.AddPrefererSongs(musics[46]);

        myFavoritedRockSongs.ViewFavoritedSongs();

        var myFavoritedHipHopSongs = new FavoritedMusics("Hip Hop Gener");
        myFavoritedHipHopSongs.AddPrefererSongs(musics[2]);
        myFavoritedHipHopSongs.AddPrefererSongs(musics[5]);
        myFavoritedHipHopSongs.AddPrefererSongs(musics[16]);
        myFavoritedHipHopSongs.AddPrefererSongs(musics[16]);
        myFavoritedHipHopSongs.AddPrefererSongs(musics[32]);

        myFavoritedHipHopSongs.ViewFavoritedSongs();

        myFavoritedHipHopSongs.buildNewJson();




    }

    catch (Exception ex)
    {
        Console.WriteLine($"Problem to connect API: {ex.Message}");
    }

}
    

