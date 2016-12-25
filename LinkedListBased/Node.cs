using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListBased
{
    public class Node<T>
    {
        public T nodeValue;
        public Node<T> linkToNextElement;

        public Node()
        { }

        public Node(T valueToAdd)
        {
            nodeValue = valueToAdd;
        }

        public void Print()
        {
            if (linkToNextElement != null)
            {
                Console.Write("{0}->{1}; ", nodeValue.ToString(), linkToNextElement.nodeValue.ToString());
            }
            else
            {
                Console.WriteLine("{0}->The End", nodeValue.ToString());
            }
        }

    }
}
