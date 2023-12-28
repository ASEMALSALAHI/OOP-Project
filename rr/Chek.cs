using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rr
{
    class Chek : Payment
    {
        public string Name { get; set; }
        public int BankID { get; set; }

        public int authorized()
        {
            return 1;
        }
        public override void Pay(float price)
        {
            PaymentAmount = price;
        }
    }
}
