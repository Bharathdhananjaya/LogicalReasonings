using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            //ReverseString();
            //bool isUnique=IsStringContainsUniqueCharacters();
            RemoveDuplicateCharacters();
            Console.Read();

        }


        private static void ReverseString()
        {
            Console.WriteLine("Enter Input String");
            string value = Convert.ToString(Console.ReadLine());

            for(int i=value.Length-1;i>=0;i--)
            {
                Console.Write(value[i]); 
            }

        }

        private static void RemoveDuplicateCharacters()
        {
            //BHA R ATH
            Console.WriteLine("Enter Input String");
            string value = Convert.ToString(Console.ReadLine());
            string newValue = string.Empty;
            string table = "";
            foreach(char c in value)
            {
                if (newValue.IndexOf(c) == -1)
             {
                 // table += c;
                 newValue += c;
             }

            }
            Console.WriteLine("Right String=" + newValue);
        }



        private static bool IsStringContainsUniqueCharacters()
        {
            Console.WriteLine("Enter Input String");
            string value = Convert.ToString(Console.ReadLine());

            for(int i=0;i<value.Length;i++)
            {
                for(int j=i+1;j<value.Length;j++)
                {
                    if (value[i] == value[j])
                    {
                        Console.WriteLine("It is not Unique");
                        return false;
                    }
                }
            }

            Console.WriteLine("It is Unique");
            return true;
        }


    }
}
