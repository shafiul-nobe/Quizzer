using MediatR;
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
    public class GetQuestionByIdQueryHandler : IRequestHandler<GetQuestionByIdQuery, GetQuestionByIdQueryResponseModel>
    {
        public Task<GetQuestionByIdQueryResponseModel> Handle(GetQuestionByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
