using Domain.Core;
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
    public class QuestionsByChapterQuery : PagingParams, IRequest<QueryResponse<QuestionsByChapterQueryResponseModel>>
    {
        public string ChapterId { get; set; }
    }
}
