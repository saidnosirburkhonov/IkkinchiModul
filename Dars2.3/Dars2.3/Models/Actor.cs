namespace Dars2._3.Models;

internal class Actor
{
    public Guid ActorId { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public string Nationality { get; set; }
    public string MainGenre { get; set; }
    public int AwardsCount { get; set; }
    public bool IsActive { get; set; }

    public Actor(string fullName, int age, string nationality, string mainGenre, int awardsCount, bool isActive)
    {
        FullName = fullName;
        Age = age;
        Nationality = nationality;
        MainGenre = mainGenre;
        AwardsCount = awardsCount;
        IsActive = isActive;
    }
}
