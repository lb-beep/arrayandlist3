using System;
using System.Collections.Generic;

namespace arrayAndList
{
    class Program
    {
        static void Main()
        {
            int[] thisArray = new int[10];
            thisArray[0] = 1;
            thisArray[1] = 2;
            thisArray[2] = 3;
            thisArray[3] = 4;
            thisArray[4] = 5;
            thisArray[5] = 6;
            thisArray[6] = 7;
            thisArray[7] = 8;
            thisArray[8] = 9;
            thisArray[9] = 10;


            for (int x = 0; x < 8; x++)
            {
                Console.WriteLine("The Value of index: " + thisArray[x]);
            }


            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);    
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);
            myList.Add(10);

            foreach (var item in myList)
            {
                Console.Write(item + ", ");
            }

        }
    }
}
