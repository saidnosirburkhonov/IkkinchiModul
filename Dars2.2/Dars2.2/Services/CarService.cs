using Dars2._2.Models;

namespace Dars2._2.Services;

public class CarService
{
    public List<Car> Cars = new List<Car>();

    public Guid AddCar(Car car)
    {
        car.CarId = Guid.NewGuid();
        Cars.Add(car);
        return car.CarId;
    }
    public bool DeleteCar(Guid carId)
    {
        Car car = null;
        foreach (var c in Cars)
        {
            if (c.CarId == carId)
            {
                car = c;
                break;
            }
        }
        if (car != null)
        {
            Cars.Remove(car);
            return true;
        }
        return false;
    }
    public List<Car> GetAllCars()
    {
        return Cars;
    }
    public void UpdateCar(Car updatedCar)
    {
        Car exeistingCar = null;
        foreach (var c in Cars)
        {
            if (c.CarId == updatedCar.CarId)
            {
                exeistingCar = c;
                break;
            }
        }
        if (exeistingCar != null)
        {
            exeistingCar.Model = updatedCar.Model;
            exeistingCar.Color = updatedCar.Color;
            exeistingCar.Price = updatedCar.Price;
            exeistingCar.FuelType = updatedCar.FuelType;
            exeistingCar.RelaiseYear = updatedCar.RelaiseYear;
            exeistingCar.IsNew = updatedCar.IsNew;

        }
    }
    public Car GetById(Guid carId)
    {
        Car car = null;
        foreach (var c in Cars)
        {
            if (c.CarId == carId)
            {
                car = c;
                break;
            }
        }
        return car;
    }

}
