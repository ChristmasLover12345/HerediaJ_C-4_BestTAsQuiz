using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerediaJ_C_4_BestTAsQuiz.Models;

namespace HerediaJ_C_4_BestTAsQuiz.Services
{
    public class SayHelloTwoService
    {
        
        public List<SayHelloTwoModel> friendNames = new();

        public List<SayHelloTwoModel> addFriend(string userName)
        {
            SayHelloTwoModel friend = new();
            friend.Hello = userName;
            friendNames.Add(friend);

            return friendNames;

        }


    }
}