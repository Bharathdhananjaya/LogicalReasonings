using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaozonInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrays = new int[] {3,5,6,7,8,2,4};
            int keyItem =SearchElemt(arrays, 0, arrays.Length, 5);
            SortElementsUsingLinearSort(arrays);

            int total = SumOfNaturalNumbers(5);

            SortNumbers(arrays);
            var sortedNumbers = new int[]{1,2,3,4,5,6,7,8,9};
          bool success=  DivideAndConqure(sortedNumbers, 5);

          Node node = new Node();
          node.data = 30;
          node.LefNode = new Node();
          node.LefNode.data = 50;

          node.RightNode = new Node();
          node.RightNode.data = 20;


          bool findTheNode = PrintBinarySearchTree(node, 20);

          List item = new List();
          item.data = 20;
          item.Next = new List();
          item.Next.data = 30;          
          item.Next.data = 40;
          int itemvalue = FindTheNthItemOfANode(item, 2);
          //DeleteAllTheNodesFromAList(item);
         // int totalCount = FindTheCountOfElementsInLinkedList(item);

          List nodeA = new List();
          nodeA.data = 10;
          nodeA.Next = new List();
          nodeA.Next.data = 20;


          List nodeB = new List();
          nodeB.data = 30;
          nodeB.Next = new List();
          nodeB.Next.data = 40;

          AppendLinkedLists(nodeA, nodeB);

            Console.Read();
        }


        public static int SumOfNaturalNumbers(int n)
        {
            //1,2,3,4,5

            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + SumOfNaturalNumbers(n - 1);
            }

        }


        public static  void SortElementsUsingLinearSort(int[] elements)
        {
            //1,2,3,18,9,4,5
            int temp;
            if(elements.Length >0)
            {
                for(int i=0; i< elements.Length;i++)
                {
                    for(int j=i+1;j< elements.Length; j++)
                    {
                        if(elements[i] > elements[j])
                        {
                            temp = elements[j];
                            elements[j] =elements[i];
                            elements[i] = temp;
                            
                        }
                      
                    }
                    Console.Write(elements[i] + " ");
                }

            }

        }



        public static void AppendLinkedLists(List nodeA, List nodeB)
        {

            if(nodeA == null)
            {
                nodeA = nodeB;
            }
            else
            {
                List temp = nodeA;
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = nodeB;
            }

            

        }



        public static void SortNumbers(int[] numbers)
        {
            //3,5,3,6,7,8,2,4
           
            int temp;
            for(int i=0;i<numbers.Length;i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
                Console.Write(numbers[i] + " ");
            }            
        }


        public static int FindTheNthItemOfANode(List myList, int index)
        {
            List temp = myList;
            int count = 0;
            while( temp != null )
            {
                if(index == count)
                {
                    return temp.data;
                }
                temp = temp.Next;
                count++;
            }
            return 0;
        }



        public static void DeleteAllTheNodesFromAList(List myList)
        {
            List temp1 = myList;
            List temp2 = null;

            while (temp1 !=null)
            {
                temp2 = temp1.Next;
                temp1 = null;
                temp1 = temp2;


            }




        }



        public static int FindTheCountOfElementsInLinkedList(List myList)
        {
            List temp = myList;
            int count = 0;

            while (temp != null)
            {
                
                if (temp != null)
                {                  
                        temp = temp.Next;
                        count++;
                    }
                }
             return count;
        }
           
        
        

        


        public static  int BinarySearchTree(Node node, int element)
        {
            if(node == null || node.data == element)
            {
    return element;
}
            if(node.data > element)
            {
                return BinarySearchTree(node.LefNode, element);
            }
            else
            {
                return BinarySearchTree(node.RightNode, element);
            }

        }




        public static bool PrintBinarySearchTree(Node node, int root)
        {
            if (node == null || root == null)
            { return true; }
            if (node.data < root)
            {
                Console.WriteLine(BinarySearchTree(node.LefNode, root) + "->");
                return true;
            }
            else
            {
                Console.Write( BinarySearchTree(node.RightNode, root) + "->");
                return true;
            }

        }




        public static bool DivideAndConqure(int[] numbers, int searchElement)
        {
            ////1,2,3,4,5,6,7,8,10
            int mid = numbers.Length / 2;
            int start = numbers[0];
            int end = numbers[numbers.Length-1];

            while(start< end)
            {
                mid = (start+end)/2;

                if(searchElement == numbers[mid])
                {
                    return true;
                }
                else if(searchElement > numbers[mid])
                {
                    start= numbers[mid+1];
                }
                else
                {
                    end = numbers[mid-1];
                }
            }


            return false;


            }

        public static int SearchElemt(int[] elements, int start, int end, int searchKey)
        {            

         
               int mid = (start + end) / 2;
               if(searchKey == mid)
               {
                   return mid;
               }
               else if( searchKey < mid)
               {                  
                   return SearchElemt(elements,start,mid-1,searchKey);
               }
               else
               {
                   return SearchElemt(elements, mid + 1, elements.Length, searchKey);
               }

         }
                
}

    class Node
    {
       public  int data {get;set;}
        public Node LefNode {get;set;}
        public Node RightNode {get;set;}
    }


    public class List
    {
        public int data { get; set; }
        public List Next{ get; set; }

    }




}





