using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.E_Commerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
