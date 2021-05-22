using System;

namespace Prak_Opp_7
{
    class Program
    {
        
        static int Summa(int a, int b = 0, int c = 0)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("700 + 70 + 7 = " + Summa(700, 70, 7));
            Console.WriteLine("int Summa(int a, int b = 0, int c = 0)");
            Console.WriteLine("{");
            Console.WriteLine("    return a + b + c;");
            Console.WriteLine("}");
            Console.WriteLine("Визначіть сигнатуру приведеного методу:");
            Console.WriteLine("Summa(int, int, int)");
        }
    }
}
