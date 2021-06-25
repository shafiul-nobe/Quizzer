using Application.Core;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Models.Question
{
    public class QuestionsByChapterQueryResponseModel : PagedList
    {
        public List<QuestionDto> Questions { get; set; }
        public QuestionsByChapterQueryResponseModel()
        {
            this.Questions = new List<QuestionDto>();
        }
    }
}
