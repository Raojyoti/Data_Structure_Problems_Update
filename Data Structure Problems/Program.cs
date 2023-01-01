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
            
        }
    }
}
