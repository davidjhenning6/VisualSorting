using System;

namespace visualSorting
{
    public class MyArray
    {
        public int[] obj {get; set;}

        public MyArray(int[] input)
        {
            obj = input;
        }

        static public void swap(MyArray arr, int a, int b)
        {
            int temp;
            temp = arr.obj[a];
            arr.obj[a] = arr.obj[b];
            arr.obj[b] = temp;
        }

        static public void print(int[] print)
        {
            int len = print.Length;
            for(int i=0; i<len; i++)
            {
                Console.Write(print[i]);
                if(i != len-1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write("\n");
                }
            }
        }
    }
}
