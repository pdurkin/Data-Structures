using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAndStackArrays
{
    /*
        A <generic> implementation of a Queue Data Structure. 
    */

    class GenericQueue<T>
    {
        int currentSize;
        int frontIndex;
        int backIndex;
        T[] queueArray;


        public GenericQueue(int maxSize)
        {
            currentSize = 0;
            queueArray = new T[maxSize];
            frontIndex = 0;
            backIndex = 0;
        }

        //TODO: Add error/bound checking for enqueueing/dequeueing. Wrap around feature.
        public void enqueue(T value)
        {
            if (isFull())
            {
                //Queue is full!
                Console.WriteLine("Cannot enqueue, the queue is full!");
            }
            else
            {
                //add value into the queue
                queueArray[backIndex] = value;

                //if we've reached the end of the array, need to loop back around.
                if (backIndex == queueArray.Length - 1)
                {
                    backIndex = 0;
                }
                else
                {
                    backIndex++;
                }
   
                currentSize++;
            }            
        }

        public T dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Cannot dequeue, the queue is empty!");
                return default(T); //maybe throw underflow exception instead?
            }
            else
            {
                T value = queueArray[frontIndex];

                //if we've reached the end of the array, need to loop back around.
                if (frontIndex == queueArray.Length - 1)
                {
                    frontIndex = 0;
                }
                else
                {
                    frontIndex++;
                }
                
                currentSize--;
                return value;
            }
        }

        public int size()
        {
            //return the size of the queue
            return currentSize;
        }

        public bool isFull()
        {
            if (currentSize == queueArray.Length) return true;
            else return false;
        }

        public bool isEmpty()
        {
            if (currentSize == 0) return true;
            else return false;
        }
    }
}
