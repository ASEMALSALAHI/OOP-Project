using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace rr
{
    class order
    {
        
        
        public DateTime OrederDater { get; set; }
        public int OrderID { get; set; }
        public Customer OrderCust = new Customer();

       public OrderDetails Order_Details = new OrderDetails();
        public order(Customer Cust)
        {
            
            this.OrderCust = Cust;
        }
        public float GetTotalWeight()
        {
        
            float TotalWeght = 0;


            return TotalWeght;
        }
        public float CalcTax(int price)
        {
           return price = price + price * 18 / 100;

        }
       
    }
}
