using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListStackQueue
{
    public class Queue<T>
    {
        public LinkedList<T> list;

        public Queue()
        {
            list = new LinkedList<T>();
        }

        public bool IsEmpty(Node<T> node)
        {
            return list.head == null;
        }


        // Enqueue a node into the queue
        public void Enqueue(Node<T> node)
        {
            list.Add(node);
        }

        // Dequeue a node from the queue
        public Node<T> Dequeue()
        {
            if (list == null || list.head == null)
            {
                return null;
            }

            Node<T> result = list.head;

            list.head = result.Next;

            return result;
        }

        public int Size()
        {
            int size = 0;

            Node<T> current = list.head;

            while (current != null)
            {
                size++;
                current = current.Next;
            }

            return size;
        }
    }
}