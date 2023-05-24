using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListStackQueue
{
    public class Queue<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int size;

        public Queue()
        {
            this.head = default!;
            this.tail = default!;
            this.size = 0;
        }

        //check if the queue is empty
        public bool IsEmpty()
        {
            return head == null;
        }

        //Enqueue the queue
        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }

            size++;
        }

        //Dequeue the queue
        public T Dequeue()
        {
            if (head == null)
            {
                throw new Exception("Queue is empty");
            }

            T item = head.data;

            head = head.next;

            size--;

            return item;
        }

        //showing size of the queue based on index
        public int Size()
        {
            return size;
        }

        //Printing the queue list
        public void PrintQueue()
        {
            Node<T> current = head;

            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
