using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayBased
{
    public abstract class DynamicBuffer<T> : IBuffer<T>
    {
        protected DynamicArray<T> dynamicArray;


        public DynamicBuffer(int initialArraySize, int maxArraySize)
        {
            dynamicArray = new DynamicArray<T>(initialArraySize, maxArraySize);
        }


        public abstract bool IsEmpty();
        public abstract bool IsFull();
        public abstract T Peek();
        /*
        public void Print()
        {
            Console.WriteLine("***************************************************");
            dynamicArray.Print();
            Console.WriteLine("Capasity = {0}", dynamicArray.Capacity());
            Console.WriteLine("Size = {0}", dynamicArray.Size);
            Console.WriteLine("***************************************************");
        }
        */
    }
}
