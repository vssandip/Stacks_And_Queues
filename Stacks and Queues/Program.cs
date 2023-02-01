namespace Stacks_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#$#$ Welcome To Stacks and Queues #$#$#");
            /* StackQueue a = new StackQueue();
             a.push(70);
             a.push(30);
             a.push(56);
             a.show();*/
            /*Stack a = new Stack();
            a.push(70);
            a.push(30);
            a.push(56);
            a.pop();
            a.pop();
            a.pop();
            a.pop();
            a.show();*/
            UC1_Queues a = new UC1_Queues ();
            a.enqueue(56);
            a.enqueue(30);
            a.enqueue(70);
            a.show();
        }
    }
}