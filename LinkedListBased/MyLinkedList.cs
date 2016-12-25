using Common;
using LinkedListBased;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListBased
{
    public class MyLinkedList<T> : ILinkedList<T>
    {
        private int myLinkedListSizeLimit;

        private Node<T> head;
        private Node<T> tailPointer;

        public int MyLinkedListSize { private set; get; }


        public int MyLinkedListMaxSizeLimit
        {
            private set
            {
                if (value > 0)
                {
                    myLinkedListSizeLimit = value;
                }
                else
                {
                    myLinkedListSizeLimit = 20;
                }
            }
            get
            {
                return myLinkedListSizeLimit;
            }
        }


        public MyLinkedList(int myLinkedListSizeLimit)
        {
            head = new Node<T>();
            head.nodeValue = default(T);
            head.linkToNextElement = null;
            tailPointer = new Node<T>();
            tailPointer.nodeValue = default(T);
            tailPointer.linkToNextElement = head;
            MyLinkedListSize = 0;
            MyLinkedListMaxSizeLimit = myLinkedListSizeLimit;

        }

        public void Add(T valuetoAdd)
        {
            if (MyLinkedListSize < MyLinkedListMaxSizeLimit)
            {
                var newElement = new Node<T>(valuetoAdd);

                tailPointer.linkToNextElement.linkToNextElement = newElement;
                tailPointer.linkToNextElement = newElement;
                newElement.linkToNextElement = null;
                MyLinkedListSize++;
            }
            else
            {
                //Console.WriteLine("Error: Max size has been reached");
            }
        }

        public T Get(int index)
        {
            if (MyLinkedListSize > index && MyLinkedListSize != 0)
            {
                var TempNode = head;
                for (int i = 0; i <= index; i++)
                {
                    TempNode = GetNextElement(TempNode);
                }
                return TempNode.nodeValue;
            }
            else
            {
                //Console.WriteLine("Error: Operation cannot be done. Out of range exception");
                return default(T);
            }
        }

        private Node<T> GetNextElement(Node<T> incomingValue)
        {
            return incomingValue.linkToNextElement;
        }

        public void Remove(int positionToRemove)
        {
            if (positionToRemove >= 0 && positionToRemove < MyLinkedListSize)
            {
                var tempNode = new Node<T>();
                tempNode = head;
                for (int i = 0; i < positionToRemove; i++)
                {
                    tempNode = tempNode.linkToNextElement;
                }

                if (positionToRemove == MyLinkedListSize - 1)
                {
                    tailPointer.linkToNextElement = tempNode;
                }

                tempNode.linkToNextElement = tempNode.linkToNextElement.linkToNextElement;
                MyLinkedListSize--;
            }
            else
            {
                //Console.WriteLine("Error: Operation cannot be done. Out of range exception");
            }

        }

        public void Insert(T valueToInsert, int positionToInsert)
        {
            if (MyLinkedListSize < MyLinkedListMaxSizeLimit)
            {
                if (positionToInsert >= 0 && positionToInsert < MyLinkedListSize)
                {
                    var tempNode = new Node<T>();
                    var newNode = new Node<T>(valueToInsert);
                    tempNode = head;

                    for (int i = 0; i < positionToInsert; i++)
                    {
                        tempNode = tempNode.linkToNextElement;
                    }
                    newNode.linkToNextElement = tempNode.linkToNextElement;
                    tempNode.linkToNextElement = newNode;

                    MyLinkedListSize++;
                }
                else
                {
                    //Console.WriteLine("Error: Operation cannot be done. Out of range exception");

                }
            }
            else
            {
                //Console.WriteLine("Error: Max size has been reached");
            }
        }

        /*
        public void Print()
        {
            Node<T> tempNode = head;

            for (int i = 0; i <= MyLinkedListSize; i++)
            {
                tempNode.Print();
                tempNode = GetNextElement(tempNode);
            }
            Console.WriteLine();
        }
        */



    }
}
