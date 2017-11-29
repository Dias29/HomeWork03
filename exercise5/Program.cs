using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число для конвертации(N>0):");
                string N = Console.ReadLine();
                if (Convert.ToInt32(N) < 0)
                {
                    Console.WriteLine("Не соблюдено условие N>0");
                    return;
                }

                Console.WriteLine("Полученное число");
                for (int i = N.Length - 1; i >= 0; i--)
                {
                    Console.Write(N[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
