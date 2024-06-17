using System;

public interface ICompany
{
    public string brand { get; set; }
    public string model { get; set; }

    public void PrintICompany()
    {
        Console.WriteLine(brand + " " + model);
    }
}


