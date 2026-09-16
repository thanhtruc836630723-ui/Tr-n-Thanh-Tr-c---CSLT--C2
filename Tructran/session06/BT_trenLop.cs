using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Sockets;
using System.Text;

namespace CSLT1.session06
{
    internal class BT_trenLop
    {
        public static int TimGiaTriLonNhat(int a, int b, int c)
        {
            //1.1Viết hàm C# để tìm giá trị lớn nhất của ba số.
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
          
            return Math.Max(a, Math.Max(b, c));
            Console.WriteLine();
        }

        //1.2Cải tiến phiên bản tiếp theo để hàm chấp nhận ít nhất 1 tham số.
        public static int TimGiaTriLonNhatCaiTien(int first, params int[] rest)
        {
            int max = first;
            foreach (int num in rest)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        //2. Hãy viết một hàm C# để tính giai thừa của một số (số nguyên không âm). Hàm này nhận số đó làm tham số.

        public static long CalculateFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Giai thừa không áp dụng số âm.");
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        //3. Viết một hàm C# nhận vào một số làm tham số và kiểm tra xem số đó có phải là số nguyên tố hay không.
        static bool IsPrimeNumber(int num)
        {
            if (num <= 2) return false;
            for (int i = 2; i <= num % 2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;


        }


        //4.1. In tất cả các số nguyên tố nhỏ hơn một số cho trước 
        static void PrintPrimeNumbersUnderN(int n)
        {
            for (int i = 2; i <n;i++)
            {
                if (IsPrime(i))
                    Console.Write($"{i}, ");
            }
        }

        //4.2. In N số nguyên tố đầu tiên.
        static void PrintFirstNPrimeNumbers(int n)
        {
            int dem = 0;
            int num = 2;
            while (dem < n)
            {
                if (IsPrime(num))
                {
                    Console.Write($"{num}, ");
                    dem++;
                }
            }
            num++;
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số thứ nhất a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba: ");
            int c = int.Parse(Console.ReadLine());

            int kq = TimGiaTriLonNhat(a, b, c);
            Console.WriteLine($"Số lớn nhất trong 3 số bạn nhập là số {kq} " );

            Console.Write("Nhập số n: " );
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + "! = " + CalculateFactorial(n));

            Console.Write("Nhập số bạn muốn kiểm tra có là số nguyên tố hay không: ");
            int num = int.Parse(Console.ReadLine());
            if (IsPrimeNumber(num))
            {
                Console.WriteLine($"Số {num} là số nguyên tố");
            }
            else
            {
                Console.WriteLine($"Số {num} không phải là số nguyên tố");
            }
            Console.WriteLine();

            Console.Write("Nhập số n bất kỳ: ");
            int so = int.Parse(Console.ReadLine());
            Console.WriteLine($"Các số nguyên tố nhỏ hơn {so}");
            PrintPrimeNumbersUnderN(so);
            Console.WriteLine();
            Console.WriteLine($"{num} số nguyên tố đầu tiên");
            PrintFirstNPrimeNumbers(num);








        }
    }
}
