using Quizzer.Queries.Models.Question;
using Quizzer.Queries.Queries.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Contracts
{
    public interface IQuestionService
    {
        QuestionByIdQueryResponseModel GetQuestionById(QuestionByIdQuery query);
        public QuestionsByClassQueryResponseModel GetQuestionsByClass(QuestionsByClassQuery query);
    }
}
