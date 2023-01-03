using CRM.DataAccess.Layer.Abstract;
using CRM.DataAccess.Layer.Repository;
using CRM.Entity.Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataAccess.Layer.EntityFramework
{
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        public void GetProductByCategory()
        {
            throw new NotImplementedException();
        }
    }
}
