using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTest
{
   public static class MaxOccurence
    {

       public static void FindTheMaxOccurance()
       {
           int value = Convert.ToInt32(Console.ReadLine());
           var values = Console.ReadLine();

           string[] arrayOfItems = values.Split(' ');

           Dictionary<string, int> items = new Dictionary<string, int>();
           int count=1;
           for (int i = 0; i < arrayOfItems.Length; i++)
           {
               if (items.TryGetValue(arrayOfItems[i], out count))
              {
                  items[arrayOfItems[i]]++;
              }
              else
              {
                  items.Add(arrayOfItems[i], 1);
              }

           }

           var maxValue = items.Select(i => i).OrderByDescending(i => i.Value).First();
           Console.WriteLine(maxValue.Key);

       }


    }
}
