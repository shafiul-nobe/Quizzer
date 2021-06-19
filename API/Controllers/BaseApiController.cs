using Domain.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Quizzer.Queries.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
       
        protected ActionResult HandleResult<T>(QueryResponse<T> result)
        {
            if (result == null) return NotFound();
            if (result.IsSuccess && result.Data != null)
                return Ok(result);
            if (result.IsSuccess && result.Data == null)
                return NotFound();
            return BadRequest(result.ErrorMessage);
        }

        public ActionResult HandleResult<T>(CommandResponse<T> result)
        {
            if (result == null) return NotFound();
            if (result.IsSuccess && result.Data != null)
                return Ok(result);
            if (result.IsSuccess && result.Data == null)
                return NotFound();
            return BadRequest(result.ErrorMessage);
        }

    }
}
