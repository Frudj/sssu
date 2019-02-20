using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в тест");
                Console.WriteLine("Введите своё имя: ");
                string text = Console.ReadLine();
                                
            switch (text)
            {
                case "артем":
                    Console.WriteLine("что-то");
                    break;
                case "сергей":
                    Console.WriteLine("Эххх");
                    break;
                case "Сергей":
                    Console.WriteLine("Супер");
                    break;
                case "вячеслав":
                    Console.WriteLine("Каефный");
                    break;
                case "Артем":
                    Console.WriteLine("Наес");
                    break;
                case "Роман":
                    Console.WriteLine("Бог");
                    break;
                default:
                    Console.WriteLine("Поздравляем ^_^ ");
                    break;

            }

                Console.ReadKey();
        }
    }
}