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
            LinkedListStack<string> linkedListStack = new LinkedListStack<string>();
            BalancedParanthesis balancedParanthesis=new BalancedParanthesis();
            string balancedPath = @"E:\Data_Structure_Problems_Update\Data_Structure_Problems_Update\Data Structure Problems\Balanced.txt";
            balancedParanthesis.BalancedParenthesis(balancedPath);
            linkedListStack.Peek();
            linkedListStack.IsEmpty();
            LinkedListQueue<string> linkedListQueue = new LinkedListQueue<string>();
            Console.WriteLine("Person is Added into queue : ");
            Console.WriteLine("----------------------------");
            linkedListQueue.EnqueuePerson("Rahul");
            linkedListQueue.EnqueuePerson("Amit");
            linkedListQueue.EnqueuePerson("Aman");
            linkedListQueue.EnqueuePerson("Riya");
            linkedListQueue.Display();
            linkedListQueue.DequeuePerson();
            Console.WriteLine("----------------------------");
            linkedListQueue.Display();
            Console.WriteLine("\n");
        }
    }
}
