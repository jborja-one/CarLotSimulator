using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> Cars { get; set; }

    public CarLot()
    {
        Cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        Cars.Add(car);
    }

    public void NumberOfCars()
    {
        // var carCount = 0;
        // carCount++;
        // Console.WriteLine($"There are {carCount} cars in the car lot.");
        Console.WriteLine($"There are {this.Cars.Count} cars in the car lot.");

    }
}
