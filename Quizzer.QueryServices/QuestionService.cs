using Entities;
using Infrastructure.Contracts;
using Quizzer.Queries.Models.Question;
using Quizzer.Queries.Queries.Question;
using Quizzer.QueryServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.QueryServices
{
    public class QuestionService : IQuestionService
    {
        private readonly IRepository repository;

        public QuestionService(IRepository repository)
        {
            this.repository = repository;
        }
        public Task<GetQuestionByIdQueryResponseModel> GetQuestionById(GetQuestionByIdQuery query)
        {
            var question = repository.GetItem<Question>(x => x.ItemId == query.ItemId);

            var QuestionByIdQueryResponseModel = new GetQuestionByIdQueryResponseModel()
            {
                ItemId = question.ItemId,
                CorrectOption = question.CorrectOption,
                Options = question.Options,
                Question = question.QuestionDetail
            };

            return Task.FromResult(QuestionByIdQueryResponseModel);
        }
    }
}
