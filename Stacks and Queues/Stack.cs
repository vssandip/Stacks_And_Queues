using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
    internal class Stack
    {
        public Node top;
        public void push(int data)
        {
            Node node = new Node();
            node.data = data;
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }


        }
        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("The stack is empty");
            }
            else
            {
                top = top.next;
            }
        }
        public void show()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
