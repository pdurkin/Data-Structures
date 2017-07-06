using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAndStackArrays
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            GenericQueue<int> queue = new GenericQueue<int>(3);
            GenericStack<int> stack = new GenericStack<int>(4);

            /*
            queue.enqueue(3);
            queue.enqueue(6);
            queue.enqueue(2);

            Console.WriteLine("Queue size is: " + queue.size());

            queue.enqueue(1);

            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());

            Console.WriteLine("Queue size is: " + queue.size());

            queue.dequeue();

            queue.enqueue(3);
            queue.enqueue(6);
            queue.enqueue(2);

            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());

            queue.enqueue(7);
            queue.enqueue(9);

            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());

            queue.enqueue(19);
            */

            stack.push(4);
            stack.push(19);
            stack.push(8);

            Console.WriteLine("Stack is full? " + stack.isFull().ToString());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());

            Console.ReadLine();
        }
    }
}
