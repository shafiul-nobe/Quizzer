using Entities.SecondaryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class SubjectDto
    {
        public string ItemId { get; set; }
        public string SubjectName { get; set; }
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public Double Rating { get; set; }
        public int SUbjectNumber { get; set; }
        public List<SubjectChapter> SubjectChapters { get; set; }
        public SubjectDto()
        {
            this.SubjectChapters = new List<SubjectChapter>();
        }
    }
}
