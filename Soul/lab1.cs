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
                Console.WriteLine("Введите дату рождения: ");
                string text = Console.ReadLine();
                int years = Convert.ToInt32(text);
                if (years > 2019)
                {
                    Console.WriteLine("Что-то я не вижу рядом машину времени");
                             
            }
                else if (years > 2010)
            {
                Console.WriteLine("Какой ты малыш");
            }
            else if (years > 2000)
            {
                Console.WriteLine("Привет, школьник");
            }
                else
            {
                Console.WriteLine("Оууу, девяностые");
            }

                Console.ReadKey();
        }
    }