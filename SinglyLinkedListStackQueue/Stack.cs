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
            this.top = default!;
            this.size = 0;
        }

        //stack is empty
        public bool IsEmpty()
        {
            return top == null;
        }

        //Adding to the stack
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

        //Removing from the stack
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

        //peek through the last added value
        public T Peek()
        {
            if (top == null)
            {
                throw new Exception("Stack is empty");
            }

            return top.data;
        }

        //showing size of stack based on index
        public int Size()
        {
            return size;
        }

        //Printing the stack list
        public void PrintStack()
        {
            Node<T> current = top;

            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}



