using System;
using System.Collections.Generic;

// create program using stack to check if brackets are correct or not

class stackCheckChar
{
    static bool CheckBrackets(string expression)
    {
        Stack<char> stack = new Stack<char>();     //  Stack<char> store braces.
        char[] openingBrackets = { '(', '[', '{' };
        char[] closingBrackets = { ')', ']', '}' };

        foreach (char c in expression)
        {
            if (Array.IndexOf(openingBrackets, c) != -1) // Array.IndexOf() to find the index of the character in the arrays. 
            {
                stack.Push(c);    //Push() and Pop() methods of the stack to add and remove elements from the stack respectively.
            }
            else if (Array.IndexOf(closingBrackets, c) != -1)  
            {
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop(); 
                if ((top == '(' && c != ')') || (top == '[' && c != ']') || (top == '{' && c != '}'))
                    return false;
            }
        }

        return stack.Count == 0;
    }

    static void Main(string[] args)
    {
        string expression = "{([])}";
        bool result = CheckBrackets(expression);
        Console.WriteLine(result ? "Brackets are correct!" : "Brakets are not correct!");
    }
}