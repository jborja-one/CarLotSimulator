using System;
using CarLotSimulator;
//TODO

//Create a separate class file called Car
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDrivable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property


//Now that the Car class is created we can instantiate 3 new cars
//Set the properties for each of the cars
//Call each of the methods for each car

//*************BONUS*************//

// Set the properties utilizing the 3 different ways we learned about, one way for each car

//*************BONUS X 2*************//

//Create a CarLot class
//It should have at least one property: a List of cars
//Instantiate the a Carlot at the beginning of the program and as you create a car add the car to the list.
//At the end iterate through the list printing each of car's Year, Make, and Model to the console

Car car1 = new Car(2020, "Toyota", "Camry", 4, 5, true);
Car car2 = new Car(2018, "Honda", "Accord", 3, 4, true);
Car car3 = new Car(2021, "BMW", "X5", 5, 6, true);
/*this would be the second way to instantiate a Car class, but I believe the error it gives me
is because I have created a constructor in the Car class, is that why it doesn't work? */
// Car car2 = new Car(){
//     Year = 2019,
//     Make = "Ford",
//     Model = "Mustang",
//     EngineNoise = 6,
//     HonkNoise = 7,
//     IsDrivable = false
// };

/*This would be the third way to instantiate a new Car class, but I believe it is the same issue with the
above method as well.*/
// Car car4 = new Car();
// car4.Year = 2022;
// car4.Make = "Nissan";
// car4.Model = "Leaf";
// car4.EngineNoise = 4;
// car4.HonkNoise = 5;
// car4.IsDrivable = true;


CarLot carlot = new CarLot();

carlot.AddCar(car1);
carlot.AddCar(car2);
carlot.AddCar(car3);

foreach (var car in carlot.Cars)
{
    Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
}
