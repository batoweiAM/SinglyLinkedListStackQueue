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
    public class LinkedList<T>
    {
        public Node<T> head;

        public LinkedList()
        {
            head = null;
        }

        // Add a node to the list
        public void Add(Node<T> node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        // Remove a node from the list
        public void Remove(Node<T> node)
        {
            if (head == null)
            {
                return;
            }

            if (head.Data.Equals(node.Data))
            {
                head = head.Next;
                return;
            }

            Node<T> current = head;
            while (current.Next != null && !current.Next.Data.Equals(node.Data))
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        // Check if a node is in the list
        public bool Check(Node<T> node)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(node.Data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public int Index(Node<T> node)
        {
            int index = 0;
            Node<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(node))
                    return index;

                index++;
                current = current.Next;
            }

            return -1;
        }
    }
}
