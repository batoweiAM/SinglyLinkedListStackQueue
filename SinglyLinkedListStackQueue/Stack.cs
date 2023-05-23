using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListStackQueue
{
    public class Stack<T>
    {
        private Node<T> top;
        private int size;

        public Stack()
        {
            this.top = null;
            this.size = 0;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }

            size++;
        }

        public T Pop()
        {
            if (top == null)
            {
                throw new Exception("Stack is empty");
            }

            T item = top.data;

            top = top.next;

            size--;

            return item;
        }

        public T Peek()
        {
            if (top == null)
            {
                throw new Exception("Stack is empty");
            }

            return top.data;
        }

        public int Size()
        {
            return size;
        }
    }
}



