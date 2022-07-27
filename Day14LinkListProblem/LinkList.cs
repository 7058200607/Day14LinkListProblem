using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14LinkListProblem
{
    internal class LinkList
    {
        internal node head;
        internal void Add(int data)
        {
            node Node = new node(data);
            if (head == null)
            {
                this.head = Node;
            }
            else
            {
                node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = Node;
            }
            Console.WriteLine("{0} inserted Linked List", Node.data);
        }
        internal void Display()
        {
            node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkList is Empty ");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;

            }
        }
    }
}
