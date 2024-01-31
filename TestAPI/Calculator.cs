using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class Calculator : ControllerBase
    {
        [HttpGet]
        public decimal Add(decimal number1, decimal number2)
        {  
           decimal sum = number1 + number2;
            return sum;
        }
    }
}
