using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Figures
{
    public class GamingClass
    {
        public static int GamingMethod(int rndNo)
        {
            int userAnswer;

            do
                Information.TheNumber();
            while (!int.TryParse(Console.ReadLine(), out userAnswer));

            if (userAnswer == rndNo)
            {
                Information.CorrectAnswer();
            }
            else
                Information.WrongAnswer(rndNo);
            return rndNo;
        }
    }
}
