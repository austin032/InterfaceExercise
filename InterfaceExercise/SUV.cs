using System;

namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public int NumberOfSeats { get; set; }
    public string ColorOfInterior { get; set; }

    public int NumberOfWheels { get; set; }
    public string Tires { get; set; }
    public string Engine { get; set; }
    public string Brakes { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"NumberofSeats: {NumberOfSeats}\n ColorofInterior: {ColorOfInterior}\n NumberofWheels: {NumberOfWheels}\n Tires: {Tires}\n Engine: {Engine}\n Brakes: {Brakes}\n  Logo: {Logo}\n Name: {Name}");
    }

    public string Logo { get; set; }
    public string Name { get; set; }
}