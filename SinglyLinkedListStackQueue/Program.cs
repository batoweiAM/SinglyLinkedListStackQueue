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
            var linkedList = new LinkedList<int>();
            linkedList.Add(10);
            linkedList.Add(15);
            linkedList.Add(20);
            linkedList.Add(25);
            linkedList.Add(30);
            linkedList.PrintList();

            Console.WriteLine("Remove 30 from LinkedList: " + linkedList.Remove(30));
            Console.WriteLine("Check if 15 is in LinkedList: " + linkedList.Check(15));
            Console.WriteLine("Index of LinkedList: " + linkedList.Index(30));

            //Stack output
            Console.WriteLine();

            var stack = new Stack<int>();
            stack.Push(10);
            stack.Push(15);
            stack.Push(20);
            stack.Push(25);
            stack.Push(30);
            stack.PrintStack();

            Console.WriteLine("Pop from Stack: " + stack.Pop());
            Console.WriteLine("Stack size: " + stack.Size());
            Console.WriteLine("Peek at Stack: " + stack.Peek());
            Console.WriteLine("Is Stack empty? " + stack.IsEmpty());

            //Queue output
            Console.WriteLine();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);
            queue.Enqueue(25);
            queue.Enqueue(30);
            queue.PrintQueue();

            Console.WriteLine("Dequeue from Queue: " + queue.Dequeue());
            Console.WriteLine("Queue size: " + queue.Size());
            Console.WriteLine("Is Queue empty? " + queue.IsEmpty());

            Console.ReadKey();
        }
    }
}
