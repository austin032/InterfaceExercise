using System;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public int Size { get; set; }
    public int Weight { get; set; }

    public int NumberOfWheels { get; set; }
    public string Tires { get; set; }
    public string Engine { get; set; }
    public string Brakes { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"Size: {Size}\n Weight: {Weight}\n NumberOfWheels: {NumberOfWheels}\n Tires: {Tires}\n Engine: {Engine}\n Brakes: {Brakes}\n Logo: {Logo}\n Name: {Name}");
    }

    public string Logo { get; set; }
    public string Name { get; set; }
}