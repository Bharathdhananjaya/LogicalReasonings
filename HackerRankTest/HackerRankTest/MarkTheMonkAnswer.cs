using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTest
{
    public class MarkTheMonkAnswer
    {
        public static void MonksTheProblemSolvingLimit()
        {
            var questionAndomplexity = Console.ReadLine();
            var getAnyArray = questionAndomplexity.Split(' ');
            var question = Convert.ToInt32(getAnyArray[0]);
            var complexity = Convert.ToInt32(getAnyArray[1]);

            var questionAnwers = Console.ReadLine();
            var questionAnsArrays = questionAnwers.Split(' ');
            int count = 0;
            int loopCounter = 0;
            
            for(int i=0; i< questionAnsArrays.Length; i++)
            {
                if (count <= 1)
                {

                    if (complexity < Convert.ToInt32(questionAnsArrays[i]))
                    {
                        count++;
                    }
                    else
                    {
                        loopCounter++;
                    }
                }
                else
                {
                    break;
                }
                
            }

            Console.WriteLine(loopCounter);


        }

    }
}
