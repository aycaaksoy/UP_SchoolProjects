using CRM.Business.Layer.Concrete;
using CRM.DTO.Layer.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Business.Layer.ValidationRules.ContactValidation
{
    public class ContactAddValidator:AbstractValidator<ContactAddDTO>
    {
        public ContactAddValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Cannot be empty");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Cannot be empty");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Cannot be empty");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("Must be at least 5 characters");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Cannot be more than 100 characters");
        }
    }
}
