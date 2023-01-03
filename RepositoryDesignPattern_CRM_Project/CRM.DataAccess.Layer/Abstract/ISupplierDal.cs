using CRM.Entity.Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataAccess.Layer.Abstract
{
    public class ISupplierDal : IGenericDal<Supplier>
    {
        public void Delete(Supplier t)
        {
            throw new NotImplementedException();
        }

        public Supplier GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(Supplier t)
        {
            throw new NotImplementedException();
        }

        public void Update(Supplier t)
        {
            throw new NotImplementedException();
        }
    }
}
