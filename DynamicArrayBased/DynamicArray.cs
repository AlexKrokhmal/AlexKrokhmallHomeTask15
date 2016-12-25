using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayBased
{
    
    public class DynamicArray<T>
    {
        private int dynamicArrayCapasity;
        private int dynamicArraySize;
        private int initialCapasity;
        private static int dynamicArrayGrowthFactor = 2;
        private static float dynamicArrayShorteningFactor = 0.6f;
        private int maxSizeOfDynamicArray;
        private T[] arrayOfGenerics;


        public int DynamicArrayCapasity
        {
            private set
            {
                if (value > 0)
                {
                    dynamicArrayCapasity = value;
                }
                else
                {
                    dynamicArrayCapasity = 2;
                }
            }
            get
            {
                return dynamicArrayCapasity;
            }
        }

        public int MaxSizeOfDynamicArray
        {
            private set
            {
                if (value > 0)
                {
                    maxSizeOfDynamicArray = value;
                }
                else
                {
                    maxSizeOfDynamicArray = 20;
                }
            }
            get
            {
                return maxSizeOfDynamicArray;
            }
        }

        public int Size { private set; get; }


        public DynamicArray(int dynamicArrayCapacity, int maxSizeOfDynamicArray)
        {
            DynamicArrayCapasity = dynamicArrayCapacity;
            MaxSizeOfDynamicArray = maxSizeOfDynamicArray;
            initialCapasity = DynamicArrayCapasity;
            Size = 0;
            arrayOfGenerics = new T[DynamicArrayCapasity];
        }




        public int Capacity()
        {
            return DynamicArrayCapasity;
        }

        public void Remove(int positionToRemove)
        {
            if (positionToRemove < Size && positionToRemove >= 0)
            {
                if (!ShouldWeShortenTheArray())
                {
                    if (positionToRemove == (Size - 1))
                    {
                        Size--;
                    }
                    else
                    {
                        for (int i = positionToRemove; i < Size - 1; i++)
                        {
                            arrayOfGenerics[i] = arrayOfGenerics[i + 1];
                        }
                        Size--;
                    }
                }
                else
                {
                    DynamicArrayCapasity = (int)(DynamicArrayCapasity * dynamicArrayShorteningFactor);
                    T[] tempArray = new T[DynamicArrayCapasity];

                    for (int i = 0; i < positionToRemove; i++)
                    {
                        tempArray[i] = arrayOfGenerics[i];
                    }

                    for (int i = positionToRemove; i < Size - 1; i++)
                    {
                        tempArray[i] = arrayOfGenerics[i + 1];
                    }

                    arrayOfGenerics = tempArray;
                    Size--;
                }
            }
            else
            {
                //Console.WriteLine("Operation cannot be done. Array size is smaller than the position you want to remove");
            }

        }

        public T Get(int positionToGetValue)
        {
            if (positionToGetValue < Size && positionToGetValue >= 0)
            {
                return arrayOfGenerics[positionToGetValue];
            }
            else
            {
                //Console.WriteLine("Operation cannot be done. Array size is smaller than the position you want to get");
                return default(T);
            }
        }

        public void Edit(T valueToUpdate, int positionToUpdate)
        {
            if (positionToUpdate <= Size && positionToUpdate >= 0)
            {
                arrayOfGenerics[positionToUpdate] = valueToUpdate;
            }
            else
            {
                //Console.WriteLine("Operation cannot be done. Array size is smaller than the position you want to insert");
            }
        }

        public void Insert(T valueToInsert, int positionToInsert)
        {
            if (positionToInsert <= Size && positionToInsert >= 0)
            {
                if (Size < MaxSizeOfDynamicArray)
                {
                    if (!ShouldWeEnlargeTheArray())
                    {
                        for (int i = Size; i > positionToInsert; i--)
                        {
                            arrayOfGenerics[i] = arrayOfGenerics[i - 1];
                        }
                        arrayOfGenerics[positionToInsert] = valueToInsert;
                        Size++;
                    }
                    else
                    {
                        DynamicArrayCapasity = DynamicArayCapasityAfterGrowth();
                        T[] tempArray = new T[DynamicArrayCapasity];

                        for (int i = 0; i < positionToInsert; i++)
                        {
                            tempArray[i] = arrayOfGenerics[i];
                        }

                        tempArray[positionToInsert] = valueToInsert;

                        for (int i = positionToInsert; i < Size; i++)
                        {
                            tempArray[i + 1] = arrayOfGenerics[i];
                        }

                        arrayOfGenerics = tempArray;
                        Size++;
                    }
                }
                else
                {
                    //Console.WriteLine("Operation cannot be done. Array size has reached to the maximum");
                }
            }
            else
            {
                //Console.WriteLine("Operation cannot be done. Array size is smaller than the position you want to insert");
            }
        }

        public void Add(T valueToAdd)
        {
            if (Size < MaxSizeOfDynamicArray)
            {
                if (!ShouldWeEnlargeTheArray())
                {
                    arrayOfGenerics[Size] = valueToAdd;
                    Size++;
                }
                else
                {
                    DynamicArrayCapasity = DynamicArayCapasityAfterGrowth();
                    T[] tempArray = new T[DynamicArrayCapasity];

                    for (int i = 0; i < arrayOfGenerics.Length; i++)
                    {
                        tempArray[i] = arrayOfGenerics[i];
                    }

                    arrayOfGenerics = tempArray;
                    arrayOfGenerics[Size] = valueToAdd;
                    Size++;
                }
            }
            else
            {
                //Console.WriteLine("Operation cannot be done. Array size has reached to the maximum");
            }

        }

        private int DynamicArayCapasityAfterGrowth()
        {
            return DynamicArrayCapasity * dynamicArrayGrowthFactor;
        }

        private bool ShouldWeShortenTheArray()
        {
            if (Size <= DynamicArrayCapasity / 2 && Size - 1 >= initialCapasity)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool ShouldWeEnlargeTheArray()
        {
            if (DynamicArrayCapasity > Size)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /*
        public void Print()
        {
            Console.WriteLine();
            foreach (var item in arrayOfGenerics)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
        */

    }
}