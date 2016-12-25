using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayBased
{
    public class DynamicQueue<T> : DynamicBuffer<T>, IMyQueue<T>
    {
        public DynamicQueue(int initialQueueSize, int maxQueueSize) : base(initialQueueSize, maxQueueSize) { }


        public override bool IsEmpty()
        {
            bool returnValue = false;

            if (dynamicArray.Size == 0)
            {
                //Console.WriteLine("The queue is empty.");
                returnValue = true;
            }

            return returnValue;
        }

        public override bool IsFull()
        {
            bool returnValue = false;

            if (dynamicArray.Size == dynamicArray.MaxSizeOfDynamicArray)
            {
                //Console.WriteLine("The queue is full.");
                returnValue = true;
            }

            return returnValue;
        }

        public override T Peek()
        {
            T returnValue = default(T);

            if (!IsEmpty())
            {
                returnValue = dynamicArray.Get(0);
            }
            else
            {
                //Console.WriteLine("Cannot peek from the queue");
            }

            return returnValue;
        }



        public void Enqueue(T valueToAdd)
        {
            if (!IsFull())
            {
                dynamicArray.Add(valueToAdd);
            }
            else
            {
                //Console.WriteLine("Cannot enqueue the queue.");
            }
        }

        public T Dequeue()
        {
            T returnValue = default(T);

            if (!IsEmpty())
            {
                returnValue = dynamicArray.Get(0);
                dynamicArray.Remove(0);
            }
            else
            {
                //Console.WriteLine("Cannot dequeue from the queue");
            }

            return returnValue;
        }
    }

}
