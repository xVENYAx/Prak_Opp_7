using System;

namespace Арифметична_прогресія
{
    class Program
    {
        static uint ArithmeticProgression(uint n)
        {
            if (n == 0)
            {
                return 1;
            }
            return ArithmeticProgression(n - 1) + 1;
        }

        static void Main(string[] args)
        {
            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            for (uint i = 0; i < n; i++)
            {
                Console.WriteLine(ArithmeticProgression(i));
            }

            Console.ReadLine();
        }
    }
}
