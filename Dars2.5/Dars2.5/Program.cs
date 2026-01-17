using Dars2._5.Models;
using Dars2._5.Services;

namespace Dars2._5;

internal class Program
{
    static void Main(string[] args)
    {
        //------------------------------------------------------------------
        ICountryService countryService = new CountryService();
        Country country1 = new Country()
        {
            Name = "Uzbekistan",
            CountOfPopulation = 34000000,
            Continent = "Asia"
        };

        countryService.AddCountry(country1);
        var Countries = countryService.GetAllCountries();
        foreach (var c in Countries)
        {
            Console.WriteLine(c.Name);
            Console.WriteLine(c.CountryId);
            Console.WriteLine(c.Continent);
            Console.WriteLine(c.CountOfPopulation);
        }
        //-----------------------------------------------------------------
        ISingerService singerService = new SingerService();
        var singer1 = new Singer()
        {
            Name = "Tylor",
            SecondName = "Swift",
            Age = 40,
            Country = "USA"
        };
        singerService.AddSinger(singer1);
        //--------------------------------------------------------------------------------
        IAirLaneService airLaneService = new AirLaneService();
        var airLane1 = new AirLane()
        {
            Model = "Boing",
            From = "Madrid",
            To = "Sicilia",
            PricePerFlight = 300
        };
        airLaneService.AddAirLane(airLane1);
        //--------------------------------------------------------------------------
        IBlackBoardService blackBoardService = new BlackBoardService();
        BlackBoard blackBoard1 = new BlackBoard()
        {
            Width = 2.3,
            Heigth = 1.2,
            Color = "Green",
            IsWood = true
        };
        blackBoardService.AddBlackBoard(blackBoard1);
    }
}
