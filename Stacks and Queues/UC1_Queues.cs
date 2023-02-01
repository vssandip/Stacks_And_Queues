using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
    internal class UC1_Queues
    {
        public Node front;
        public Node rare;
        public void enqueue(int data)
        {
            Node node = new Node();
            node.data = data;
            if (front == null)
            {
                front = node;
                rare = node;
            }
            else
            {
                rare.next = node;
                rare = node;
            }


        }
        public void show()
        {
            Node temp = front;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
