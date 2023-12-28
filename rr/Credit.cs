using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rr
{
    class Credit : Payment
    {
        public string CartNo { get; set; }
        public string  Type { get; set; }
        public DateTime expDate { get; set; }

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
