using MediatR;
using Quizzer.Queries.Models;
using Quizzer.Queries.Models.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Queries.Question
{
    public class QuestionByIdQuery : IRequest<QueryResponse<QuestionByIdQueryResponseModel>>
    {
        public string ItemId { get; set; }
    }
}
