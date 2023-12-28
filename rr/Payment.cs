using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rr
{
    abstract class Payment
    {
        public float PaymentAmount { get; set; }

        public abstract void Pay(float price);
        
    }
}
