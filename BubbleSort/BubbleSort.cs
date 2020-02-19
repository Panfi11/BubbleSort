using System;

namespace Ordinamento
{
    public class BubbleSort
    {
        public static void Sort(int[] array)
        {
            int x, y;
            int temp;
            for (x=0;x< array.Length; x++)
            {
                for(y = 0; y < array.Length-1; y++)
                    if(array[y] > array[y + 1])
                    {
                        temp = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = temp;
                           
                    }
            }
        }
    }
}
