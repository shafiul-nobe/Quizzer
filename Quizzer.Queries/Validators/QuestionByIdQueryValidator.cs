using FluentValidation;
using Quizzer.Queries.Queries.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Validators
{
    public class QuestionByIdQueryValidator : AbstractValidator<QuestionByIdQuery>
    {
        public QuestionByIdQueryValidator()
        {
            RuleFor(x => x.ItemId).NotEmpty();
        }
    }
}
