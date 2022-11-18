using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.E_Commerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public decimal UnitPrice { get; set; }
        
        public int Quantity { get; set; }

        public string Description { get; set; }

        public float Rating { get; set; }
        
        public double Discount { get; set; }

        public int CategoryID { get; set; } 

        public virtual Category Category { get; set; }

        public virtual List<ProductInStock> ProductInStocks { get; set; }

        public virtual List<ProductImages> ProductImages { get; set; }

        public virtual List<OrderDetails> OrderDetails { get; set; }






    }
}
