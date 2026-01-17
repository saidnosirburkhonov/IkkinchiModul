using Dars2._5.Services;

namespace Dars2._5.Models;

public class Country 
{
    public Guid CountryId { get; set; }
    public string Name { get; set; }
    public int CountOfPopulation { get; set; }
    public string Continent { get; set; }
}
