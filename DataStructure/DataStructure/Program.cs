using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
using System.Globalization;

namespace DataStructure
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PrintEvenAndOdd();
            Console.ReadLine();

            CalCulateTheHotelCharge();
            Console.ReadLine();
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            int newNumber = Convert.ToInt32(Console.ReadLine());
            double newDoub = Convert.ToDouble(Console.ReadLine());
            string s1 = Console.ReadLine();


            Console.WriteLine(i + newNumber);
            Console.WriteLine((d + newDoub).ToString("0.0"));
            Console.WriteLine(string.Concat(s , s1));


            StairCase(30);
            Console.Read();

            string number = Console.ReadLine();
            //string[] numbers = number.Split(' ');
            //int l = Convert.ToInt32(numbers[0]);
            //int r = Convert.ToInt32(numbers[1]);
            //int k = Convert.ToInt32(numbers[2]);

            //int count=0;
            //for(int i=l; i<= r;i++)
            //{
            //    if (i % k == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count); 
            string input = Console.ReadLine();

            string newString=string.Empty;
            foreach(var item in input.ToArray())
            {
                if (item.ToString().Any(Char.IsLower))
                    newString += string.Concat(item.ToString().ToUpper());
                else
                    newString += string.Concat(item.ToString().ToLower());
               
            }
            Console.WriteLine("Connverted string " + newString);














            int total = SumOfNos(2, 5);


            int sumOfNumbers = SumOfNaturalNumbers(5);


  

            //int[] items = {1,2,3,4,5,6,7,8,9};
            //ReverseArray(items, 0, items.Length-1);

            //for(int i=0 ;i < items.Length ;i++)
            //{
            //    Console.WriteLine(i); 
            //}
            //ReverseAnArray(items);

            //int[] arrays = { 23, 45,190, 56, 45454, 4 };
            //FindTheKLargestElements(arrays, 3);
            //FindTheSumOfTargetNumber(arrays, 5);

            Node node = new Node();
        //    node.data=10;
        //    node.leftNode = new Node();
        //    node.leftNode.data = 30;
        //    node.rightNode = new Node();
        //    node.rightNode.data = 3;

        //    new Program().SearchANode(node, 3);



            //LinkedList.LinkedList list = new LinkedList.LinkedList();
            //list.AddFirstItem(10);
            //list.PrintAllTheNodesPresentInList();
            //int sum = new Program().Sum(5);
            //Console.WriteLine("Total Sum is = " + sum); 
            Console.Read();
        }



        public static void PrintEvenAndOdd()
        {
            var number = Convert.ToInt32(Console.ReadLine());


          if(number%2 !=0)
          {
              Console.WriteLine("Wiered");
          }
          else if( number > 2 && number <5 )
          {
              Console.WriteLine("Not Wiered");
          }
          else if( number >6 && number <20)
          {
              Console.WriteLine("Wiered");
          }
          else if( number  >20)
          {
              Console.WriteLine("Not Wiered");
          }

          




        }


        public static void CalCulateTheHotelCharge()
        {
            var mealCost = Console.ReadLine();
            var tipPercent = Convert.ToInt32(Console.ReadLine());
            var taxPercent = Convert.ToInt32(Console.ReadLine());

            
            var result = double.Parse(mealCost, CultureInfo.InvariantCulture);
;
            var TotalCost = result + (result * tipPercent / 100) + (result * taxPercent / 100);

            Console.WriteLine("The total meal cost is totalCost " + Math.Round(TotalCost) + " dollars");


        }

        public static void StairCase(int n)
        {

            for(int i=1; i<=n; i++)
            {
                for(int j=i;j<=n;j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i;k++ )
                {
                    Console.Write("#");
                }
                    Console.WriteLine();

                }
            }




        public static int SumOfNaturalNumbers(int n)
        {
            if(n==1)
            {
                return n;
            }
              var sum =  n+ SumOfNaturalNumbers(n - 1);
            return sum;

        }

        public static int SumOfNos(int a, int b)
        {
            if(a>b)
            {
                return 0;
            }
            else
            {
                int sum = a + SumOfNos(a + 1, b);

                //2+5 = 7
                //3+5 =8
                //4+5 =9
                //5+5=10
                //6+5 =11

                //2 +sum(3,5) = 




                return sum;
            }
        }





        public static IEnumerable<string> GetCombinations(int[] set, int sum, string values)
        {
            for (int i = 0; i < set.Length; i++)
            {
                int left = sum - set[i];
                string vals = set[i] + "," + values;
                if (left == 0)
                {
                    yield return vals;
                }
                else
                {
                    int[] possible = set.Take(i).Where(n => n <= sum).ToArray();
                    if (possible.Length > 0)
                    {
                        foreach (string s in GetCombinations(possible, left, vals))
                        {
                            yield return s;
                        }
                    }
                }
            }
        }


        private static void PrintTheSumOfNumbersInAnArray(int[] elements, int k)
        {
            //1,2,3,4,5,6,7,8,9,10
           
            string[] temp = new string[10];
            for (int i = 0; i < elements.Length; i++)
            {
                int sum = 0;
                sum = elements[i];
                string items = elements[i].ToString() + ",";
                for (int j = i; j < elements.Length; j++)
                {
                    int index = 0;

                    if (elements[i] == k || elements[j] == k)
                    {
                        items = sum.ToString();
                    }

                    else if (!i.Equals(j) && sum < k)
                    {
                        sum += elements[j];
                        items += elements[j] + ",";
                    }

                    if (sum == k)
                    {
                        temp[index] = items;
                        sum = 0;
                        index++;
                    }
                    if (sum > k)
                    {
                        sum = 0;
                        items = null;
                        continue;
                    }
                }
            }
        
        foreach(var item in temp)
        {
            Console.WriteLine(item);
        }
        Console.Read();
        }
         private static void PrintTriagnle(int length)
        {

            for(int i=1; i<= length; i++)
            {
               
                for (int j = 1; j <= i; j++)
                {
                    for (int k = length; k >i;k-- )
                    {
                        Console.Write(" ");
                    }
                        Console.Write("*" + " ");
                    
                }
                Console.WriteLine();
            }
            Console.Read();
        }


        private static string FindThePositionOfAnElement(int position, int length)
        {
            int currentPosition = (Math.Abs(length / position) - 1);
            string space = " ";
            for (int i = 0; i < currentPosition; i++ )
            {
                space += space;
            }

            return space;
        }

        //    *
        //  *  *
        //*  *   *

        private static void ReverseArray(int[] array, int start, int end)
        {
            int temp;
            if (start >= end)
            {
                return;
            }
            temp = array[start];
            array[start] = array[end];
            array[end] = temp;
            ReverseArray(array, start + 1, end - 1);

        }



        private static void ReverseAnArray(int[] items)
        {
            int index=0;
            for(int i=items.Length; i>0; i--)
            {
                Console.Write(i + " ");
            }

        }

        private static void FindTheKLargestElements(int[] list, int k)       
        {
            var sortItemsInDec = list.OrderByDescending(i => i).ToArray();
            for(int i=0; i<sortItemsInDec.Count();i++)
            {
                if (i <= k)
                {
                    Console.WriteLine("Large {0} : {1}", i , sortItemsInDec[i]);
                }
            }

            int[] largeArray = new int[3];

            for(int i=0;i<list.Count(); i++)
            {
                largeArray[i] = list[i];
            }


        }


        private static void FindTheSumOfTargetNumber(int[] myArray, int targetNumber)
        {

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[i] == targetNumber)
                    {
                        Console.WriteLine(myArray[i]);
                    }

                    else if( i != j &&  myArray[i]+ myArray[j] == targetNumber)
                    {
                        Console.WriteLine(" {0},{1}", myArray[i], myArray[j]);

                    }
                }
            }
        }


        public void SearchANode(Node root, int key)
        {
            if(root == null || root.data == key)
            {
                Console.WriteLine("Node is root " + root.data);
            }
            else if(key > root.data)
            {
                SearchANode(root.rightNode, key);
            }
            else
            {
                SearchANode(root.leftNode, key);
            }

        }












        public int Sum(int n)
        {
            if(n ==1 )
            {
                return 1;
            }
            else
            {
                int a= Sum(n-1) + n;
                return a;
            }
        }

    }

    public class Base
    {
        public int data1;
        public int data2;
        protected int data4;

        private int data3;

        public Base()
        {

        }


    }

    public class Child : Base
    {
        public int child1;
        public int child2;


        private void MyMethod()
        {
            var my = new Base();



            Console.WriteLine();
        }


    }


    public class Node
    {
       public int data;
        public Node rightNode;
        public Node leftNode;
    }


}
