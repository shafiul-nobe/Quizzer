using Application.Question.Contracts;
using Domain.Model;
using Domain.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question.QueryHandler
{
    public class QuestionByIdQueryHandler : IRequestHandler<QuestionByIdQuery, QuestionByIdQueryResponseModel>
    {
        private readonly IQuestionService questionService;

        public QuestionByIdQueryHandler(IQuestionService questionService)
        {
            this.questionService = questionService;
        }
        public Task<QuestionByIdQueryResponseModel> Handle(QuestionByIdQuery query, CancellationToken cancellationToken)
        {
            return questionService.GetQuestionById(query);
        }
    }
}
