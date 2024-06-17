using System;

public interface IVehicle
{
    public int numberOfWheels { get; set; }
    public string hornSound { get; set; }
    public bool hasAxil { get; set; }
    public int numberOfSeats { get; set; }

    public void PrintIVheicle()
    {
        Console.WriteLine($"Has {numberOfWheels} wheels\n" +
            $"The horn goes {hornSound}\n" +
            $"It's {hasAxil} that is has an axil\n" +
            $"has {numberOfSeats} seats");
    }
}



