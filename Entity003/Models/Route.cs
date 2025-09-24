using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity003.Models
{
    public class Route
    {
        public string Calssification { get; set; } = null!;
        public  int RouteId { get; set; }

        public string Distnation { get; set; } = null!;

        public string Origin { get; set; } = null!;

        public int Distance { get; set; }


      public  ICollection<AireCraftRoute> routes { get; set; }=new List<AireCraftRoute>();     

    }
}
