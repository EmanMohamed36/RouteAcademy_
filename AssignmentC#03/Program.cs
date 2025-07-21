namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {   
             
            #region Q1
            //1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            Console.Write("Enter The Number to check if the number divide by 3 and 4: ");
            bool isNumber = int.TryParse(Console.ReadLine() , out int number);

            if (number % 3 == 0 && number % 4 == 0) 
            {
                Console.WriteLine("YES"); 
            }
            else
            {
                Console.WriteLine("NO"); 
                
            }

            #endregion

            #region Q2
            //2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            Console.Write("Enter The Number to check the number is negative or positive:");
            bool isNumber2 = int.TryParse(Console.ReadLine(), out int Number2);

            if (Number2 < 0)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is Positive");
            }

            #endregion
            #region Q3
            //3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            Console.WriteLine("Enter Three integer to get Max and Min number");
            bool isN1 = int.TryParse(Console.ReadLine(),out int N1);
            bool isN2 = int.TryParse(Console.ReadLine(), out int N2);
            bool isN3 = int.TryParse(Console.ReadLine(), out int N3);
            int minNumber = Math.Min(N1,Math.Min(N2,N3));
            int maxNumber = Math.Max(N1,Math.Max(N2,N3));
            Console.WriteLine($"Minimum Number is {minNumber} , Maximum Number is {maxNumber}");

            #endregion

            #region Q4
            //4- Write a program that allows the user to insert an integer number then check If a number is even or odd.

            Console.WriteLine("Enter Number to check it is even or odd");
            bool isNum = int.TryParse(Console.ReadLine(),out int num);
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");

            }
            else
            {
                Console.WriteLine("Number is odd");

            }
            #endregion

            #region Q5
            //5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            Console.WriteLine("Enter Character to check is bowel or not");
            
            bool isCharacter = char.TryParse(Console.ReadLine(),out char character);
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' || character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'U')
            {
                Console.WriteLine("Character is Vowel");
            }
            else
            {
                Console.WriteLine("Character is Constant");

            }
            #endregion


        }
    }
}
