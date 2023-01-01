using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure_Problems
{
    public class LinkedListQueue<T>
    {
        public CashCounter<T> front = null;
        public CashCounter<T> end = null;
        public void EnqueuePerson(T person)
        {
            CashCounter<T> node = new CashCounter<T>(person);
            if (front == null)
            {
                front = node;
            }
            else
            {
                CashCounter<T> temp = front;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is present either deposit or withdraw money", node.person);
        }
        public void Display()
        {
            CashCounter<T> temp = this.front;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.person + " ");
                temp = temp.next;
            }
        }
        public void DequeuePerson()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is empty and Deletion is not possible");
                return;
            }
            CashCounter<T> temp = this.front;
            this.front = this.front.next;
            if (this.front == null)
            {
                this.end = null;
            }
            Console.WriteLine("Remove Person is {0}", temp.person);
        }
    }
}
