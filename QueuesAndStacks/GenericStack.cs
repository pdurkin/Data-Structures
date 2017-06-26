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
        int bottomIndex;
        T[] stackArray;

        public GenericStack(int maxSize)
        {
            stackArray = new T[maxSize];
            topIndex = 0;
            bottomIndex = 0;
            currentSize = 0;
        }

        public T pop()
        {
            currentSize--;
            return stackArray[topIndex];
        }

        public void push(T value)
        {
            stackArray[bottomIndex] = value;
            bottomIndex++;
            currentSize++;
        }

        public T peek()
        {
            return stackArray[topIndex];
        }

        public int size()
        {
            return currentSize;
        }

        
    }
}
