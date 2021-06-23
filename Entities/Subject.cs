using Entities.SecondaryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Subject : EntityBase
    {
        public string SubjectName { get; set; }
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public List<SubjectChapter> SubjectChapters { get; set; }
        public Double Rating { get; set; }
        public Subject()
        {
            this.SubjectChapters = new List<SubjectChapter>();
        }
    }
}
