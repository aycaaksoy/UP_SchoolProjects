using CRM.Entity.Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Business.Layer.ValidationRules
{
    public class EmployeeValidator: AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("Employee name cannot be empty");
            RuleFor(x => x.EmployeeSurname).NotEmpty().WithMessage("Employee surname cannot be empty");
            RuleFor(x => x.EmployeeName).MinimumLength(2).WithMessage("Should be at least 2 characters long");
            RuleFor(x => x.EmployeeSurname).MaximumLength(20).WithMessage("Should be max 20 characters long");
        }
    }
}
