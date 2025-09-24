using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity003.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Position { get; set; } = null!;
        public int BD_Year { get; set; }  
        public int BD_Month { get; set; }
        public int BD_Day { get; set; }
        public int AireId { get; set; }


        //employeeHasmanyQualifications in sperated table

        public ICollection<Qualifacion> EmpQualifications { get; set; }=new List<Qualifacion>();




        //Employee works on  one aire line 

        
        public AireLine AireLine { get; set; } =null!;


    }
}
