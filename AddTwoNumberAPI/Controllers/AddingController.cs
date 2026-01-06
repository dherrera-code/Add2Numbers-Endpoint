using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AddTwoNumberAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddingController : ControllerBase
    {
        [HttpPost]
        [Route("AddTwoNumber")]
        public string AddNumbers(int number1, int number2)
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
            return $"The sum of {number1} and {number2} is {sum}.";
        }
    }
}