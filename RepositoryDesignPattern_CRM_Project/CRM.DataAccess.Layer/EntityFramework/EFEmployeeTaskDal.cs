using CRM.DataAccess.Layer.Abstract;
using CRM.DataAccess.Layer.Concrete;
using CRM.DataAccess.Layer.Repository;
using CRM.Entity.Layer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataAccess.Layer.EntityFramework
{
    public class EFEmployeeTaskDal : GenericRepository<EmployeeTask>, IEmployeeTaskDal
    {
        public List<EmployeeTask> GetEmployeeTaskByEmployee()
        {
            using (var context = new Context())
            {
                var values = context.EmployeesTasks.Include(x => x.AppUser).ToList();
                return values;
            }
        }

        public List<EmployeeTask> GetEmployeeTaskById(int id)
        {
            using (var context = new Context())
            {
                var values = context.EmployeesTasks.Where(x => x.AppUserID == id).ToList();
                return values;
            }
        }
    }
}
