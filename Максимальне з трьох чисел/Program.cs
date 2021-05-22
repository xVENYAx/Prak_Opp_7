using System;

namespace Максимальне_з_трьох_чисел
{
    class Program
    {
        static float Maximum(float x, float y)
        {
            if (x > y)
                return x;
            else
                return y;
        }

        static float Maximum(float x, float y, float z)
        {
            var max = Maximum(x, y);
            if (max > z)
                return max;
            else
                return z;
        }

        static void Main(string[] args)
        {
            Console.Write("Введіть перше число: ");
            var f1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            var f2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введіть третє число: ");
            var f3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Максимальне з трьох чисел {Maximum(f1, f2, f3)}");
            Console.ReadLine();
        }
    }
}
