using Entities;
using Infrastructure.Contracts;
using Quizzer.Queries.Builders;
using Quizzer.Queries.Contracts;
using Quizzer.Queries.Models.Subject;
using Quizzer.Queries.Queries.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Services
{
    public class SubjectQueryService : ISubjectQueryService
    {
        private readonly IRepository repository;

        public SubjectQueryService(IRepository repository)
        {
            this.repository = repository;
        }
        public SubjectsByClassQueryResponseModel GetSubjectsByClass(SubjectsByClassQuery query)
        {
            var subjects = repository.GetItems<Subject>(x => x.ClassId == query.ClassId).ToList();
            return subjects.SubjectsByClassQueryResponseModel();
        }
    }
}
