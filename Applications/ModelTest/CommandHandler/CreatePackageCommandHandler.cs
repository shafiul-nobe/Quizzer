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
   public class CreatePackageCommandHandler : IRequestHandler<CreatePackageCommand, CommandResponse<Unit>>
    {
        private readonly IPackageCommandService packageService;

        public CreatePackageCommandHandler(IPackageCommandService chapterService)
        {
            this.packageService = chapterService;
        }
        public async Task<CommandResponse<Unit>> Handle(CreatePackageCommand command, CancellationToken cancellationToken)
        {
            packageService.CreatePackage(command);
            return CommandResponse<Unit>.Success(Unit.Value);
        }
    }
}
