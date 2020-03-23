using System;
using System.Collections.Generic;

namespace visualSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = {0,0,0,0,0}; 

            var algo = getAlgo();//return int 1-5
            //var type = getDataType();//return int 1-3
            List<int> inputData = getData();//return list
            var data = inputData.ToArray();
            

            

            switch(algo)
            {
                case "1":
                    //create merge sort
                    result = merge.input(data);

                    break;
                case "2":
                    //create bubble sort
                    result = bubble.sort(data);

                    break;
                case "3":
                    //create quick sort

                    break;
                case "4":
                    //create insertion sort

                    break;
                case "5":
                    //create heap sort


                    break;
                default:
                    Console.WriteLine("how did you get here??");
                    break;
            }

            Console.WriteLine("Original:");
            MyArray.print(data);
            Console.WriteLine("Sorted:");
            MyArray.print(result);

        }

        static private string getAlgo()
        {
            //Console.WriteLine("Welcome to Dave's Algo Implementations!");
            //get algo type
            Console.WriteLine("Enter the number for your algorithm of choice:");
            Console.Write("1) Merge\n2) Bubble\n3) Quick\n4) Insertion\n5) Heap\n<number><enter>\n");
            string type = Console.ReadLine();
            while(string.Compare(type, "1") != 0 && string.Compare(type, "2") != 0 && string.Compare(type, "3") != 0 && string.Compare(type, "4") != 0 && string.Compare(type, "5") != 0){
                Console.Write("Incorrect input\nTry Again\n");
                type = Console.ReadLine();
            }
            return type;
        }

        static private List<int> getData()
        {
            List<string> data = new List<string>();
            //string length;
            int len = 5;

            // do{
            //     Console.WriteLine("Enter length of array:");
            //     length = Console.ReadLine();
            // }while(!int.TryParse(length, out len));
            Console.WriteLine("Length of array is 5\n enter 5 numbers:\n<#><enter>");

            //len = System.Convert.ToInt32(length);
            for(int i = 0; i < len; i++)
            {
                data.Add(Console.ReadLine());
            }

            return listConvert(data);
        }

        static private List<int> listConvert(List<string> inputData)
        {
            List<int> data = new List<int>();

            for(int i=0; i<inputData.Count; i++)
            {
                data.Add(System.Convert.ToInt32(inputData[i]));
            }

            return data;
        }

        
    }
}
