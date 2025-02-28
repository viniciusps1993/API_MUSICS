using ScreenSound_API.Models;

namespace ScreenSound_API.Filters;

internal class FilterByYear
{
    public static void YearsFilter(List<Music> musics)
    {
        var allYearsFilter = musics.Select(year => year.Year).Distinct().ToList();
        Console.WriteLine("List organized by year: \n");
        foreach (var year in allYearsFilter)
        {
            Console.WriteLine($"-`{year}");
        }
    }
}

