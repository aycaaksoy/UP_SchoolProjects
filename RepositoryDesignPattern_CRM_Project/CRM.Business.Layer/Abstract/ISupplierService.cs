using CRM.Entity.Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Business.Layer.Abstract
{
    public class ISupplierService : IGenericService<Supplier>
    {
        public void TDelete(Supplier t)
        {
            throw new NotImplementedException();
        }

        public Supplier TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Supplier t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Supplier t)
        {
            throw new NotImplementedException();
        }
    }
}
