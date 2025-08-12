using Microsoft.AspNetCore.Mvc;
using ReverseTextApi.Models;

namespace ReverseTextApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReverseController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] ReverseRequest request)
        {
            if (string.IsNullOrWhiteSpace(request?.Text))
            {
                return BadRequest(new { error = "Text cannot be empty." });
            }

            var reversed = new string(request.Text.Reverse().ToArray());

            var response = new ReverseResponse { ReversedText = reversed };

            return Ok(response);
        }
    }
}
