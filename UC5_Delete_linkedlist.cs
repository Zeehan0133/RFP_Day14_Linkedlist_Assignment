using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_Stack_QueueAssignment
{
    public class UC5_Delete_linkedlist
    {
        internal Node head;

        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into LinkedList", node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }



      internal Node pop()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }





    }

}
