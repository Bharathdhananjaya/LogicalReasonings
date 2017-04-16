using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTest
{
   public class MultiDimentionalArray
    {
       public static void Print()
       {
           int n = Convert.ToInt32(Console.ReadLine());
           int m = Convert.ToInt32(Console.ReadLine());
           int[,] multiArray = new int[n,m];

           int count = 0;
           for (int i = 0; i < n; i++)
           {
               for (int j = 0; j < m; j++)
               {
                   multiArray[i, j] = count ;
                   //Console.Write("1");
                   //Console.Write(" ");
               }
               count++;

               //Console.WriteLine();
           }



           for(int i=0; i< n;i++)
           {
               for(int j=0; j< m;j++)
               {
                   Console.Write(multiArray[i,j]);
                   Console.Write(" ");
               }
               Console.WriteLine();
           }

       }


    }
}
