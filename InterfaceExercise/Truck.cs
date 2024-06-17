using System;
using System.Reflection;

public class Truck : IVehicle, ICompany 
{
	public bool hasTruckBed { get; set; }
	public int towCapacity { get; set; }
	public int numberOfWheels { get; set; }
	public string hornSound { get; set; }
	public bool hasAxil { get; set; }
	public int numberOfSeats { get; set; }
    public string brand { get; set; }
    public string model { get; set; }

    public void PrintIVheicle()
    {
        Console.WriteLine($"Has {numberOfWheels} wheels\n" +
            $"The horn goes {hornSound}\n" +
            $"It's {hasAxil} that is has an axil\n" +
            $"has {numberOfSeats} seats");
    }

    public void PrintICompany()
    {
        Console.WriteLine(brand + " " + model);
    }

    public void PrintTruck()
    {
        string hasTruckBedAnswer = (hasTruckBed == true) ? "Yes there is a truck bed" : "No there is not a truck bed";

        Console.WriteLine($"{hasTruckBedAnswer} and it has {towCapacity} pounds of towing capacity\n");
    }

    public Truck()
	{
	}
}


