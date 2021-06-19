using MediatR;
using Quizzer.Queries.Contracts;
using Quizzer.Queries.Models;
using Quizzer.Queries.Models.Question;
using Quizzer.Queries.Queries.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quizzer.Queries.QueryHandlers
{
    public class QuestionByIdQueryHandler : IRequestHandler<QuestionByIdQuery, QueryResponse<QuestionByIdQueryResponseModel>>
    {
        private readonly IQuestionService questionService;

        public QuestionByIdQueryHandler(IQuestionService questionService)
        {
            this.questionService = questionService;
        }
       
         public async Task<QueryResponse<QuestionByIdQueryResponseModel>> Handle(QuestionByIdQuery query, CancellationToken cancellationToken)
        {
            var question =   questionService.GetQuestionById(query);

            return QueryResponse<QuestionByIdQueryResponseModel>.Success(question);
        }
    }
}
