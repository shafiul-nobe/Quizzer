using FluentValidation;
using ResourceManagement.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Validations
{
    public class CreateQuestionCommandValidator : AbstractValidator<CreateQuestionCommand>
    {
        public CreateQuestionCommandValidator()
        {
            RuleFor(c => c.ItemId).NotEmpty();
            RuleFor(c => c.Question).NotEmpty();
            RuleFor(c => c.Options).Cascade(CascadeMode.Stop).Must(ValidateOptions).WithMessage("must contain four options");
            RuleFor(c => c.CorrectOption).NotEmpty();
        }

        private bool ValidateOptions(List<string> options)
        {

            if (options.Count != 4)
            {
                return false;
            }
            return true;
        }
    }
}
