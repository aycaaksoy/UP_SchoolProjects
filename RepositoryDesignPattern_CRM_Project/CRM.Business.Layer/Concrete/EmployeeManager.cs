using CRM.Business.Layer.Abstract;
using CRM.DataAccess.Layer.Abstract;
using CRM.Entity.Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Business.Layer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            this.employeeDal = employeeDal;
        }

        public void TChangeEmployeeStatusToFalse(int id)
        {
            employeeDal.ChangeEmployeeStatusToFalse(id);
        }

        public void TChangeEmployeeStatusToTrue(int id)
        {
            employeeDal.ChangeEmployeeStatusToTrue(id);
        }

        public void TDelete(Employee t)
        {
           employeeDal.Delete(t);
        }

        public Employee TGetById(int id)
        {
            return employeeDal.GetById(id);
        }

        public List<Employee> TGetEmpByCategory()
        {
            return employeeDal.GetEmpByCategory();
        }

        public List<Employee> TGetList()
        {
            return employeeDal.GetList();
        }

        public void TInsert(Employee t)
        {
            employeeDal.Insert(t);
        }

        public void TUpdate(Employee t)
        {
           employeeDal.Update(t);
        }
    }
}
