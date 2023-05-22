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
    public class SinglyLinkList<T> : IEnumerable<Node<T>>
    {
        public Node<T>? Head { get; set; }
        public int Count { get; set; }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T>? currentNode = Head;

            while (currentNode != null)
            {
                yield return currentNode;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Node<T> item)
        {
            if (Head == null)
            {
                Head = item;
            }
            else
            {
                item.Next = Head;
                Head.Prev = item;

                Head = item;
            }

            Count++;
        }
        public bool Remove(Node<T> item)
        {
            if (Head == null)
            {
                return false;
            }
            if (Head.Item.Equals(item))
            {
                Head = Head.Next;
                Count--;
                return true;
            }
            var currentNode = Head;
            while (!(currentNode.Next == null))
            {
              if (currentNode.Next.Item.Equals(item))
                {
                    currentNode = currentNode.Next;
                    Count--;
                    return true;
                }   
              currentNode = currentNode.Next;
            }
            return false;
        }
        public bool Check(Node<T> item)
        {
            var currentNode = Head;
            while (!(currentNode == null))
            {
                if (currentNode.Item.Equals(item))
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }

        public int Index(Node<T> item)
        {
            var nodeCount = 0;
            var currentNode = Head;
            while (!(currentNode == null))
            {
                if (currentNode.Item.Equals(item))
                {
                    return nodeCount;
                }
                nodeCount++;
                currentNode = currentNode.Next;
            }
            return -1;
        }
    }
}
