using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Models.Question
{
    public class QuestionByIdQueryResponseModel
    {
        public string ItemId { get; set; }
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public string CorrectOption { get; set; }
    }
}
