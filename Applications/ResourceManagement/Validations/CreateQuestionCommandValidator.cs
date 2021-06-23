using Entities;
using FluentValidation;
using Infrastructure.Contracts;
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
        private readonly IRepository repository;
        public CreateQuestionCommandValidator(IRepository repository )
        {
            this.repository = repository;
            RuleFor(c => c.ItemId).NotEmpty();
            RuleFor(c => c.Question).NotEmpty();
            RuleFor(c => c.Options).Cascade(CascadeMode.Stop).Must(ValidateOptions).WithMessage("must contain four options");
            RuleFor(c => c.CorrectOption).NotEmpty();
           /* RuleFor(c => c.ClassId).Cascade(CascadeMode.Stop).Must(ValidateClassId).WithMessage("ClassId doesn't exist");*/
        }

        private bool ValidateOptions(List<string> options)
        {

            if (options.Count != 4)
            {
                return false;
            }
            return true;
        }
        private bool ValidateClassId(string classId)
        {
            var studentClass =  repository.GetItem<StudentClass>(x => x.ItemId == classId);
            if (studentClass == null)
                return false;
            return true;
        }
    }
}
