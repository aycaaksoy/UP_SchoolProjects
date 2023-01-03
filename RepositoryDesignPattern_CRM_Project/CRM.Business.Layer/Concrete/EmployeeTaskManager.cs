using CRM.Business.Layer.Abstract;
using CRM.DataAccess.Layer.Abstract;
using CRM.DataAccess.Layer.EntityFramework;
using CRM.Entity.Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Business.Layer.Concrete
{
    public class EmployeeTaskManager : IEmployeeTaskService
    {
        IEmployeeTaskDal _employeeTaskDal;

        public EmployeeTaskManager(IEmployeeTaskDal employeeTaskDal)
        {
            _employeeTaskDal = employeeTaskDal;
        }

        public void TDelete(EmployeeTask t)
        {
            throw new NotImplementedException();
        }

        public EmployeeTask TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeTask> TGetEmployeeTaskByEmployee()
        {
            return _employeeTaskDal.GetEmployeeTaskByEmployee();
        }

        public List<EmployeeTask> TGetEmployeeTaskById(int id)
        {
            return _employeeTaskDal.GetEmployeeTaskById(id);
        }

        public List<EmployeeTask> TGetList()
        {
            return _employeeTaskDal.GetList();
        }

        public void TInsert(EmployeeTask t)
        {
            _employeeTaskDal.Insert(t);
        }

        public void TUpdate(EmployeeTask t)
        {
            throw new NotImplementedException();
        }
    }
}
