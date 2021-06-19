using Domain.Core;
using MediatR;
using ResourceManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Commands
{
    public class CreateQuestionCommand : IRequest<CommandResponse<Unit>>
    {
        public string ItemId { get; set; }
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public string CorrectOption { get; set; }
        public string ClassId { get; set; }
        public string SubjectId { get; set; }
    }
}
