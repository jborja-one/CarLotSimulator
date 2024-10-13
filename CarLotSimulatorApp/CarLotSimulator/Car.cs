using System;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int EngineNoise { get; set; }
    public int HonkNoise { get; set; }
    public bool IsDrivable { get; set; }

    public Car(int year, string make, string model, int engineNoise, int honkNoise, bool isDrivable)
    {
        Year = year;
        Make = make;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDrivable = isDrivable;
    }

    public void MakeEngineNoise(int noiseLevel)
    {
        if(noiseLevel <= 4) Console.WriteLine("The engine is not so loud");
        if(noiseLevel > 4 && noiseLevel <= 7) Console.WriteLine("The engine sound is bearable");
        if(noiseLevel > 7) Console.WriteLine("The engine is too loud");
    }

    public void MakeHonkNoise(int noiseLevel)
    {
        if(noiseLevel <= 4) Console.WriteLine("The honk is not so loud");
        if(noiseLevel > 4 && noiseLevel <= 7) Console.WriteLine("The honk sound is bearable");
        if(noiseLevel > 7) Console.WriteLine("The honk is too loud");
    }

    public void DoesItWork(bool isFunctional){
        if(isFunctional) Console.WriteLine("The car works perfectly");
        else Console.WriteLine("hmm... better take it to the shop");
    }
}
