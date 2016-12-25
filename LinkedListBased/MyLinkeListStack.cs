using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListBased
{
    public class MyLinkeListStack<T> : LinkeListBuffer<T>, IMyStack<T>
    {
        public MyLinkeListStack(int maxSizeLimit) : base(maxSizeLimit) { }

        public override bool IsEmpty()
        {
            if (myLinkedList.MyLinkedListSize == 0)
            {
                return true;
            }
            return false;
        }

        public override bool IsFull()
        {
            if (myLinkedList.MyLinkedListSize == myLinkedList.MyLinkedListMaxSizeLimit)
            {
                return true;
            }
            return false;
        }

        public override T Peek()
        {
            //Console.WriteLine("\nTry to peek the element.");

            return myLinkedList.Get(myLinkedList.MyLinkedListSize - 1);
        }

        public T Pop()
        {
            //Console.WriteLine("\nTry to pop the element.");

            T valueToReturn = myLinkedList.Get(myLinkedList.MyLinkedListSize - 1);
            myLinkedList.Remove(myLinkedList.MyLinkedListSize - 1);

            return valueToReturn;
        }

        public void Push(T valueToAdd)
        {
            //Console.WriteLine("\nTry to push the element.");

            myLinkedList.Add(valueToAdd);
        }
    }
}
