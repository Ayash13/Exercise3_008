using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public int info;
        public Node link;

    }

    class CirCularList
    {
        Node LAST;
        Node newNode;
        Node dell;

        public CirCularList()
        {
            LAST = null;
        }
        public bool Search(int rollNo, ref Node previous, ref Node current, ref Node dell, ref Node newNode)
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next, dell = LAST.next = current.next)
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
                Node currentNode, dellNode, insert;
                currentNode = LAST.next;
                dellNode = LAST.next = currentNode.next;
                insert = LAST.next = newNode;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + "  " + currentNode.name + " ");
                    Console.Write(dellNode.rollNumber + "  " + dellNode.name + "  ");
                    Console.WriteLine("");
                    currentNode = currentNode.next;
                    dellNode = currentNode.next;
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
        public void InsertAfter()
        {
            //Create function to insert Ndoe
            if (listEmpty())
                Console.WriteLine("List is empty");
            else
                Console.WriteLine("Insertion complete" + newode.next = LAST.next);
           
        }
        public void DeleteNode()
        {
            if (listEmpty())
                Console.WriteLine("List is empty");
            else
                Console.WriteLine("Delete node" + LAST.next == current.next);
        }

        static void Main(string[] args)
        {
            CirCularList obj = new CirCularList();
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu ");
                    Console.WriteLine("1. View all the record in the list");
                    Console.WriteLine("2. Search for a record in the list");
                    Console.WriteLine("3. Display the first record in the list");
                    Console.WriteLine("4. Insert Node");
                    Console.WriteLine("5. Dellete Node");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("Enter your choice (1-6)");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.traverse();
                            }
                            break;
                        case '2':
                            {
                                if (obj.listEmpty() == true)
                                {
                                    Console.WriteLine("List is empty");
                                    break;
                                }
                                Node prev, curr;
                                prev = curr = null;
                                Console.Write("Enter the roll number of the student whose record is to be searched : ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.Search(num, ref prev, ref curr) == false)
                                    Console.WriteLine("Record not found");
                                else
                                {
                                    Console.WriteLine("Record FOund");
                                    Console.WriteLine("Roll number :" + curr.rollNumber);
                                    Console.WriteLine("Name : " + curr.name);
                                }
                            }
                            break;
                        case '3':
                            {
                                obj.firstNode();
                            }
                            break;
                        case '4':
                            {
                                obj.InsertAfter();
                               
                            }
                            break;
                        case '5':
                            {
                                obj.DeleteNode();

                            }
                            break;


                        case '6':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid Option");
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }

        }
    }
}   
