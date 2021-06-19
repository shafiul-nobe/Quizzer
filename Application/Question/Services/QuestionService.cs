using Application.Question.Contracts;
using Domain.Model;
using Domain.Queries;
using Entities;
using Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Question.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IRepository repository;

        public QuestionService(IRepository repository)
        {
            this.repository = repository;
        }
        public Task<QuestionByIdQueryResponseModel> GetQuestionById(QuestionByIdQuery query)
        {
            var question = repository.GetItem<Entities.Question>(x => x.ItemId == query.ItemId);

            var QuestionByIdQueryResponseModel = new QuestionByIdQueryResponseModel()
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
