using Domain.Core;
using MediatR;
using ResourceManagement.Commands;
using ResourceManagement.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResourceManagement.CommandHandlers
{
    public class CreateSubjectCommandHandler : IRequestHandler<CreateSubjectCommand, CommandResponse<Unit>>
    {
        private readonly ISubjectCommandService subjectService;

        public CreateSubjectCommandHandler(ISubjectCommandService subjectService)
        {
            this.subjectService = subjectService;
        }
        public async Task<CommandResponse<Unit>> Handle(CreateSubjectCommand command, CancellationToken cancellationToken)
        {
            subjectService.CreateSubject(command);
            return CommandResponse<Unit>.Success(Unit.Value);
        }
    }
}
