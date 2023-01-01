using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data_Structure_Problems
{
    internal class BalancedParanthesis
    {
        public void BalancedParenthesis(string filePath)
        {
            LinkedListStack<string> linkedListStack = new LinkedListStack<string>();
            var details = File.ReadAllText(filePath);
            string[] word = details.Split(' ');
            foreach (var data in word)
            {
                if (data.Equals("("))
                    linkedListStack.Push("(");
                if (data.Equals(")"))
                    linkedListStack.Pop();
            }
            if (linkedListStack.Count == 0)
                Console.WriteLine("Balanced Parentheses");
            else
                Console.WriteLine("Not a Balanced Parentheses");
        }
    }
}
