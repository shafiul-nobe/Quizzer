using Domain.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Commands
{
    public class CreateSubjectCommand : IRequest<CommandResponse<Unit>>
    {
        public string ItemId { get; set; }
        public string SubjectName { get; set; }
        public string ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
