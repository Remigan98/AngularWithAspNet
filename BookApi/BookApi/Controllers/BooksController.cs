using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        [Route("hello")]
        public ActionResult<string> Get() 
        {
            return "Hello from BooksController!";
        }
    }
}
