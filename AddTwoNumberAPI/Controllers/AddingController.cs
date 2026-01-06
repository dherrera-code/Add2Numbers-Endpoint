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
        public string AddNumbers(int firstNum, int secondNum)
        {
            return $"The sum of {firstNum} and {secondNum} is {firstNum + secondNum}.";
        }
    }
}