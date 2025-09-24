using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity003.Models
{
  
    public class Qualifacion
    {
        public string Qualificatons { get; set; } = null!;

        public int EmployeeId{ get; set; }
    }
}
