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
        private readonly IQuestionQueryService questionService;

        public QuestionsByClassQueryHandler(IQuestionQueryService questionService)
        {
            this.questionService = questionService;
        }

        public async Task<QueryResponse<QuestionsByClassQueryResponseModel>> Handle(QuestionsByClassQuery query, CancellationToken cancellationToken)
        {
            var questions = questionService.GetQuestionsByClass(query);
            questions.PageSize = query.PageSize;
            questions.TotalCount = questions.Questions.Count();
            questions.TotalPages = (int)Math.Ceiling(questions.TotalCount / (double)questions.PageSize);
            questions.CurrentPage = query.PageNumber;
            questions.Questions = questions.Questions.Skip((query.PageNumber - 1) * query.PageSize).Take(query.PageSize).ToList();

            return QueryResponse<QuestionsByClassQueryResponseModel>.Success(questions);
        }

    }
}
