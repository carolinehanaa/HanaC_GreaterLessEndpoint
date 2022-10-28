/*Caroline Hana
10-25-2022
Greater or Less then the console will display greeater less or equal.
Peer Review - Isaiah Keith Ferguson - Program works as intended with no errors. good job!
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HanaC_GreaterLessEndpoint.Controllers
{
    [Route("[controller]")]
    public class GreaterLess : Controller
    {
        [HttpGet]
        [Route("math/{number1}/{number2}")]

        public string greatOrLess(int number1, int number2, string Output)
        {
    
            if(number1 > number2)
            {
               Output = $"{number1} > {number2}"; 
            }else if(number1 < number2)
            {
                Output = $"{number1} < {number2}";
            }else
            {
                Output = $"{number1} = {number2}";
            }

            return Output;
        }
    }
}