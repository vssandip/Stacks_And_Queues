using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stacks_and_Queues
{
    internal class StackQueue
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
