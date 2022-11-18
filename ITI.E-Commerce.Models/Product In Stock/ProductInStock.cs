using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.E_Commerce.Models
{
    public class ProductInStock
    {
        public int ProductID { get; set; } // FK for Product   

        public int StoreID { get; set; } // Fk For Stores
        
        public int Quantity { get; set; }

        public virtual Stores Stores { get; set; }

        public virtual Product Products { get; set; }



    }
}
