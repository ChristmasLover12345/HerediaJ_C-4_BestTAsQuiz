using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerediaJ_C_4_BestTAsQuiz.Models;
using HerediaJ_C_4_BestTAsQuiz.Services;
using Microsoft.AspNetCore.Mvc;

namespace HerediaJ_C_4_BestTAsQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloTwoController : ControllerBase
    {
        
        private readonly SayHelloTwoService _sayHelloTwoService;
        public SayHelloTwoController(SayHelloTwoService sayHelloTwoService)
        {
            _sayHelloTwoService = sayHelloTwoService;
        }

        [HttpPost]
        [Route("HelloTwo/{userName}")]
        public List<SayHelloTwoModel> addFriend(string userName)
        {
            return _sayHelloTwoService.addFriend(userName);
        }
    }
}