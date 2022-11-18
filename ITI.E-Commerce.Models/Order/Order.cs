using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.E_Commerce.Models
{
    public class Order
    {
        public int Id { get; set; } // primary key

        public string CustomerID { get; set; } //Fk for Customer 

        public int ShipperID { get; set; } //FK for Shippers

        public int StoreID { get; set; } //FK for Store

        public DateTime OrderDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public string ShippingAddress { get; set; }

        public double DeliveryCost { get; set; }
        

        public virtual Customer Customers { get; set; }

        public virtual Shipper Shippers { get; set; }

        public virtual Stores Stores { get; set; }

        public virtual List <OrderDetails> OrderDetails { get; set; }












    }
}
