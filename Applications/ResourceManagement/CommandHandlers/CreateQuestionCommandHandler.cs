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
    public class CreateQuestionCommandHandler : IRequestHandler<CreateQuestionCommand, CommandResponse<Unit>>
    {
        private readonly IQuestionCommandService questionService;

        public CreateQuestionCommandHandler(IQuestionCommandService questionService)
        {
            this.questionService = questionService;
        }
        public async Task<CommandResponse<Unit>> Handle(CreateQuestionCommand command, CancellationToken cancellationToken)
        {
            questionService.CreateQuestion(command);
            return CommandResponse<Unit>.Success(Unit.Value);
        }
    }
}
