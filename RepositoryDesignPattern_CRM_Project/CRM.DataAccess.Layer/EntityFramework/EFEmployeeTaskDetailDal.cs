using CRM.DataAccess.Layer.Abstract;
using CRM.DataAccess.Layer.Concrete;
using CRM.DataAccess.Layer.Repository;
using CRM.Entity.Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataAccess.Layer.EntityFramework
{
    public class EFEmployeeTaskDetailDal : GenericRepository<EmployeeTaskDetail>, IEmployeeTaskDetailDal
    {
        public List<EmployeeTaskDetail> GetEmployeeTaskDetailById(int id)
        {
            using (var context = new Context())
            {
                return context.EmployeeTaskDetails.Where(x => x.EmployeeTaskID == id).ToList();
            }
        }
    }
}
