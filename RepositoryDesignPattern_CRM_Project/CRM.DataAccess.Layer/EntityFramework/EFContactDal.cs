using CRM.Business.Layer.Concrete;
using CRM.DataAccess.Layer.Abstract;
using CRM.DataAccess.Layer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataAccess.Layer.EntityFramework
{
    public class EFContactDal:GenericRepository<Contact>, IContactDal
    {

    }
}
