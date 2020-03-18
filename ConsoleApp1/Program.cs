using System;

namespace ConsoleApp1
{
    public class IProgram
    {
        public static int sumThis(int first, int second)
        {
            return first + second;
        }

        public static double divThis(double first, double second)
        {
            return first / second;
        }

        public static double multThis(double first, double second)
        {
            return first * second;
        }

        static void Main(string[] args)
        {
            
            int a = sumThis(2, -3);
            double b = divThis(17, 2);
            double c = multThis(a, b);
            string res = "a = " + a + "\nb = " + b + "\nc = " + c;
            Console.WriteLine(res);
        }
    }
}
