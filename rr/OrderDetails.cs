using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rr
{
    class OrderDetails
    {
        public float OrderWeight { get; set; }
        public DateTime orderDate { get; set; }
        public int TotalItemPrice { get; set; }
        public int OrderQuantity { get; set; }
       public Items I_tems = new Items();
        public float Tax { get; set; } = 0.7f;


        public float CalcWeight()
        {
           
            return I_tems.ItemWeight * OrderQuantity;

        }

    }
}
