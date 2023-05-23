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
            //singly linkedlist output
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Add(10);
            linkedList.Add(15);
            linkedList.Add(20);
            linkedList.Add(25);
            linkedList.Add(30);


            Console.WriteLine("Removing 20 from LinkedList: " + linkedList.Remove(20));
            Console.WriteLine("Checking if 15 is in LinkedList: " + linkedList.Check(15));
            Console.WriteLine("Index of 4 in LinkedList: " + linkedList.Index(4));

            //Stack output
            Console.WriteLine(); Console.WriteLine();

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(15);
            stack.Push(20);
            stack.Push(25);
            stack.Push(30);

            Console.WriteLine("Stack size: " + stack.Size());
            Console.WriteLine("Popping from Stack: " + stack.Pop());
            Console.WriteLine("Stack size: " + stack.Size());
            Console.WriteLine("Peeking at Stack: " + stack.Peek());
            Console.WriteLine("Is Stack empty? " + stack.IsEmpty());

            //Queue output
            Console.WriteLine(); Console.WriteLine();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);
            queue.Enqueue(25);
            queue.Enqueue(30);

            Console.WriteLine("Queue size: " + queue.Size());
            Console.WriteLine("Dequeueing from Queue: " + queue.Dequeue());
            Console.WriteLine("Queue size: " + queue.Size());
            Console.WriteLine("Is Queue empty? " + queue.IsEmpty());
        }
    }
}
