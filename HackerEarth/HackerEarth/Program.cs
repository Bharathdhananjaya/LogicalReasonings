

using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HackerEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAllZeroCheck();
            //PrintTheOccurenceOfNumbers();
            GetTheASCIICharacterOfAString();
            //MagicalNumber();
            //IsStringPalindrome();
            //FaceBookPhotoAdjustment();
            //var number = Console.ReadLine();
            //var result = Factorial(Convert.ToInt32(number));
            NumberTermination();
            Console.Read();
        }

        private static void ReveseArray()
        {
            var numberOfItems = Console.ReadLine();
            int totalCount = Convert.ToInt32(numberOfItems);
            int[] items = new int[totalCount];
            for(int i=0; i< totalCount; i++)
            {
                items[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for(int i=items.Length-1; i>=0;i --)
            {
                Console.WriteLine(items[i]);

            }

        }
        
        private static void PrintAllZeroCheck()
        {
            var input = Convert.ToInt32(Console.ReadLine());
            var inputString = Console.ReadLine();
            //2 2
            if(input <= 10000)
            {
                bool isCorrect = false;
                if(!string.IsNullOrEmpty(inputString))
                {
                   var splitString = inputString.Split(' ');

                    if(splitString.Length ==1 && splitString[0] == "0")
                    {
                        isCorrect = true;
                    }

                    for(int i=0;i<input-1;i++)
                    {
                        if(splitString[i] == splitString[i+1])
                        {
                            isCorrect = true;
                        }
                        else
                        {
                            isCorrect = false;
                        }
                    }

                    if(isCorrect)
                    {
                        Console.Write("YES");
                    }
                    else
                    {
                        Console.Write("NO");
                    }
                }
                

            }


        }





        private static void GetTheASCIICharacterOfAString()
        {
            var value = Console.ReadLine();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(value);
            List<int> asciiNumbers = new List<int>();
            for(int i=0 ;i< asciiBytes.Length;i++)
            {
                asciiNumbers.Add(asciiBytes[i]);
            }

        }

        private static void PrintTheOccurenceOfNumbers()
        {
            //77150
            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                var charArray = input.Select(c => Int16.Parse(c.ToString())).ToArray();
                Dictionary<int, int> mapCharacters = new Dictionary<int, int>();
                int index = 0;

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < charArray.Length; j++)
                    {
                        if (Convert.ToInt16((charArray[j])) == i)
                        {
                            if (mapCharacters.ContainsKey(i))
                            {
                                mapCharacters[i] = mapCharacters[i]+1;
                            }
                            else
                            {
                                mapCharacters.Add(i, 1);
                            }
                        }

                    }
                }

                for (int i = 0; i <  10;i++ )
                {
                    if(mapCharacters.ContainsKey(i))
                    {
                        Console.WriteLine(i + "  " + mapCharacters[i]);
                    }
                    else
                    {
                        Console.WriteLine(i + " " + 0);
                    }
                }


            }

        }

        private static void MagicalNumber()
        {
            
            var enterTheNumber = Convert.ToUInt64(Console.ReadLine());
            var NumberList = Console.ReadLine();
            var splitNumbers = NumberList.Split(' ');
            
            ulong answer = Convert.ToUInt64(splitNumbers[0]);

            for (ulong i = 0; i < enterTheNumber; i++)
            {
                answer = Convert.ToUInt64((answer * Convert.ToUInt64(splitNumbers[i])) % (Math.Pow(10, 9) + 7));

            }
            Console.WriteLine(answer);


        }


        private static void NumberTermination()
        {
            List<int> number = new List<int>();
            while (true)
            {
                
                var enterNumber = Convert.ToInt32(Console.ReadLine());

              
                    if (enterNumber == 42)
                    {
                        number.Add(enterNumber);
                    }
                    else
                    {
                        var numebrs = number.Select(i => i).OrderBy(i => i);
                        foreach (var num in numebrs)
                        {
                            Console.WriteLine(num);
                        }
                        break;
                  
                }
            }            
        }


        private static void FaceBookPhotoAdjustment()
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int numberOfPhotos = Convert.ToInt32(Console.ReadLine());
             List<string> photoSize = new List<string>();
            for (int i = 0; i < numberOfPhotos; i++)
            {
                photoSize.Add(Console.ReadLine());
            }
             
                foreach(var item in photoSize)
                {
                    int width = Convert.ToInt32(item.Split(' ')[0]);
                    int height = Convert.ToInt32(item.Split(' ')[1]);


                    if (width >= length && height >= length)
                    {
                        if (width == height)
                        {
                        Console.WriteLine("ACCEPTED");
                        }
                        else
                        {
                            Console.WriteLine("CROP IT");
                        }
                    }
                     if(width< length || height< length )
                    {
                          Console.WriteLine("UPLOAD ANOTHER");
                     }

                }
        }
        


        private static int Factorial(int N)
        {
            if (N == 0)
            {
                return 1;
            }
            return N * Factorial(N - 1);
        }

        private static void ReverseAString(string[] items)
        {           

            for(int i=items.Length-1; i > 0;i--)
            {
                Console.WriteLine(Convert.ToInt32(items[i]));

            }
        }


        private static void IsStringPalindrome()
        {
            Console.WriteLine("Enter a String");
            var word = Console.ReadLine();
            if(!string.IsNullOrEmpty(word))
            {
                string reverse = new string(word.Reverse().ToArray());

                if(word == reverse)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

        }
       

    }
}
