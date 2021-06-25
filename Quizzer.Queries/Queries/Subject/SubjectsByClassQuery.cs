using Domain.Core;
using MediatR;
using Quizzer.Queries.Models;
using Quizzer.Queries.Models.Question;
using Quizzer.Queries.Models.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Queries.Subject
{
    public class SubjectsByClassQuery : PagingParams, IRequest<QueryResponse<SubjectsByClassQueryResponseModel>>
    {
        public string ClassId { get; set; }
    }
}
