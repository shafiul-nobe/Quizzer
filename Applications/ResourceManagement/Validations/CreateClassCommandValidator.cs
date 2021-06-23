using FluentValidation;
using ResourceManagement.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Validations
{
    public class CreateClassCommandValidator : AbstractValidator<CreateClassCommand>
    {
        public CreateClassCommandValidator()
        {
            RuleFor(c => c.ItemId).NotEmpty();
            RuleFor(c => c.ClassName).NotEmpty();
        }
    }
}
