using System;

namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public bool HasTrunk { get; set; }
    public bool HasAC { get; set; }

    public int NumberOfWheels { get; set; }
    public string Tires { get; set; }
    public string Engine { get; set; }
    public string Brakes { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"HasTrunk: {HasTrunk}\n HasAC: {HasAC}\n NumberOfWheels: {NumberOfWheels}\n Tires: {Tires}\n Engine: {Engine}\n Brakes: {Brakes}\n  Logo: {Logo}\n Name: {Name}");
    }

    public string Logo { get; set; }
    public string Name { get; set; }
}