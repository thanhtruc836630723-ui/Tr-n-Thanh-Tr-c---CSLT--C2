using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tructran
{
    internal class Ex_1
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int number1 = 10, number2 = 16;
            //1.to Add / Sum Two Numbers.
            int sum = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {sum}");

            //2.to Swap Values of Two Variables
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"Afer swapping: number1 = {number1}, number2 = {number2}");

            //3.to Multiply two Floating Point Numbers
            float float1 = 5.5f;
            float float2 = 2.2f;
            float product = float1 * float2;
            Console.WriteLine($"{float1} * {float2} = {product}");
            //4.to convert feet to meter
            float feet = 16.7f;
            float rate = 0.3048f;
            float meter = feet * rate;
            Console.WriteLine($"{feet} feet = {meter} meters");

            //5.to convert Celsius to Fahrenheit and vice versa
            Console.Write("Nhập nhiệt độ Celsius: ");
            float cel = Convert.ToSingle(Console.ReadLine());
            float fahrenheit = (cel * 9 / 5) + 32;
            Console.WriteLine($"{cel}°C = {fahrenheit}°F");
            Console.Write("Nhập nhiệt độ Fahrenheit bất kỳ: ");
            float fah = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"{fah}°F = {(fah - 32) * 5 / 9}°C");

            //6.to find the Size of data types

            //7.to Print ASCII Value(tip: read character, print number of this char)
            //8.to Calculate Area of Circle
            Console.Write("Nhập bán kính bất kỳ: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Diện tích hình tròn= {area}");
            //9.to Calculate Area of Square
            Console.Write("Nhập cạnh hình vuông bất kỳ: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double squareArea = side * side;
            Console.WriteLine($"Diện tích hình vuông = {squareArea}");

            //10.to convert days to years, weeks and days
            Console.Write("Nhập số ngày bất kỳ: ");
            int days = Convert.ToInt32(Console.ReadLine());
            int years = days / 365;
            int weeks = days / 7;
            Console.WriteLine($"years = {years} năm, weeks = {weeks} tuần");

        }
    }
}
