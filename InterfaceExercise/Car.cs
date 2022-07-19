using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public string TrunkSize { get; set; }
        public int NumOfWheels { get; set; }
        public int NumOfDoors { get; set; }
        public bool HasSunroof { get; set; }
        public bool IsElectric { get; set; }
        public string Address { get; set; }
        public int NumOfEmployees { get; set; }

    }
}
