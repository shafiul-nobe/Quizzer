using Domain.Model;
using Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Question.Contracts
{
    public interface IQuestionService
    {
        Task<QuestionByIdQueryResponseModel> GetQuestionById(QuestionByIdQuery query);
    }
}
