using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListBased
{
    public abstract class LinkeListBuffer<T> : IBuffer<T>
    {
        protected MyLinkedList<T> myLinkedList;

        public LinkeListBuffer(int maxSizeLimit)
        {
            myLinkedList = new MyLinkedList<T>(maxSizeLimit);
        }

        public abstract bool IsEmpty();
        public abstract bool IsFull();
        public abstract T Peek();
        /*
        public void Print()
        {
            Console.WriteLine("***************************************************");
            myLinkedList.Print();
            Console.WriteLine("***************************************************");
        }
        */
    }
}
