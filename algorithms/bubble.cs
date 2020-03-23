using System;
namespace visualSorting
{
    class bubble
    {
        static public int[] sort(MyArray arr)
        { 
            int len = arr.obj.Length;
            for(int i=0; i<len; i++)
            {
                for(int j=0; j<len-i-1; j++)
                {
                    if(arr.obj[j] > arr.obj[j+1])
                    {
                        MyArray.swap(arr, j, j+1);
                        
                    }
                }
            }
            return arr.obj;
        }
    }
    
}