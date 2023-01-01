using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure_Problems
{
    public class CashCounter<T>
    {
        public T person;
        public CashCounter<T> next;
        public CashCounter(T person)
        {
            this.person = person;
        }
    }
}
