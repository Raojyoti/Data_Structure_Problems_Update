using System;
using System.Drawing;
using System.Threading;

namespace Data_Structure_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            string text = "Today is not sunday";
            string[] list = text.Split(" ");
            int count = 0;
            while (count < list.Length)
            {
                linkedList.Add(list[count++]);
            }
            linkedList.Display();
            linkedList.Search("is");
            Console.Write("\n");
            LinkedList<int> linkedOrderedList = new LinkedList<int>();
            int[] number = { 5, 1, 9, 2, 35, 24, 2 };
            int[] list1 = number;
            Array.Sort(list1);
            int count1 = 0;
            while (count1 < list1.Length)
            {
                linkedOrderedList.Add(list1[count1++]);
            }
            linkedOrderedList.Display();
            linkedOrderedList.Search(9);

        }
    }
}
