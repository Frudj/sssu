﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Введите переменную a");
            double a = Convert.ToDouble(Console.ReadLine());

            double z1 = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) / (Math.Cos(a) - Math.Cos(3 * a) + Math.Cos(5 * a));
            double z2 = Math.Tan(3 * a);
            double z3 = Math.Tan(9 * a);
            Console.WriteLine("Результат =" + z1);
            Console.WriteLine("Результат =" + z2);
            Console.WriteLine("Результат =" + z3);
        }
    }
}
