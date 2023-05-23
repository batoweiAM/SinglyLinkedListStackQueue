using SinglyLinkedListStackQueue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListStackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add();
            list.Add();
            list.Add();

            Console.WriteLine("Linked List:");
            Node<int> current = list.head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

        }
    }
}
