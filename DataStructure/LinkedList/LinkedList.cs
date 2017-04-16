using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        private Node head;
        public void PrintAllTheNodesPresentInList()
        {
            
            Node cur = head;
            int index = 0;

            while(cur !=null)
            {               
                Console.WriteLine("Node {0}->{1}", index,cur.data );
                cur = cur.next;
            }

        }


        public void AddFirstItem(object data)
        {
            Node node = new Node();
            node.data = data;
            node.next = head;
            head = node;
        }

        public void LastItem(object data)
        {

            if(head == null)
            {
                head.data = data;
                head.next = head;

            }
            else
            {
                Node node = new Node();
                Node current = head;

                while (current.next != null)
                {
                    node.data = data;
                    node.next = null;
                    head.next = node;
                }
            }

            
        }



    }


    public class Node
    {
        public object data;
        public Node next;

    }

    

}
