namespace ThirdProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration d1 = new Duration(1, 59, 15);
            Console.WriteLine(d1);
            Duration d2 = new Duration(3600);
            Console.WriteLine(d2);
            Duration d3 = new Duration(7800);
            Console.WriteLine(d3);
            Duration d4 = new Duration(666);
            Console.WriteLine(d4);
            Duration d5 = d1 + d2;
            Console.WriteLine(d5);
            Duration d6 = 566 + d2;
            Console.WriteLine(d6);
            d1++;
            Console.WriteLine( "d1++: "+ d1);


        }
    }
}
