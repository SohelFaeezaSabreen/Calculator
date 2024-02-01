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

        [HttpGet]
        public decimal Subtract(decimal number1=10, decimal number2=10)
        {  
           decimal difference = number1 - number2;
            return difference;
        }

        [HttpGet]
        public decimal Multiply(decimal number1, decimal number2)
        {  
           decimal product = number1 * number2;
            return product;
        }

        [HttpGet]
        public decimal Divide(decimal number1, decimal number2)
        {  
           decimal quotient = number1 / number2;
            return quotient;
        }

        [HttpGet]
        public decimal Modulo(decimal number1, decimal number2)
        {  
           decimal remainder = number1 % number2;
            return remainder;
        }
    }
}
