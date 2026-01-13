namespace Dars2._3.Models;

internal class Course
{
    public Guid CourseId { get; set; }
    public string Title { get; set; }
    public string Instructor { get; set; }
    public int DurationHours { get; set; }
    public decimal Price { get; set; }
    public string Level { get; set; }
    public bool HasSertificate { get; set; }
    public Course(string title, string instructor, int durationHours, decimal price, string level, bool hasSertificate)
    {
        Title = title;
        Instructor = instructor;
        DurationHours = durationHours;
        Price = price;
        Level = level;
        HasSertificate = hasSertificate;
    }
}
