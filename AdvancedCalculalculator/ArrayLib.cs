using System;

namespace AdvancedCalculator
{
    public class ArrayLib
    {
        public static bool Contains<T>(T[] array, T element)
        {
            for (int i = 0; i <array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public static int Count<T> (T[] array, T element)
        {
            int cnt = 0;

            foreach (T i in array)
            {
                if (i.Equals(element))
                {
                    cnt++;
                }
            }

            return cnt;
        }
    }
}
