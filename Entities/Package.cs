using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Package : EntityBase
    {
        public string ClassId { get; set; }
        public List<string> SubjectIds { get; set; }
        public string AuthorUserId { get; set; }
        public string AuthorName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public int PackageName { get; set; }
        public string Description { get; set; }
        public string GuideLines { get; set; }
        public Boolean IsComplete { get; set; }
    }
}
