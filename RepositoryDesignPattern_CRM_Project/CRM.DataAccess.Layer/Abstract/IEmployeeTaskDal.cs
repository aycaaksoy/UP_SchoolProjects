
using CRM.DataAccess.Layer.Abstract;
using CRM.Entity.Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataAccess.Layer.Abstract
{
    public interface IEmployeeTaskDal : IGenericDal<EmployeeTask>
    {
        List<EmployeeTask> GetEmployeeTaskByEmployee();
        List<EmployeeTask> GetEmployeeTaskById(int id);
    }
}