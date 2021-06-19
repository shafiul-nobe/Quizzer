using System.Collections.Generic;


namespace Entities
{
    public class Question : EntityBase
    {
        public string QuestionDetail { get; set; }
        public List<string> Options { get; set; }
        public string CorrectOption { get; set; }
    }
}
