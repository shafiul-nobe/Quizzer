using Entities;
using Infrastructure.Contracts;
using Quizzer.Queries.Builders;
using Quizzer.Queries.Contracts;
using Quizzer.Queries.Models.Question;
using Quizzer.Queries.Queries.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Services
{
    public class QuestionQueryService : IQuestionQueryService
    {
        private readonly IRepository repository;

        public QuestionQueryService(IRepository repository)
        {
            this.repository = repository;
        }
        public QuestionByIdQueryResponseModel GetQuestionById(QuestionByIdQuery query)
        {
            var question = repository.GetItem<Question>(x => x.ItemId == query.ItemId);
            if (question == null)
                return null;
            return question.QuestionByIdQueryResponseModel();
        }

        public QuestionsByChapterQueryResponseModel GetQuestionsByChapter(QuestionsByChapterQuery query)
        {
            var questions = repository.GetItems<Question>(x => x.ChapterId == query.ChapterId).ToList();
            return questions.QuestionsByChapterQueryResponseModel();
        }

        public QuestionsByClassQueryResponseModel GetQuestionsByClass(QuestionsByClassQuery query)
        {
            var questions = repository.GetItems<Question>(x => x.ClassId == query.ClassId).ToList();
            return questions.QuestionsByClassQueryResponseModel();

        }
    }
}
