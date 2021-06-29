using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Contracts;
using MediatR;
using Entities;
using ResourceManagement.Contracts;
using System.Threading.Tasks;
using ResourceManagement.Commands;
using ModelTest.Commands;

namespace API.Controllers
{
    
    public class QuizzerCommnadController : BaseApiController
    {
        private readonly IQuestionCommandService resourceManagementService;

        public IMediator _mediator { get; }
        public QuizzerCommnadController(IQuestionCommandService resourceManagementService, IMediator mediator)
        {
            this.resourceManagementService = resourceManagementService;
            _mediator = mediator;
        }


        [HttpPost("CreateQuestion")]
        public async Task<IActionResult> CreateQuestion([FromBody] CreateQuestionCommand createQuestionCommand)
        {
            var result = await _mediator.Send(createQuestionCommand);
            return HandleResult(result);
        }

        [HttpPost("CreateClass")]
        public async Task<IActionResult> CreateClass([FromBody] CreateClassCommand createClassCommand)
        {
        var result = await _mediator.Send(createClassCommand);
            return HandleResult(result);
        }

        [HttpPost("CreateSubject")]
        public async Task<IActionResult> CreateSubject([FromBody] CreateSubjectCommand createSubjectCommand)
        {
            var result = await _mediator.Send(createSubjectCommand);
            return HandleResult(result);
        }

        [HttpPost("CreateChapter")]
        public async Task<IActionResult> CreateChapter([FromBody] CreateChapterCommand createChapterCommand)
        {
            var result = await _mediator.Send(createChapterCommand);
            return HandleResult(result);
        }

        [HttpPost("CreatePackage")]
        public async Task<IActionResult> CreatePackage([FromBody] CreatePackageCommand createPackageCommand)
        {
            var result = await _mediator.Send(createPackageCommand);
            return HandleResult(result);
        }

        [HttpPost("CreateModelTest")]
        public async Task<IActionResult> CreateModelTest([FromBody] CreateModelTestCommand createModelTestCommand)
        {
            var result = await _mediator.Send(createModelTestCommand);
            return HandleResult(result);
        }
    }
}
