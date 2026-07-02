using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstRestAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/MyFirstAPI")]
    [ApiController]
    public class MyFirstAPIController : ControllerBase
    {
        [HttpGet("MyName",Name = "MyName")]//tll server to get the data from the server
        public string GetMyName()
        {
            return "My name is John Doe";
        }

        [HttpGet("YourName",Name = "YourName")]//tll server to get the data from the server
        public string GetYourName()
        {
            return "Your name is John Doe";
        }

        [HttpGet("sum/{Num1}/{Num2}")]
        public int GetSum2Numbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        [HttpGet("multi/{Num1}/{Num2}")]
        public int GetMulti2Numbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
}
