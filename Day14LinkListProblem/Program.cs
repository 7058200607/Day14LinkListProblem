using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14LinkListProblem 
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Do LinkList Operation ");
            LinkList linklist = new LinkList();
            linklist.Add(56);
            linklist.Add(30);
            linklist.Add(70);

            /*linklist.Display();
            linklist.Appending(56);
            linklist.Appending(30);
            linklist.Appending(70);
            linklist.Display();

            linklist.InsertAtPerticularPosition(30, 2);
            linklist.Display();

            Console.WriteLine("Delete First element from Link List ");
            linklist.pop_front();
           linklist.Display();*/

           // linklist.pop_back(70);
            //linklist.Display();

            linklist.SearchElement(30);
            linklist.SearchElement(56);
            linklist.SearchElement(70);

            linklist.push_at(40, 3);
            linklist.Display();
        }

    }
}