using Application.Core;
using Domain.DTOs;
using Entities.SecondaryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Models.Subject
{
    public class SubjectsByClassQueryResponseModel : PagedList
    {
        public List<SubjectDto> Subjects { get; set; }
        public SubjectsByClassQueryResponseModel()
        {
            this.Subjects =  new List<SubjectDto>();
        }

    }
}
