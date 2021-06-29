using Domain.Core;
using MediatR;
using ModelTest.Commands;
using ModelTest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ModelTest.CommandHandler
{
    public class CreateModelTestCommandHandler : IRequestHandler<CreateModelTestCommand, CommandResponse<Unit>>
    {
        private readonly IModelTestCommandService modelTestService;

        public CreateModelTestCommandHandler(IModelTestCommandService modelTestService)
        {
            this.modelTestService = modelTestService;
        }
        public async Task<CommandResponse<Unit>> Handle(CreateModelTestCommand command, CancellationToken cancellationToken)
        {
            modelTestService.CreateModelTest(command);
            return CommandResponse<Unit>.Success(Unit.Value);
        }
    }
}
