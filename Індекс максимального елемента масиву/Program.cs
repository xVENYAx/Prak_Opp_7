using System;

namespace Індекс_максимального_елемента_масиву
{
    class Program
    {
        static int IndexOfMax(int[] array, int len)
        {
            if (len == 0)
            {
                return len;
            }

            var i = IndexOfMax(array, len - 1);
            return array[len] > array[i] ? len : i;
        }

        static void Main(string[] args)
        {
            var a = new[] { 0, 5, 6, 1, 9, 7, 8, 3, 2, 4 };
            Console.WriteLine("Індекс максимального елемента масиву: " + IndexOfMax(a, a.Length - 1));
            Console.ReadLine();
        }
    }
}
