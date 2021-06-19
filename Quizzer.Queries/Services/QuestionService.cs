using Entities;
using Infrastructure.Contracts;
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
    public class QuestionService : IQuestionService
    {
        private readonly IRepository repository;

        public QuestionService(IRepository repository)
        {
            this.repository = repository;
        }
        public QuestionByIdQueryResponseModel GetQuestionById(QuestionByIdQuery query)
        {
            var question = repository.GetItem<Question>(x => x.ItemId == query.ItemId);

            var QuestionByIdQueryResponseModel = new QuestionByIdQueryResponseModel()
            {
                ItemId = question.ItemId,
                CorrectOption = question.CorrectOption,
                Options = question.Options,
                Question = question.QuestionDetail
            };

            return QuestionByIdQueryResponseModel;
        }
    }
}
