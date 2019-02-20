using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите число: ");
                string text = Console.ReadLine();
                int x = Convert.ToInt32(text);
                
            switch (x)
            {
                case 1:
                    Console.WriteLine("Число 1");
                    break;
                case 2:
                    Console.WriteLine("Число 2");
                    break;
                case 3:
                    Console.WriteLine("Число 3");
                    break;
                case 4:
                    Console.WriteLine("Число 4");
                    break;
                case 5:
                    Console.WriteLine("Число 5");
                    break;
                case 6:
                    Console.WriteLine("Число 6");
                    break;
                default:
                    Console.WriteLine("Другое число");
                    break;

            }

                Console.ReadKey();
        }
    }
}