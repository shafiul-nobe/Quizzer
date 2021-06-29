using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ModelTestExam : EntityBase
    {
        public DateTime ExamDate { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string AuthorUserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime RankingPublishingTime { get; set; }
        public int TotalQuestion { get; set; }
        public TimeSpan Duration { get; set; }
        public Boolean IsPaid { get; set; }
        public int SerialInPackage { get; set; }
        public string PackageId { get; set; }
        public string SubjectId { get; set; }
        public string ClassId { get; set; }
    }
}
