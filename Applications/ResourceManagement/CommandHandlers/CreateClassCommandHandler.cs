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
    public class CreateClassCommandHandler : IRequestHandler<CreateClassCommand, CommandResponse<Unit>>
    {
        private readonly IClassCommandService classService;

        public CreateClassCommandHandler(IClassCommandService classService)
        {
            this.classService = classService;
        }
        public async Task<CommandResponse<Unit>> Handle(CreateClassCommand command, CancellationToken cancellationToken)
        {
            classService.CreatClass(command);
            return CommandResponse<Unit>.Success(Unit.Value);
        }
    }
}
