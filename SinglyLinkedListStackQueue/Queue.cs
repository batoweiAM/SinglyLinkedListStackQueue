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
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

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

        public int Size()
        {
            return size;
        }
    }
}
