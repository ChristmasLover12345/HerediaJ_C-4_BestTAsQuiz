using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerediaJ_C_4_BestTAsQuiz.Services;
using Microsoft.AspNetCore.Mvc;

namespace HerediaJ_C_4_BestTAsQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {
        
        private readonly AddTwoNumbersService _addTwoNumbersService;

        public AddTwoNumbersController(AddTwoNumbersService addTwoNumbersService)
        {
            _addTwoNumbersService = addTwoNumbersService;
        }

        [HttpGet]
        [Route("Calculator/{num1}/{num2}")]
        public string Add2Num(string num1, string num2)
        {
           return _addTwoNumbersService.Add2Num(num1, num2);
        }

    }
}