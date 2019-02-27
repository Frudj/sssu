using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите размер массива ");
            int N = int.Parse(Console.ReadLine());
            double[] Mass = new double[N];



            Console.WriteLine("Выберите ручной или автоматический вариант заполнения массива");
            Console.WriteLine(" 1 - Ручной ввод\n 2 - Автоматический ввод");
        swVVOD:
            int vvod = int.Parse(Console.ReadLine());
            switch (vvod)
            {
                case 1:
                    {
                        Console.Write("Введите элементы массива\n\n");
                        for (int i = 0; i < N; i++)
                        {
                            Mass[i] = double.Parse(Console.ReadLine());
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("\nИсходный массив\n\n");
                        for (int i = 0; i < N; i++)
                        {
                            Mass[i] = (double)(rnd.NextDouble() * rnd.Next(-5, 5));
                            Console.Write("{0} ", Mass[i]);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Нужно ввести 1 или 2!!!");
                        goto swVVOD;
                    }
            }


            double nechetSum = 0;
            for (int i = 1; i < N; i += 2)
            {
                nechetSum += Mass[i];
            }
            Console.WriteLine("\n\nСумма нечетных элементов = {0}", nechetSum.ToString());



            double SumMejdu = Mass.SkipWhile(r => r >= 0).Skip(1).Reverse().SkipWhile(r => r >= 0).Skip(1).Sum();
            Console.WriteLine("\nСумма элементов между отрицательными элементами = {0}\n", SumMejdu.ToString());


            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(Mass[i]) < 1) Mass[i] = 0;
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (Mass[i] == 0)
                    {
                        Mass[i] = Mass[j];
                        Mass[j] = 0;
                    }
                    else break;
                }

            }
            Console.WriteLine("Измененный массив\n");
            foreach (double i in Mass) Console.Write("{0} ", i);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
