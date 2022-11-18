using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.E_Commerce.Models
{
    public class Stores
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public virtual List<ProductInStock> ProductInStocks { get; set; }

        public virtual List<Order> Orders { get; set; }





    }
}
