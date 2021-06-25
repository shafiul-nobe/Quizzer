using MediatR;
using Quizzer.Queries.Contracts;
using Quizzer.Queries.Models;
using Quizzer.Queries.Models.Subject;
using Quizzer.Queries.Queries.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quizzer.Queries.QueryHandlers.Subject
{
    public class SubjectsByClassQueryHandler : IRequestHandler<SubjectsByClassQuery, QueryResponse<SubjectsByClassQueryResponseModel>>
    {
        private readonly ISubjectQueryService subjectService;

        public SubjectsByClassQueryHandler(ISubjectQueryService subjectService)
        {
            this.subjectService = subjectService;
        }

        public async Task<QueryResponse<SubjectsByClassQueryResponseModel>> Handle(SubjectsByClassQuery query, CancellationToken cancellationToken)
        {
            var subjects = subjectService.GetSubjectsByClass(query);
            subjects.PageSize = query.PageSize;
            subjects.TotalCount = subjects.Subjects.Count();
            subjects.TotalPages = (int)Math.Ceiling(subjects.TotalCount / (double)subjects.PageSize);
            subjects.CurrentPage = query.PageNumber;
            subjects.Subjects = subjects.Subjects.Skip((query.PageNumber - 1) * query.PageSize).Take(query.PageSize).ToList();

            return QueryResponse<SubjectsByClassQueryResponseModel>.Success(subjects);
        }

    }
}
