using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Chapter : EntityBase
    {
        public string ChapterName { get; set; }
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string ChapterNumber { get; set; }
    }
}
