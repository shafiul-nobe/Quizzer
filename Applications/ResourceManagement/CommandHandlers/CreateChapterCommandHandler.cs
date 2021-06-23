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
    public class CreateChapterCommandHandler : IRequestHandler<CreateChapterCommand, CommandResponse<Unit>>
    {
        private readonly IChapterCommandService chapterService;

        public CreateChapterCommandHandler(IChapterCommandService chapterService)
        {
            this.chapterService = chapterService;
        }
        public async Task<CommandResponse<Unit>> Handle(CreateChapterCommand command, CancellationToken cancellationToken)
        {
            chapterService.CreateChapter(command);
            return CommandResponse<Unit>.Success(Unit.Value);
        }
    }
}
