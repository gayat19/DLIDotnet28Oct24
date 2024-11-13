using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstController : ControllerBase
    {
        [HttpGet]
        public ActionResult Gayathri()
        {
            return Ok("hello from Gayathri Mahadevan");
        }
        [HttpGet]
        [Route("AnotherGet")]
        public ActionResult G3()
        {
            return BadRequest();
        }


        [HttpPost]
        public ActionResult Mahadevan()
        {
            return NotFound();
        }
    }
}
