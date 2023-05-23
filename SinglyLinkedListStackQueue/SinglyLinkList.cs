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
    class LinkedList<T>
    {
        public Node<T> _head;

        public int Add(T item)
        {
            Node<T> newNode = new Node<T>() { Value = item };

            if (_head == null)
            {
                _head = newNode;
                return 1;
            }

            Node<T> currentNode = _head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = newNode;

            int count = 1;
            currentNode = _head;

            while (currentNode.Next != null)
            {
                count++;
                currentNode = currentNode.Next;
            }

            return count + 1;
        }

        public bool Remove(T item)
        {
            if (_head == null)
                return false;

            if (_head.Value.Equals(item))
            {
                _head = _head.Next;
                return true;
            }

            Node<T> currentNode = _head;

            while (currentNode.Next != null && !currentNode.Next.Value.Equals(item))
                currentNode = currentNode.Next;

            if (currentNode.Next == null)
                return false;

            currentNode.Next = currentNode.Next.Next;

            return true;
        }

        public bool Check(T item)
        {
            Node<T> currentNode = _head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item))
                    return true;

                currentNode = currentNode.Next;
            }

            return false;
        }

        public int Index(T item)
        {
            Node<T> currentNode = _head;

            int index = 0;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item))
                    return index;

                index++;
                currentNode = currentNode.Next;
            }

            return -1;
        }
    }
}

    