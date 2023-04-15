using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace работа_с_простыми_числами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // на тройбан

            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            bool isProst = true;

            if (num == 1 || num == 0)
            {
                isProst = false;
            }

            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isProst = false;
                        break;
                    }
                }
            }

            if (isProst)
            {
                Console.WriteLine("Число простое");
            }

            else
            {
                Console.WriteLine("Число составное");
            }

            // на четверыч

            Console.WriteLine();
            Console.WriteLine("Ищем простые числа в диапазоне 2-X (1 не является ни простым числом ни составным)");
            Console.Write("Введите число X: ");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"Простые числа в диапазоне от 2 до {x}: ");

            for (int q = 2; q <= x; q++)
            {
                bool isProst2 = true;
                for (int j = 2; j <= Math.Sqrt(q); j++)
                {
                    if (q % j == 0)
                    {
                        isProst2 = false;
                        break;
                    }
                }

                if (isProst2)
                {
                    Console.WriteLine(q);
                }
            }

            Console.ReadLine();
        }
    }
}
