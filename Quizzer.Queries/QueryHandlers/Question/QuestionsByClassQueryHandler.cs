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

namespace Quizzer.Queries.QueryHandlers.Question
{
    public class QuestionsByClassQueryHandler : IRequestHandler<QuestionsByClassQuery, QueryResponse<QuestionsByClassQueryResponseModel>>
    {
        private readonly IQuestionService questionService;

        public QuestionsByClassQueryHandler(IQuestionService questionService)
        {
            this.questionService = questionService;
        }

        public async Task<QueryResponse<QuestionsByClassQueryResponseModel>> Handle(QuestionsByClassQuery query, CancellationToken cancellationToken)
        {
            var questions = questionService.GetQuestionsByClass(query);

            return QueryResponse<QuestionsByClassQueryResponseModel>.Success(questions,questions.Questions.Count());
        }

        
    }
}
