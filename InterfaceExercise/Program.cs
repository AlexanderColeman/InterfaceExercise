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

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            
            List<IVehicle> vehicleList = new List<IVehicle>();

            var car = new Car()
            {
                HasSunroof = true,
                TrunkSize = "Small",
                NumOfWheels = 4,
                NumOfDoors = 2,
                IsElectric = true,
                Address = "1234 bolt Dr",
                NumOfEmployees = 3,
            };


            var truck = new Truck()
            {
                HasSunroof = false,
                BedSize = "Large",
                NumOfWheels = 6,
                NumOfDoors = 4,
                IsElectric = false,
                Address = "3456 Diamond lane",
                NumOfEmployees = 90,
            };

            var suv = new Suv()
            {
                HasSunroof = true,
                HatchBackSize = "Large",
                NumOfWheels = 4,
                NumOfDoors = 4,
                IsElectric = true,
                Address = "7896 Evergreen Circle",
                NumOfEmployees = 168,
            };

            vehicleList.Add(car);
            vehicleList.Add(truck);
            vehicleList.Add(suv);

            foreach (var item in vehicleList)
            {
                Console.WriteLine(item.HasSunroof);
                Console.WriteLine(item.NumOfWheels);
                Console.WriteLine(item.NumOfDoors);
                Console.WriteLine(item.IsElectric);
                Console.WriteLine(item.Address);
                Console.WriteLine(item.NumOfEmployees);
                Console.WriteLine();
                Console.WriteLine();
            }
            


        }
    }
}
