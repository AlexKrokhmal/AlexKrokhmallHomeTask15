using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ILinkedList<T>
    {
        void Add(T valueToAdd);
        void Remove(int positionToRemove);
        T Get(int positionToGet);
        void Insert(T valueToInsert, int positionToInsert);
    }
}
