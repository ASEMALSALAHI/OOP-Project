using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rr
{
    class Cash : Payment
    {
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
