using Domain.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTest.Commands
{
    public class CreatePackageCommand : IRequest<CommandResponse<Unit>>
    {
        public string ItemId { get; set; }
        public string ClassId { get; set; }
        public List<string> SubjectIds { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int PackageName { get; set; }
        public string Description { get; set; }
        public string GuideLines { get; set; }
        public Boolean IsComplete { get; set; }
    }
}
