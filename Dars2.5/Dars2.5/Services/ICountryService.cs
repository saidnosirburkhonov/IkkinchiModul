using Dars2._5.Models;

namespace Dars2._5.Services;

public interface ICountryService
{
    public Guid AddCountry(Country country);
    public bool UpdateCountry(Country country);
    public bool DeleteCountry(Guid countryId);
    public Country? GetCountryById(Guid countryId);
    public List<Country> GetAllCountries();
}
