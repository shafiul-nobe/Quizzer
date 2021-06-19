using Domain.Core;
using MediatR;
using ResourceManagement.Commands;
using ResourceManagement.Contracts;
using ResourceManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResourceManagement.CommandHandlers
{
    public class CreateQuestionCommandHandler : IRequestHandler<CreateQuestionCommand, CommandResponse<Unit>>
    {
        private readonly IResourceManagementService resourceManagementService;

        public CreateQuestionCommandHandler(IResourceManagementService resourceManagementService)
        {
            this.resourceManagementService = resourceManagementService;
        }
        public async Task<CommandResponse<Unit>> Handle(CreateQuestionCommand command, CancellationToken cancellationToken)
        {
            resourceManagementService.CreateQuestion(command);
            return CommandResponse<Unit>.Success(Unit.Value);
        }
    }
}
