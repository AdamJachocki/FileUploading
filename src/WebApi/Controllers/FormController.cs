using Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostHandler([FromForm]WebApiFormData data)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            
            return Ok();
        }
    }
}
