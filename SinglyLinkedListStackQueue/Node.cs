using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListStackQueue
{
    public class Node<T>
    {   //Naming generic fields representing data stored in the node
        public T data;
        public Node<T> next;

        //Constructor taking generic parameters
        public Node(T data)
        {
            this.data = data;
            this.next = default!;
        }
    }
}
