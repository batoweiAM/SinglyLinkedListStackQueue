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
   
    //Generic linked linkedlist class
    public class LinkedList<T>
    {
        private Node<T> head;
        private int size;

        //constructor declaring head to null and the size to zero showing an empty list
        public LinkedList()
        {
            this.head = default!;
            this.size = 0;
        }

        //Method that adds to the linkedlist
        public int Add(T item)
        {
            var newNode = new Node<T>(item);

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

        //method that removes from the linkedlist
        public bool Remove(T item)
        {
            if (head == null)
            {
                return false;
            }

            if (head.data!.Equals(item))
            {
                head = head.next;
                size--;
                return true;
            }

            Node<T> current = head;

            while (current.next != null && !current.next.data!.Equals(item))
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

        //checking the list if item is available
        public bool Check(T item)
        {
            if (head == null)
            {
                return false;
            }

            Node<T> current = head;

            while (current != null)
            {
                if (current.data!.Equals(item))
                {
                    return true;
                }

                current = current.next;
            }

            return false;
        }

        //index of each item in the list
        public int Index(T item)
        {
            if (head == null)
            {
                return -1;
            }

            int index = 0;

            Node<T> current = head;

            while (current != null && !current.data!.Equals(item))
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

        //Displaying the linkedlist when added
        public void PrintList()
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

    