using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03AdvancedC_
{
    
    internal class Helper
    {
        public static void ReverseQueue<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
    
        public static void PrintQueue<T>(Queue<T> queue)
        {
            Console.WriteLine("Queue After Reverse");
            foreach (var item in queue)
            { 
                Console.Write(item + " ");
            }
        }

        static bool OpenParanthes(char c)
        {
            return c == '{' || c == '[' || c == '(';
        }
        public static bool IsBalanced(string input)
        { 
            Stack<char> paranthes = new Stack<char>();
            int i;
            for (i = 0; i < input.Length; i++)
            {
                if (OpenParanthes(input[i]))
                {
                    paranthes.Push(input[i]);
                }
                else
                {
                    if (paranthes.Count > 0)
                    {
                        char op = paranthes.Peek();
                        if ((input[i] == '}' && op == '{') || (input[i] == ')' && op == '(') || (input[i] == ']' && op == '['))
                        {
                            if (paranthes.Count > 0)
                                paranthes.Pop();
                        }
                        else break;

                    }
                    else break;
                    
                }
            }
              //  Console.WriteLine(i);
            return(paranthes.Count == 0 && i == input.Length);
        }
    }
}
