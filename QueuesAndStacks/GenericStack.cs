using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAndStackArrays
{
    /*
        A <generic> implementation of a Stack data structure. 
    */

    class GenericStack<T>
    {
        int currentSize;
        int topIndex;       
        T[] stackArray;

        public GenericStack(int maxSize)
        {
            stackArray = new T[maxSize];
            topIndex = 0;
            currentSize = 0;
        }

        public T pop()
        {
            T value;
            if (isEmpty())
            {
                Console.WriteLine("Cannot pop, the stack is empty!");
                return default(T); //maybe throw underflow exception?
            }
            else
            {
                topIndex--;
                value = stackArray[topIndex];
                currentSize--;
                return value;
            }
            
        }

        public void push(T value)
        {
            if (isFull())
            {
                Console.WriteLine("Cannot push, the stack is full!");
            }
            else
            {
                stackArray[topIndex] = value;
                topIndex++;
                currentSize++;
            }       
        }

        public T peek()
        {
            return stackArray[topIndex];
        }

        public int size()
        {
            return currentSize;
        }

        public bool isEmpty()
        {
            if (currentSize == 0) return true;
            else return false;
                     
        }

        public bool isFull()
        {
            if (currentSize == stackArray.Length) return true;
            else return false;
        }     
    }
}
