namespace Dars2._3.Models;

internal class Company
{
    public Guid CompanyId { get; set; }
    public string Name { get; set; }
    public string Industry { get; set; }
    public int EmployeesCount { get; set; }
    public DateTime FoundYear { get; set; }
    public string Country { get; set; }
    public bool IsInternational { get; set; }
    public Company(string name, string industry, int employeesCount, DateTime foundYear, string country, bool isInternational)
    {
        Name = name;
        Industry = industry;
        EmployeesCount = employeesCount;
        FoundYear = foundYear;
        Country = country;
        IsInternational = isInternational;

    }
}
