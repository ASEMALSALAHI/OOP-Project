using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rr
{
    class Items
    {
        public float ItemShippingWeight { get; set; }
        public string  ItemDescription { get; set; }
        public int ItemId { get; set; }
        public int ItemWeight { get; set; }
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public float  ShippingWeight { get; set; }


        public int getPriceForQuantity(int quantity)
        {

            ItemPrice *= quantity;
            return ItemPrice;
        }

        public float GetWeight(int quantity)
        {

            return ShippingWeight * quantity;
        }
        
    }
}
