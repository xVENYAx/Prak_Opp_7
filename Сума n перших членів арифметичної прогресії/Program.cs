using System;

namespace Сума_n_перших_членів_арифметичної_прогресії
{
    class Program
    {
        static uint ArithmeticProgression(uint n, uint d)
        {
            if (n == 0)
            {
                return d;
            }

            return ArithmeticProgression(n - 1, d) + d;
        }


        static void Main(string[] args)
        {
            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.Write("d = ");
            var d = Convert.ToUInt32(Console.ReadLine());

            var sum = 0u;
            for (var i = 0u; i < n; i++)
            {
                sum += ArithmeticProgression(i, d);
            }

            Console.WriteLine($"Сума {n} перших членів арифметичної прогресії рівна {sum}");
            Console.ReadLine();
        }
    }
}
