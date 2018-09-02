using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculalculator
{
    class DynamicArray<T>
    {
        T[] array;
        public DynamicArray(T[] array)
        {

        }

        public DynamicArray() { }
        
        public T this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }

        public void Push(int index, T element)
        {
            array[index] = element;
        }

        public void Pull
    }
}
