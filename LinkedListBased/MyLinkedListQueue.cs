using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListBased
{
    public class MyLinkedListQueue<T> : LinkeListBuffer<T>, IMyQueue<T>
    {
        public MyLinkedListQueue(int maxSizeLimit) : base(maxSizeLimit) { }

        public T Dequeue()
        {
            T valueToReturn = myLinkedList.Get(0);
            myLinkedList.Remove(0);
            return valueToReturn;
        }

        public void Enqueue(T valueToAdd)
        {
            myLinkedList.Add(valueToAdd);
        }

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
            return myLinkedList.Get(0);
        }
    }
}
