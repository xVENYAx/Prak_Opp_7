using System;

namespace Переворот_рядка
{
    class Program
    {
        static string Reverse(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            return Reverse(s.Substring(1)) + s[0].ToString();
        }


        static void Main(string[] args)
        {
            Console.Write("Введіть рядок: ");
            var inputText = Console.ReadLine();
            Console.WriteLine("Перевернутий рядок: " + Reverse(inputText));
            Console.ReadLine();
        }
    }
}
