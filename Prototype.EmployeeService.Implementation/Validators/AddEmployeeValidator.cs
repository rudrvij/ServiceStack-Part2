using Prototype.EmployeeService.Contracts;
using ServiceStack.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.EmployeeService.Implementation.Validators
{
    public class AddEmployeeValidator: AbstractValidator<AddEmployee>
    {
        public AddEmployeeValidator()
        {
            RuleFor(p => p.CompanyId).NotEmpty().WithMessage("CompanyId cannot be empty");
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("FirstName cannot be empty");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Last Name cannot be empty");
            RuleFor(p => p.SSN).NotEmpty().WithMessage("Not a valid SSN");
            RuleFor(p => p.EmailAddress)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Not a valid Email Address");
        }
    }
}
