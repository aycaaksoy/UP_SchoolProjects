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
    public class EmployeeTaskDetailManager : IEmployeeTaskDetailService
    {
        private readonly IEmployeeTaskDetailDal _employeeTaskDetailDal;

        public EmployeeTaskDetailManager(IEmployeeTaskDetailDal employeeTaskDetailDal)
        {
            _employeeTaskDetailDal = employeeTaskDetailDal;
        }

        public void TDelete(EmployeeTaskDetail t)
        {
            throw new NotImplementedException();
        }

        public EmployeeTaskDetail TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeTaskDetail> TGetEmployeeTaskDetailById(int id)
        {
            return _employeeTaskDetailDal.GetEmployeeTaskDetailById(id);
        }

        public List<EmployeeTaskDetail> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(EmployeeTaskDetail t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(EmployeeTaskDetail t)
        {
            throw new NotImplementedException();
        }
    }
}
