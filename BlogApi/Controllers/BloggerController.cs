using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("blogger")]
    [ApiController]
    public class BloggerController : ControllerBase
    {
        [HttpGet]
        public string Get() 
        {
            return "Hello world";
        }

        [HttpGet("getAll")]
        public ResponseResult GetAll()
        {
            var message = new ResponseResult
            {
                Message = "Hello world"
            };

            return message;
        }

    }

    public class ResponseResult
    {
        public string Message { get; set; }
    }
}
