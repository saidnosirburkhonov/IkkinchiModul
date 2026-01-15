namespace Dars2._4.Models;

internal class Car : LandTechnique
{
    public string CarName { get; set; }
    public string CarColor { get; set; }
    public Car(string carName, string carColor, string lendTechName, string lendTechField, string techName, string techField) : base(techName, techField, lendTechName, lendTechField)
    {
        CarName = carName;
        CarColor = carColor;
        Console.WriteLine("car ishladi");
    }

    public Car()
    {
    }
}
