﻿using Domain;
using Infrastructure.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Quizzer.Queries.Models;
using Quizzer.Queries.Models.Question;
using Quizzer.Queries.Queries.Question;
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

        [HttpPost]
        public async Task<IActionResult> GetQuestionById([FromBody] QuestionByIdQuery questionByIdQuery)
        {
            var question = await _mediator.Send(questionByIdQuery);
            return HandleResult(question);
        }

        [HttpPost]
        public async Task<IActionResult> GetQuestionsByClass([FromBody] QuestionsByClassQuery questionByClassQuery)
        {
            var questions = await _mediator.Send(questionByClassQuery);
            return HandleResult(questions);
        }
    }
}
