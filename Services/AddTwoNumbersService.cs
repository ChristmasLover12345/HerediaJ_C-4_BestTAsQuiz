using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerediaJ_C_4_BestTAsQuiz.Services
{
    public class AddTwoNumbersService
    {
        

        public string Add2Num(string num1, string num2)
        {
            bool validation1 = int.TryParse(num1,out int number1);
            bool validation2 = int.TryParse(num2,out int number2);

            if (validation1 == true && validation2 == true)
            {
                return $"The sum of {number1} and {number2} is {number1 + number2}";
            }
            else
            {
                return "numbers only";
            }
        }

    }
}