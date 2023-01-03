using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Entity.Layer.Concrete
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        public string SupplierCompaanyName { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierMail { get; set; }
        public string SupplierPersonName { get; set; }
    }
}
