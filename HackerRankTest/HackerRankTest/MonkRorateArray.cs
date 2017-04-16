using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTest
{
    public class MonkRorateArray
    {
        public static void RorateArray()
        {
            //1
            //5 2
            // 1 2 3 4 5 
            // 4 5 1 2 3 
            var input = Convert.ToInt32(Console.ReadLine());
            List<string> myItems = new List<string>();
            
            for(int i=0; i< input; i++)
            {
                var nAndK = Console.ReadLine();
                var arrayItems = Console.ReadLine();
                int count =Convert.ToInt32(nAndK.Split(' ')[0]);
                int index = count - Convert.ToInt32(nAndK.Split(' ')[1]);
                int newIterator = 0;
                for(int j=0; j< count; j++)
                {
                    
                    if ((j + index) < count)
                    {
                        //Console.Write(arrayItems.Split(' ')[j+index]);
                        myItems.Add(arrayItems.Split(' ')[j + index]);
                          
                    }
                    else
                    {
                        //Console.Write(arrayItems.Split(' ')[newIterator]);
                        myItems.Add(arrayItems.Split(' ')[newIterator]);
                        newIterator++;
                    }
                   // Console.Write(" ");
                    myItems.Add(" ");
                }
                Console.WriteLine();
            }

            foreach(var item in myItems)
            {
                Console.Write(item);
            }



        }

    }
}
