using Dars2._5.Models;

namespace Dars2._5.Services;

public class CountryService : ICountryService
{
    List<Country> Countries;
    public CountryService()
    {
        Countries = new List<Country>();
    }
    public bool DeleteCountry(Guid countryId)
    {
        foreach (var c in Countries)
        {
            if(c.CountryId == countryId)
            {
                return true;
            }
        }
        return false;
    }

    public Guid AddCountry(Country country)
    {
        country.CountryId = Guid.NewGuid();
        Countries.Add(country);
        return country.CountryId;
    }

    public List<Country> GetAllCountries()
    {
        return Countries;
    }

    public Country? GetCountryById(Guid countryId)
    {
        foreach (var c in Countries)
        {
            if(countryId == c.CountryId)
            {
                return c;
            }
        }
        return null;
    }

    public bool UpdateCountry(Country country)
    {
        for(var i = 0; i < Countries.Count; i++)
        {
            if (Countries[i].CountryId == country.CountryId)
            {
                Countries[i].CountOfPopulation = country.CountOfPopulation;
                Countries[i].Name = country.Name;
                Countries[i].Continent = country.Continent;
                Countries[i].Continent = country.Continent;
                return true;
            }
        }
        return false;
    }
}
