﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTAPILibrary;
using Microsoft.AspNetCore.Mvc;

namespace RESTAPICalc.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorSubtractController : ControllerBase
    {

      [HttpGet]
        public double Subtract([FromQuery] double num1, [FromQuery] double num2)
        {
            return Calculator.Subtraction(num1, num2);
        }
    }
}
