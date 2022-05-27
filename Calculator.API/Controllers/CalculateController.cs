using Calculator.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.API.Controllers
{
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private readonly ILogger<CalculateController> _logger;

        public CalculateController(ILogger<CalculateController> logger)
        {
            _logger = logger;
        }

        [HttpGet("add")]
        public IActionResult Add([FromQuery] int[] inputs)
        {
            return Ok(CalculatorLib.Add(inputs));
        }

        [HttpGet("substract")]
        public IActionResult Substract([FromQuery] int[] inputs)
        {
            return Ok(CalculatorLib.Substract(inputs));
        }

        [HttpGet("multiply")]
        public IActionResult Multiply([FromQuery] int[] inputs)
        {
            return Ok(CalculatorLib.Multiply(inputs));
        }

        [HttpGet("divide")]
        public IActionResult Divide([FromQuery] double[] inputs)
        {
            return Ok(CalculatorLib.Divide(inputs));
        }

        [HttpGet("splitEq")]
        public IActionResult SplitEq([FromQuery] int[] inputs)
        {
            return Ok(CalculatorLib.SplitEq(inputs[0], inputs[1]));
        }

        [HttpGet("splitNum")]
        public IActionResult SplitNum([FromQuery] int[] inputs)
        {
            return Ok(1);
        }
    }
}
