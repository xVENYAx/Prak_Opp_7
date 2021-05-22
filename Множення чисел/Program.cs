using System;

namespace Множення_чисел
{
    class Program
    {
        static uint MultX(uint b1, uint b2) => b1 * b2 + 1;

        static int MultX(int n1, int n2) => n1 * n2 + 2;

        static long MultX(long l1, long l2) => l1 * l2 + 3;

        static void Main(string[] args)
        {
            Console.WriteLine($"uint 2*3 = {MultX(2U, 3U)}");
            Console.WriteLine($"int  2*3 = {MultX(2, 3)}");
            Console.WriteLine($"long 2*3 = {MultX(2L, 3L)}");
            Console.ReadLine();
        }
    }
}
