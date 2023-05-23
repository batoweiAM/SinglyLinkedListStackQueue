using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SinglyLinkedListStackQueue;

class Stack<T>
{
    private List<T> _items = new List<T>();

    public bool IsEmpty()
    {
        return _items.Count == 0;
    }

    public void Push(T item)
    {
        _items.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The stack is empty");
        }

        int lastIndex = _items.Count - 1;
        T lastItem = _items[lastIndex];
        _items.RemoveAt(lastIndex);

        return lastItem;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The stack is empty");
        }

        int lastIndex = _items.Count - 1;
        T lastItem = _items[lastIndex];

        return lastItem;
    }

    public int Size()
    {
        return _items.Count;
    }
}




