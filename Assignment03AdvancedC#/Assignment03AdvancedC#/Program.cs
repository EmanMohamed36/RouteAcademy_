namespace Assignment03AdvancedC_
{
    internal class Program
    {
        static int ReadInt()
        {
            bool isInt = true;
            int number;
            do
            {
                if (!isInt)
                { 
                    Console.WriteLine("Enter Integer Value");
                
                }
                isInt = int.TryParse(Console.ReadLine(), out number);
            }
            while (!isInt);
            return number;
        }
        static bool IsParanthes(char c)
        { 
            return c == '{' || c == '}' || c == ']' || c == '[' || c == ')' || c == '(';
        }
        static string ReadStringOfParanthes()
        {

            bool isValid;
            string input;
            do
            {
                input = Console.ReadLine();
                isValid = true;
                for (int i = 0; i < input.Length; i++)
                {
                    if (!IsParanthes(input[i]))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (!isValid)
                {
                    Console.WriteLine("Please Enter correct String");
                }

            } while (!isValid);
            return input;
        }
        static void Main(string[] args)
        {
            #region Q1
            /*
                 implement a function to reverse the elements of a queue using a stack.Given a Queue,
             */
            Queue<int> que = new Queue<int>();
            Console.Write("Enter Count Queue: ");
            int QSize = ReadInt();
            Console.WriteLine("Enter Queue Elements: ");
            for (int i = 0; i < QSize; i++)
            { 
                Console.Write($"Enter Element {i + 1}: ");
                que.Enqueue(ReadInt());
            }
            

            Helper.ReverseQueue(que);
            Helper.PrintQueue(que);

            #endregion

            #region Q2
            //Given a Stack, implement a function to check if a string of parentheses is balanced using a stack
            Console.WriteLine();
            Console.WriteLine("Enter String Of Patanthes");

            string input = ReadStringOfParanthes();
            bool isBalace = Helper.IsBalanced(input);
            if(isBalace)
            Console.WriteLine("Balanced");
            else
                Console.WriteLine("Not Balanced");
            #endregion
        }
    }
}
