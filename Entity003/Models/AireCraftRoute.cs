using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity003.Models
{
   public  class AireCraftRoute
    {
        public int Num_of_Passengers { get; set; }
        public decimal Price { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public TimeSpan Duration { get; set; }


        public int AireCraftId { get; set; }
        public AireCraft AireCraft { get; set; } = null!;


        public int RouteId { get; set; }
        public Route Routes { get; set; } = null!;

        }
}
