using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values


            Car car1 = new Car() { hasTrunk = true, numberOfDoors = 4, numberOfWheels = 4, hornSound = "Honk Honk", hasAxil = true, numberOfSeats = 5, brand = "Chevy", model = "Impala" };
            car1.PrintICompany();
            car1.PrintIVheicle();
            car1.PrintCar();



            Truck truck1 = new Truck() { hasTruckBed = true, towCapacity = 8000, numberOfWheels = 4, hornSound = "HOOONK", hasAxil = true, numberOfSeats = 5, brand = "Ford", model = "F-150" };
            truck1.PrintICompany();
            truck1.PrintIVheicle();
            truck1.PrintTruck();


            SUV suv1 = new SUV() { trunkSpace = 60, threeSeatRows = true, numberOfWheels = 4, hornSound = "Beeeeep", hasAxil = true, numberOfSeats = 8, brand = "Lincoln", model = "Navigator" };
            suv1.PrintICompany();
            suv1.PrintIVheicle();
            suv1.PrintSuv();


            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
