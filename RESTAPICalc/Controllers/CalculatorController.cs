using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTAPILibrary;

namespace RESTAPICalc.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public double Add([FromQuery] double num1, [FromQuery] double num2)
        {
            return Calculator.Addition(num1, num2);
        }
    }
}