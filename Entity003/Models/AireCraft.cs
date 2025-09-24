using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity003.Models
{
    public class AireCraft
    {
        public int Id { get; set; }

        public string Model { get; set; } = null!;
        public int  Capcity { get; set; }


        // add crew in Airecraft Table 
        public Crew crewDetails { get; set; } =null!;



        //aire craft owend by one aire lines
        public int AireLineOwnerId { get; set; }
        public AireLine? AireLineOwner { get; set; } = null!;
      
    


       public ICollection<AireCraftRoute> AireCraftAssign { get; set; }= new List<AireCraftRoute>();  
      
    }
}
