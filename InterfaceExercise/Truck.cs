using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public String BedSize { get; set; }
        public int NumOfWheels { get; set; }
        public int NumOfDoors { get; set; }
        public bool HasSunroof { get; set; }
        public bool IsElectric { get; set; }
        public string Address { get; set; }
        public int NumOfEmployees { get; set; }


    }
}
