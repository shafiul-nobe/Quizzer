using Domain.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTest.Commands
{
    public class CreateModelTestCommand : IRequest<CommandResponse<Unit>>
    {
        public string ItemId { get; set; }
        public DateTime ExamDate { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime RankingPublishingTime { get; set; }
        public int TotalQuestion { get; set; }
        public Boolean IsPaid { get; set; }
        public string PackageId { get; set; }
        public string SubjectId { get; set; }
        public string ClassId { get; set; }
    }
}
