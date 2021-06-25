using Quizzer.Queries.Models.Question;
using Quizzer.Queries.Queries.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Contracts
{
    public interface IQuestionQueryService
    {
        QuestionByIdQueryResponseModel GetQuestionById(QuestionByIdQuery query);
        QuestionsByClassQueryResponseModel GetQuestionsByClass(QuestionsByClassQuery query);
        QuestionsByChapterQueryResponseModel GetQuestionsByChapter(QuestionsByChapterQuery query);
    }
}
