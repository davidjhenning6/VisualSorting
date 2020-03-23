using System;
using System.Collections.Generic;

namespace visualSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var algo = getAlgo();//return int 1-5
            //var type = getDataType();//return int 1-3    benched this idea for now
            List<int> inputData = getData();//returns a list of user input
            var data = inputData.ToArray();
            
            switch(algo)
            {
                case "1":
                    //create merge sort
                    merge.input(data);
                    break;
                case "2":
                    //create bubble sort
                    bubble.sort(data);
                    break;
                case "3":
                    //create quick sort
                    //quick.sort(data);
                    break;
                case "4":
                    //create insertion sort
                    //insertion.sort(data);
                    break;
                case "5":
                    //create heap sort
                    //heap.sort(data);
                    break;
                default:
                    Console.WriteLine("how did you get here??");
                    break;
            }

            Console.WriteLine("Original:");
            printList(inputData);
            Console.WriteLine("Sorted:");
            MyArray.print(data);


        }

        static private string getAlgo()
        {
            //Console.WriteLine("Welcome to Dave's Algo Implementations!");

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
            int len = 5;

            Console.WriteLine("Length of array is 5\n enter 5 numbers:\n<#><enter>");
            for(int i = 0; i < len; i++)
            {
                data.Add(Console.ReadLine());
            }

            return ListStrToInt(data);
        }

        static private List<int> ListStrToInt(List<string> inputData)
        {
            List<int> data = new List<int>();

            for(int i=0; i<inputData.Count; i++)
            {
                data.Add(System.Convert.ToInt32(inputData[i]));
            }

            return data;
        }

        static private void printList(List<int> list)
        {
            int len = list.Count;
            for(int i=0; i<len; i++)
            {
                Console.Write(list[i]);
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
