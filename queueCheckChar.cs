// create program using stack to check if brackets are correct or not using queue 

using System;
using System.Collections.Generic;

class queueCheckChar
{
    static bool CheckBrackets(string expression)
    {
        Queue<char> queue = new Queue<char>(); // Queue<char> to store the opening braces.
        char[] openingBrackets = { '(', '[', '{' };
        char[] closingBrackets = { ')', ']', '}' };

        foreach (char c in expression)
        {
            if (Array.IndexOf(openingBrackets, c) != -1)
            {
                queue.Enqueue(c);  // Enqueue() and Dequeue() methods are used to add and remove elements from the queue respectively.
            }
            else if (Array.IndexOf(closingBrackets, c) != -1)  //Array.IndexOf() to find the index of the character in the arrays.
            {
                if (queue.Count == 0)
                    return false;

                char front = queue.Dequeue();
                if ((front == '(' && c != ')') || (front == '[' && c != ']') || (front == '{' && c != '}'))
                    return false;
            }
        }

        return queue.Count == 0;
    }

    static void Main(string[] args)
    {
        string expression = "{([])}";
        bool result = CheckBrackets(expression);
        Console.WriteLine(result ? "Correct!" : "Incorrect!");
    }
}