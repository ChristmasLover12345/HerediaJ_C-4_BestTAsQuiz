using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerediaJ_C_4_BestTAsQuiz.Services
{
    public class ReverseItService
    {
        public class ReverseItAlphaService
    {
         public string ReverseAlpha(string word)
        {

            if (word.Trim() == "")
            {
                return "Type something dude";
            }
            else
            {
             char[] charArray = word.ToCharArray();
             Array.Reverse(charArray);
             string reversedWrod = new string(charArray);
             return $"You entered {word}, The reversed is {reversedWrod}";
            }
        }
        
    }
    }
}