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
    public class ReverseItController : ControllerBase
    {
        
        private readonly ReverseItService _reverseItService;
        public ReverseItController(ReverseItService reverseItService)
        {
            _reverseItService = reverseItService;
        }

        [HttpGet]
        [Route("Reverse/{word}")]
        public string RevereseIt(string word)
        {
            return _reverseItService.ReverseWord(word);
        }

    }
}