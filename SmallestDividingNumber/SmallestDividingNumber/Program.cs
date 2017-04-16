using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {

            LargestNumbers();

            bool check = IsAPalindrome("MALAYALA");

            var inputString = Console.ReadLine();
            int result = LongestParanthesis(inputString);



            var inputNumber = Console.ReadLine();
            var i = Convert.ToInt32(Console.ReadLine());
            var j = Convert.ToInt32(Console.ReadLine());

            var convertToIntArray = inputNumber.Split(',');
            var result1 = ModifyTheArray(convertToIntArray, i, j);

            for (int value = 0; value < result1.Length;value++ )
            {
                Console.Write(result1[value] + " ");
            }

                Console.Read();         
    
             
        }


         public static bool IsAPalindrome(string word)
        {
                string newString=string.Empty;
                for (int i = word.Length-1; i >= 0; i-- )
                {
                    newString += word[i];

                }

                 if(word == newString)
                 {
                     return true;
                 }
                    return false;
     
        }
    

        private static string[] ModifyTheArray(string[] commaSeparatedIntegeres, int i, int j)
        {
            int index = 0;
            string[] newArray = new string[commaSeparatedIntegeres.Length];
            int newArrayIndex = 0;
            int modIndex = 0;
            while (index < commaSeparatedIntegeres.Length)
            {
                if (modIndex != 0 && modIndex % i == 0)
                {
                    index += j;
                    modIndex = -1;
                }
                else
                {
                    newArray[newArrayIndex] = commaSeparatedIntegeres[index];
                    newArrayIndex++;
                    index++;
                }
                modIndex++;

            }
            return newArray;

        }
          
        private static int LongestParanthesis(string s)
        {
            var res = 0;
            var stack = new Stack();
            for(int i=0; i< s.Length; i++)
            {
                if(s[i] == '(')
                {
                    stack.Push(s[i]);
                }

                else
                {
                    if(stack.Count > 0  && s[Convert.ToInt32(stack.Peek())-1] == '(')
                    {
                        stack.Pop();
                        res = Math.Max(res, i - (stack.Count > 0 ? Convert.ToInt32(stack.Peek()) : -1));

                    }
                    else
                    {
                        stack.Push(i);
                    }

                }
            }
            return res;
        }



          


        private static int GetContinueValidParenthese(string str, int end)
        {
            var res = 0;
            var temp = 0;
            var rightParenthese = 0;
            for (int i = end; i >= 0; i--)
            {
                if (str[i] == '(')
                {
                    if (rightParenthese == 0)
                    {
                        return res;
                    }

                    temp += 2;
                    rightParenthese--;

                    if (rightParenthese == 0)
                    {
                        res = temp;
                    }

                }
                else
                {
                    rightParenthese++;
                }
            }

            return res;
        }



        private static string ModifyTheArrayUntilItExit(string[] commaSeparatedIntegeres, int i, int j)
        {
            //1,2,3,4,5,6,10,8
            //3
            //1
            string retainString = string.Empty;

            int item = 0;
            int newItem = 0;
            while (item < commaSeparatedIntegeres.Length)
            {
                if (item != 0 && newItem % i == 0)
                {
                    item = item + j - 1;
                   
                }
                else
                {
                    retainString += commaSeparatedIntegeres[item].ToString() + " ,";
                    newItem++;

                }
                item++;
            }
            return retainString;

        }



        private static void LargestNumbers()
        {
            //242358001399388784 9
            var number1 = Console.ReadLine();
           
            var inputData = number1.Split(' ');

            var numberList = inputData[0].ToArray();

            int index=0;
            int totalCount = Convert.ToInt32(inputData[1]);

            while (index < totalCount)
            {
                if (numberList[index] != '9')
                {
                    numberList[index] = '9';
                    index++;
                }
            }

          for(int i=0; i< numberList.Length; i++)
          {
                Console.Write(numberList[i]);
          }
            


        }


    }



 


}
