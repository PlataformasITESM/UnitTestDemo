using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        [HttpGet(Name = "GetSum")]
        public int suma(int a ,int b)
        {
            return a+b;
        }
    }
}
