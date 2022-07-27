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
                Console.WriteLine(temp.data + " ");
                temp = temp.next;

            }
        }
        public void Appending(int value)
        {
            node Node = new node(value);
            if (head == null)
            {
                head = Node;
            }
            else
            {
                node lastnode = Last();
                lastnode.next = Node;
            }
            Console.WriteLine(Node.data + "Inserted into list ");

        }
        public node Last()
        {
            node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        internal node InsertAtPerticularPosition(int position, int newelemnet)
        {
            node newnode = new node(newelemnet);
            newnode.data = position;
            newnode.next = null;


            if (position < 1)
                Console.WriteLine("\n position should be >= 1.");
            else if (position == 1)
            {
                newnode.next = this.head;
                head = newnode;
            }
            else
            {
                node temp = new node(newelemnet);
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp! == null)
                    {
                        temp = temp.next;
                    }
                }

                if (temp != null)
                {
                    newnode.next = temp.next;
                    temp.next = newnode;
                    Console.WriteLine("Position Out of Range");
                }
                else
                {
                    Console.WriteLine("Inserted element is" + head);

                }
            }
            return head;

        }
        public void pop_front()
        {
            if (this.head != null)
            {
                node temp = this.head;
                this.head = this.head.next;
                temp = null;
            }
        }
        public void pop_back(int data)
        {
            if (this.head != null)
            {
                if (this.head.next == null)
                {
                    this.head = null;
                }
                else
                {
                    node temp = new node(data);
                    temp = this.head;
                    while (temp.next.next != null)
                        temp = temp.next;
                    node lastNode = temp.next;
                    temp.next = null;
                    lastNode = null;
                }
            }

        }

        public void SearchElement(int searchValue)
        {
            node temp = new node();  
            temp = this.head;
            int found = 0;
            int i = 0;

            if (temp != null)
            {
                while (temp != null)
                {
                    i++;
                    if (temp.data == searchValue)
                    {
                        found++;
                        break;
                    }
                    temp = temp.next;
                }
                if (found == 1)
                {
                    Console.WriteLine(searchValue + " is found at index = " + i + ".");
                }
                else
                {
                    Console.WriteLine(searchValue + " is not found in the list.");
                }
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
        }
        public void push_at(int newElement, int position)
        {
            node newNode = new node();
            newNode.data = newElement;
            newNode.next = null;

            if (position < 1)
            {
                Console.Write("\nposition should be >= 1.");
            }
            else if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {

                node temp = new node();
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }

                if (temp != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    Console.Write("\nThe previous node is null.");
                }
            }
        }

    }
}