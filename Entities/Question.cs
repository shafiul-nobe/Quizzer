using System.Collections.Generic;


namespace Entities
{
    public class Question : EntityBase
    {
        public string QuestionDetail { get; set; }
        public List<string> Options { get; set; }
        public string CorrectOption { get; set; }
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string ChapterId { get; set; }
        public string ChapterName { get; set; }
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public int Level { get; set; }
        public int ImportantLevel { get; set; }
        public double Rating { get; set; }
        public string Explanation { get; set; }

    }
}
