using System;
using System.Reflection;

public class SUV: IVehicle, ICompany
{
	public int trunkSpace { get; set; }
	public bool threeSeatRows { get; set; }
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

    public void PrintSuv()
    {
        string hasThreeSeatRowsAnswer = (threeSeatRows == true) ? "Yes there are 3 seat rows" : "No there are not 3 seat rows";

        Console.WriteLine($"{hasThreeSeatRowsAnswer} and it has {trunkSpace} inches in trunk space\n");
    }

    public SUV()
	{
	}
}

