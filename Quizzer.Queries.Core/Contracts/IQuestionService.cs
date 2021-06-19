using Quizzer.Queries.Models.Question;
using Quizzer.Queries.Queries.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Core.Contracts
{
    public interface IQuestionService
    {
        Task<GetQuestionByIdQueryResponseModel> GetQuestionById(GetQuestionByIdQuery query);
    }
}
