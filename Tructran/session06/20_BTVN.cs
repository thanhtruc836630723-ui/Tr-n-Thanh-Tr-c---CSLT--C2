using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT1.session06
{
    internal class _20_BTVN
    {
        //Bài 1: Tính tổng hai số nguyên
        static int TinhTong(int a, int b)
        {
            return a+b;
        }

        //Bài 2: Kiểm tra số chẵn lẻ
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        //Bài 3: Tìm số lớn nhất trong ba số
        static int TimMax(int x, int y, int z)
        {
            return Math.Max(Math.Max(x, y), z);
        }

        //Bài 4: Tính giai thừa của một số
        static long TinhGiaiThua(int so)
        {
            for (so = 1; so <  )
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bài 1
            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tổng a + b = {a + b}");
            Console.WriteLine();

            //Bài 2
            Console.Write("Nhập 1 số bất kỳ bạn muốn kiểm tra chẵn hay lẻ: " );
            int n = int.Parse(Console.ReadLine());
            if (KiemTraChan(n))
                Console.WriteLine($"{n} là số chẵn");
            else
                Console.WriteLine($"{n} là số lẻ" );
            Console.WriteLine();

            //Bài 3
            Console.Write("Nhập số thứ nhất: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba: ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine($"Số lớn nhất trong 3 số là {Math.Max(Math.Max(x, y), z)}");
            Console.WriteLine();

            //Bài 4
        }
    }
}
