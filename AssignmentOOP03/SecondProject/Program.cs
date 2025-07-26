namespace SecondProject
{
    
    internal class Program
    {
        static double CheckDouble(String st)
        {
            double value;
            bool isValid = false;
            do
            {
                Console.Write(st);
                isValid = double.TryParse(Console.ReadLine(), out value);

            } while (!isValid);
            return value;
        }
        static void Main(string[] args)
        {
            
            double x = CheckDouble("Enter first parameter: ");
            double y = CheckDouble("Enter second parameter: ");
            
            Console.WriteLine($"{x} + {y} = {Math.Add(x,y)}");
            Console.WriteLine($"{x} - {y} = {Math.Subtract(x, y)}");
            Console.WriteLine($"{x} * {y} = {Math.Multiply(x, y)}");
           //if(Math.Divide(x,y) != double.NaN)
            Console.Write($"{x} / {y} = ");
            Math.Divide(x, y); 
        }
    }
}
