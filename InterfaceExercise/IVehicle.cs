using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        public int NumOfWheels { get; set; }
        public int NumOfDoors { get; set; }
        public bool HasSunroof { get; set; }
        public bool IsElectric { get; set; }
    }
}
