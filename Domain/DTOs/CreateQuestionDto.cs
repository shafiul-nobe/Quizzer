using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class CreateQuestionDto
    {
        public string ItemId { get; set; }
        public string question  { get; set; }
        public List<string> Options { get; set; }
        public string CorrectOption { get; set; }
    }
}
