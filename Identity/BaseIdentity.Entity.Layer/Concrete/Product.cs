using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseIdentity.Entity.Layer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; } 
        public string ProductName { get; set; }
        public int UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
