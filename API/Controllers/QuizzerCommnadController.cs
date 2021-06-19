using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Contracts;
using MediatR;
using Entities;
using ResourceManagement.Contracts;
using ResourceManagement.Models;
using System.Threading.Tasks;
using ResourceManagement.Commands;

namespace API.Controllers
{
    
    public class QuizzerCommnadController : BaseApiController
    {
        private readonly IResourceManagementService resourceManagementService;

        public IMediator _mediator { get; }
        public QuizzerCommnadController(IResourceManagementService resourceManagementService, IMediator mediator)
        {
            this.resourceManagementService = resourceManagementService;
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> CreateQuestion([FromBody] CreateQuestionCommand createQuestionCommand)
        {

            var result = await _mediator.Send(createQuestionCommand);
            return HandleResult(result);
        }
    }
}
