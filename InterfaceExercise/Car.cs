using System;
using System.Reflection;

public class Car : IVehicle, ICompany
{
	public bool hasTrunk { get; set; }
	public int numberOfDoors { get; set; }
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

    public void PrintCar()
    {
        string hasTrunkAnswer = (hasTrunk == true) ? "Yes there is a trunk" : "No there is not a trunk";

        Console.WriteLine($"{hasTrunkAnswer} and it has {numberOfDoors} doors\n");
    }

    public Car()
	{
	}
}


