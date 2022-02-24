using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            IntNumber number = new IntNumber(5);

            number.Display();

            number.Number = 25;
            number.Display();

            int t;
            t = number.Number;
            Console.WriteLine("t = {0}", t);
        }
    }
}