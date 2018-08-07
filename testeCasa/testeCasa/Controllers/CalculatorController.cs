using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace testeCasa.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
       
        // GET api/values/5/5
        [HttpGet("{firstNumber}/{secondNumber}")]
        public IActionResult  Sum(string firstNumber, string secondNumber)
        {
            if (isnumeric(firstNumber) && isnumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            
                return BadRequest("Invalid Input");
        }

        private Decimal ConvertToDecimal(string firstNumber)
        {
            throw new NotImplementedException();
        }

        private bool isnumeric(string secondNumber)
        {
            throw new NotImplementedException();
        }

        private bool 
    }
}
