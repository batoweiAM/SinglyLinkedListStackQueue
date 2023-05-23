using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SinglyLinkedListStackQueue;

public class Stack<T>
{
    public LinkedList<T> list;

    public Stack()
    {
        list = new LinkedList<T>();
    }

    public bool IsEmpty(Node<T> node)
    {
        return list.head == null;
    }
    // Push a node onto the stack
    public void Push(Node<T> node)
    {
        list.Add(node);
    }

    // Pop a node off the stack
    public Node<T> Pop()
    {
        if (list == null || list.head == null)
        {
            return null;
        }

        Node<T> current = list.head;
        while (current.Next != null && current.Next.Next != null)
        {
            current = current.Next;
        }

        Node<T> result = current.Next ?? list.head;

        if (result == list.head)
        {
            list.head = null;
            return result;
        }

        current.Next = null;

        return result;
    }
    public T Peek()
    {
        if (list.head == null)
            throw new InvalidOperationException("Stack is empty");

        return list.head.Data;
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
