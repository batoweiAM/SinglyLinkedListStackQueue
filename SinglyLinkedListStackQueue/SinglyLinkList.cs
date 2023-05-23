using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SinglyLinkedListStackQueue
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }

    public class LinkedList<T>
    {
        private Node<T> head;
        private int size;

        public LinkedList()
        {
            this.head = null;
            this.size = 0;
        }

        public int Add(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = newNode;
            }

            size++;

            return size;
        }

        public bool Remove(T item)
        {
            if (head == null)
            {
                return false;
            }

            if (head.data.Equals(item))
            {
                head = head.next;
                size--;
                return true;
            }

            Node<T> current = head;

            while (current.next != null && !current.next.data.Equals(item))
            {
                current = current.next;
            }

            if (current.next == null)
            {
                return false;
            }

            current.next = current.next.next;
            size--;

            return true;
        }

        public bool Check(T item)
        {
            if (head == null)
            {
                return false;
            }

            Node<T> current = head;

            while (current != null)
            {
                if (current.data.Equals(item))
                {
                    return true;
                }

                current = current.next;
            }

            return false;
        }

        public int Index(T item)
        {
            if (head == null)
            {
                return -1;
            }

            int index = 0;

            Node<T> current = head;

            while (current != null && !current.data.Equals(item))
            {
                index++;
                current = current.next;
            }

            if (current == null)
            {
                return -1;
            }

            return index;
        }
    }
}

    