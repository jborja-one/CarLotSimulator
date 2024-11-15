using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> Cars { get; set; }
    public static int CarCount = 0;
     
    public CarLot()
    {
        Cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        Cars.Add(car);
        CarCount++;
    }

    public static void NumberOfCars()
    {
        Console.WriteLine($"There are {CarCount} cars in the car lot");
    }
}
