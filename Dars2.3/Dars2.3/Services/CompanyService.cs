using Dars2._3.Models;

namespace Dars2._3.Services;

internal class CompanyService
{
    List<Company> Companies;
	public CompanyService()
	{
		Companies = new List<Company>();
	}
	public List<Company> GetAllCompanies()
	{
		return Companies;
	}
	public Guid AddCompany(Company company)
	{
		company.CompanyId = Guid.NewGuid();
		Companies.Add(company);
		return company.CompanyId;
	}
	public Company? GetCompanyById(Guid companyId)
	{
        foreach (var c in Companies)
        {
            if(c.CompanyId == companyId)
			{
				return c;
			}
        }
		return null;
    }
	public bool DeleteCompany(Guid companyId)
	{
		foreach (var c in Companies)
		{
			if(c.CompanyId == companyId)
			{
				Companies.Remove(c);
				return true;
			}
		}
		return false;
	}
	public bool UpdateCompany(Guid companyId, Company newCompany)
	{
		for(var i = 0; i < Companies.Count; i++)
		{
			if (Companies[i].CompanyId == companyId)
			{
				Companies[i].IsInternational = newCompany.IsInternational;
				Companies[i].Country = newCompany.Country;
				Companies[i].EmployeesCount = newCompany.EmployeesCount;
				Companies[i].FoundYear = newCompany.FoundYear;
				Companies[i].Name = newCompany.Name;
				Companies[i].Industry = newCompany.Industry;
				return true;
			}
		}
		return false;
	}
	public List<Company>? GetCompanyByIndustry(string industry)
	{
		List<Company> NewCompanies = new List<Company>();
        foreach (var c in Companies)
        {
            if(c.Industry == industry)
			{
				NewCompanies.Add(c);
			}
        }
		if(NewCompanies.Count == 0)
		{
			return null;
		}
		return NewCompanies;
    }
}
