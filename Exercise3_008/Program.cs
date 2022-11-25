using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace Exercise3_008
{
    class Node
    {
        /*creates Nodes for the circular nexted list*/
        public int rollNumber;
        public string name;
        public Node next;
    }
    class CirCularList
    {
        Node LAST;
        public CirCularList()
        {
            LAST = null;
        }
        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                    return (true);/*returns true if the node is found*/
            }
            if (rollNo == LAST.rollNumber)/*If the node is present at the end*/
                return true;
            else
                return (false);/*returns false if the node is not found*/
        }
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
        public void traverse()/*Traverses all the nodes of the list*/
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("Recorcd in the list are : ");
                Node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + "  " + currentNode.name + " ");
                    currentNode = currentNode.next;
                }
                Console.Write(LAST.rollNumber + "  " + LAST.name + " ");
            }
           
        }
        public void firstNode()
        {
            if (listEmpty())
                Console.WriteLine("List is empty");
            else
                Console.WriteLine("The forst record in the list is : " + LAST.next.rollNumber + "     " + LAST.next.name);
        }
    }
}   
