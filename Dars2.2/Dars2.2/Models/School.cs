namespace Dars2._2.Models;

public class School
{
    public Guid SchoolId { get; set; }
    public int Number { get; set; }
    public int Capacity { get; set; }
    public int CurrentStudents { get; set; }
    public string Location { get; set; }
    public bool IsFree { get; set; }
    public string Language { get; set; }
}
