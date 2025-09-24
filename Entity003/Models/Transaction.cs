using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity003.Models
{
    public class Transaction
    {
        public string discription { get; set; } = null!;
        public int TransactId { get; set; }
        public int Amuont { get; set; }

        public DateTime Date{ get; set; }



        public  int AireLineId {  get; set; }
        public AireLine aireLine { get; set; } =null!;


         




    }
}
