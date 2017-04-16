using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTest
{
   public  class MicroArrayUpdate
    {

       public static void FindTheMiroUpdateRequired()
       {
           var numberOfTestCases = Convert.ToInt32(Console.ReadLine());
           List<string[,]> elementsToProcess = new List<string[,]>();
           string[,] arrayElemts = new string[2, 2];

           List<int> result = new List<int>();
           for (int i = 0; i < numberOfTestCases; i++)
           {
               
               arrayElemts[i,0] = Console.ReadLine();
               arrayElemts[i,1] = Console.ReadLine();

               int n = Convert.ToInt32(arrayElemts[i, 0].Split(' ')[0]);
               int k = Convert.ToInt32(arrayElemts[i, 0].Split(' ')[1]);

               var items = arrayElemts[i, 1].Split(' ');
               int counter = 0;
               List<int> findTheSmallestNumberTOK = new List<int>();
               

               for (int j = 0; j < n;j ++ )
               {
                   if(Convert.ToInt32(items[j]) <k)
                       findTheSmallestNumberTOK.Add(Convert.ToInt32(items[j]));
               }
               if (findTheSmallestNumberTOK.Count > 0)
               {
                   var smallestNumber = findTheSmallestNumberTOK.OrderBy(a => a).First();

                   int difference = k - smallestNumber;
                   result.Add(difference);

               }
               else
               {
                   result.Add(0);
               }
                   

           }

          foreach(var item in result)
          {
              Console.WriteLine( item   );
          }
           

          

       }
    }
}
