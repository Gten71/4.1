// задание 4.1 базовый 
using System;
namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[15];
            Random rand = new Random();

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rand.Next(16);
            }
            int min = n[0];
            int max = n[0];

            for (int i = 0; i < n.Length; i++)
            {
                if (max < n[i])
                {
                    max = n[i];
                }
                if (min > n[i])
                {
                    min = n[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            int a = 0;
            int b = 0;
            a = max + min;
            b = max - min;
            Console.WriteLine("Сумма: " + a);
            Console.WriteLine("Разность:"+b);
        }
    }
}
