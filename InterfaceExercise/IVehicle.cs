namespace InterfaceExercise;

public interface IVehicle
{
    public int NumberOfWheels { get; set; }
    public string Tires { get; set; }
    public string Engine { get; set; }
    public string Brakes { get; set; }

    public void DisplayDetails();
}