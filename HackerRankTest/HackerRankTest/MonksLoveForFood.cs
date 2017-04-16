using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTest
{
    public class MonksLoveForFood
    {
        public static void FoodStatus()
        {
            var noOfQueues = Convert.ToInt32(Console.ReadLine());

            List<int> queryOne = new List<int>();
            List<string> queryTwo = new List<string>();

            Stack<int> myQueueTwo = new Stack<int>();
            
            

            for(int i=0; i< noOfQueues; i++)
            {
                var input = Console.ReadLine();
                var splitArray = input.Split(' ');

                if (splitArray[0] == "1")
                {                    
                    if(myQueueTwo.Count >0)
                    {
                       int item = myQueueTwo.Pop();
                       queryTwo.Add(item.ToString());
                    }
                    else
                    {
                        queryTwo.Add("No Food");
                    }
                }
                if(splitArray[0] == "2" && splitArray.Count() >1)
                {
                    myQueueTwo.Push(Convert.ToInt32(splitArray[1]));
                }
            }   

            foreach(var item in queryTwo)
            {
                Console.WriteLine(item);
            }

           


        }

    }
}
