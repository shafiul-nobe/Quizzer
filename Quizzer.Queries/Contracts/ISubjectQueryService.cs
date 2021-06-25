using Quizzer.Queries.Models.Subject;
using Quizzer.Queries.Queries.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Contracts
{
    public interface ISubjectQueryService
    {
        SubjectsByClassQueryResponseModel GetSubjectsByClass(SubjectsByClassQuery query);
    }
}
