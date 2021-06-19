﻿using Entities;
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
            if (question == null)
                return null;
            return question.QuestionByIdQueryResponseModel();
        }

        public QuestionsByClassQueryResponseModel GetQuestionsByClass(QuestionsByClassQuery query)
        {
            var questions = repository.GetItems<Question>(x => x.ClassId == query.ClassId).ToList();
            if (questions.Count() == 0)
                return null;
            return questions.QuestionsByClassQueryResponseModel();

        }
    }
}
