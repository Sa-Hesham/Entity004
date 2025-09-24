using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionB.Model
{
  public class Payment
    {

        public int Id { get; set; }
        public decimal Amount { get; set; }
    }

    public class CreditCardPayment : Payment
    {
        public string CardNumber { get; set; } = null!;
    }

    public class CashPayment : Payment
    {
        public string Currency { get; set; } = null!;
    }
}
