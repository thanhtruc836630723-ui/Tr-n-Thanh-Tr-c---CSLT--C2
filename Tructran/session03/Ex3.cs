using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Tructran.session03
{
    internal class Ex3
    {
        public static void Main2143(string[] args)
        {
            Console.Write("Nhap nhiet do bat ky: ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            int kevin = celsius + 273;
            int fah = celsius * 9 / 5 + 32;
            Console.WriteLine($"kevin={kevin}");
            Console.WriteLine($"fah={fah}");

            Console.Write("Nhap radius: ");
           double radius = Convert .ToDouble(Console.ReadLine());
           double surface = 4 * Math.PI * radius * radius;
           double volume = 4 / 3 * Math.PI * radius * radius * radius;
            Console.WriteLine($"surface={surface} volume={volume}");

            Console.Write("Nhap so thu nhat: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
            Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
            Console.WriteLine($"{number1} mod {number2} = {number1 % number2}");




        }
        

    }
}
