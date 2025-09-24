using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity003.Models
{
    public class AireLine
    {
        public string AireLine_Name { get; set; } = null!;
        public int AireLineId { get; set; }

        public string ? ContactPerson { get; set; } = null!;


        public string Adress{ get; set; } = null!;


        //Add list of phone numbers

        public ICollection<Phones> AirelinePhones { get; set; }= new List<Phones>();


        //Aireline Has many Employee

       public ICollection<Employee> employeesworks { get; set; } = new List<Employee>();



        //AireLine Has many transaction 

       public ICollection<Transaction> transactions { get; set; }= new HashSet<Transaction>();    


       //aire line Has many aircraft

       public ICollection<AireCraft> airecraftsOwned { get; set; } =new HashSet<AireCraft> ();
    }
}
