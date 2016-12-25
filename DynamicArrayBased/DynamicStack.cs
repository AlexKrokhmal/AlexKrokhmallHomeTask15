using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayBased
{
    public class DynamicStack<T> : DynamicBuffer<T>, IMyStack<T>
    {
        public DynamicStack(int initialStackSize, int maxStackSize) : base(initialStackSize, maxStackSize) { }


        public override bool IsEmpty()
        {
            if (dynamicArray.Size == 0)
            {
                //Console.WriteLine("The stack is empty.");
                return true;
            }
            else
            {
                //Console.WriteLine("The stack is not empty.");
                return false;
            }
        }

        public override bool IsFull()
        {
            if (dynamicArray.Size == dynamicArray.MaxSizeOfDynamicArray)
            {
                //Console.WriteLine("The stack is full.");
                return true;
            }
            else
            {
                //Console.WriteLine("The stack is not full.");
                return false;
            }
        }

        public override T Peek()
        {
            //Console.WriteLine("\nTry to peek the element.");

            return dynamicArray.Get(dynamicArray.Size - 1);
        }

        public T Pop()
        {
            //Console.WriteLine("\nTry to pop the element.");

            T valueToReturn = dynamicArray.Get(dynamicArray.Size - 1);
            dynamicArray.Remove(dynamicArray.Size - 1);

            return valueToReturn;
        }

        public void Push(T valueToAdd)
        {
            //Console.WriteLine("\nTry to push the element.");

            dynamicArray.Add(valueToAdd);
        }
    }
}
