using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.SecondaryEntity
{
    public class QuestionResult
    {
        public string QuestionId { get; set; }
        public string SelectedOption { get; set; }
        public Boolean Correct { get; set; }
        public QuestionResult()
        {
            this.Correct = false;
        }
    }
}
