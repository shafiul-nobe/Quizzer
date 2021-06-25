using Domain;
using Infrastructure.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Quizzer.Queries.Models;
using Quizzer.Queries.Models.Question;
using Quizzer.Queries.Queries.Question;
using Quizzer.Queries.Queries.Subject;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class QuizzerQueryController : BaseApiController
    {
      public IMediator _mediator { get; }
        public QuizzerQueryController(IRepository repository, IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost("GetQuestionById")]
        public async Task<IActionResult> GetQuestionById([FromBody] QuestionByIdQuery query)
        {
            var question = await _mediator.Send(query);
            return HandleResult(question);
        }

        [HttpPost("GetQuestionsByClass")]
        public async Task<IActionResult> GetQuestionsByClass([FromBody] QuestionsByClassQuery query)
        {
            var questions = await _mediator.Send(query);
            return HandleResult(questions);
        }

        [HttpPost("GetSubjectsByClass")]
        public async Task<IActionResult> GetSubjectsByClass([FromBody] SubjectsByClassQuery query)
        {
            var questions = await _mediator.Send(query);
            return HandleResult(questions);
        }

        [HttpPost("GetSubjectsByChapter")]
        public async Task<IActionResult> GetSubjectsByChapter([FromBody] QuestionsByChapterQuery query)
        {
            var questions = await _mediator.Send(query);
            return HandleResult(questions);
        }
    }
}
