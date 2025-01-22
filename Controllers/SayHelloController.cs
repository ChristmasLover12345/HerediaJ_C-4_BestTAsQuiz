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
    public class SayHelloController : ControllerBase
    {

        private readonly SayHelloService _sayHelloService;
        public SayHelloController(SayHelloService sayHelloService)
        {
            _sayHelloService = sayHelloService;
        }


        [HttpGet]
        [Route("hello/{word}")]
        public string hello(string word)
        {
            return _sayHelloService.hello(word);
        }

    }
}