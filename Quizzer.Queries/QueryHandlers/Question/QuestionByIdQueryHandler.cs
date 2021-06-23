using MediatR;
using Quizzer.Queries.Contracts;
using Quizzer.Queries.Models;
using Quizzer.Queries.Models.Question;
using Quizzer.Queries.Queries.Question;
using System.Threading;
using System.Threading.Tasks;

namespace Quizzer.Queries.QueryHandlers.Question
{
    public class QuestionByIdQueryHandler : IRequestHandler<QuestionByIdQuery, QueryResponse<QuestionByIdQueryResponseModel>>
    {
        private readonly IQuestionQueryService questionService;

        public QuestionByIdQueryHandler(IQuestionQueryService questionService)
        {
            this.questionService = questionService;
        }

        public async Task<QueryResponse<QuestionByIdQueryResponseModel>> Handle(QuestionByIdQuery query, CancellationToken cancellationToken)
        {
            var question = questionService.GetQuestionById(query);

            return QueryResponse<QuestionByIdQueryResponseModel>.Success(question);
        }

       
    }
}
