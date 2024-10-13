using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> Cars { get; set; }

    public CarLot(){
        Cars = new List<Car>();
    }

    public void AddCar(Car car){
        Cars.Add(car);
    }
}
