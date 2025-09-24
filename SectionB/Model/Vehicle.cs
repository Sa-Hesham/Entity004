using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionB.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Model { get; set; } = null!;
        public int Speed { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
    }

    public class Bus : Vehicle
    {
        public int Capacity { get; set; }
    }
}
