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
            long kq = 1;
            for (int i = 1; i <= so; i++ )
            {
                kq *= i;
            }
            return kq;
        }

        //Bài 5: Đảo ngược chuỗi ký tự
        static string DaoNguocChuoi(string input)
        {
            char[] chuoi = input.ToCharArray();
            Array.Reverse(chuoi);
            return new string(chuoi);
        }

        //Bài 6: Kiểm tra số nguyên tố
        static bool KiemTraSoNguyenTo(int num)
        {
            if (num < 2 )
                return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        //Bài 7: In dãy Fibonacci
        static void InDayFibonacci(int number)
        {
            int u = 0;
            int e = 1;
            for (int i = 0; i < number; i++)
            {
                Console.Write(u);
                if (i < number - 1)
                    Console.Write(", ");
                int h = u + e;
                u = e;
                e = h;
            }
        }

        //Bài 8: Đếm số lượng nguyên âm trong chuỗi
        static int DemNguyenAm(string s)
        {
            int dem = 0;
            foreach(char c in s.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'u' || c == 'o')
                {
                    dem++;
                }

            }
            return dem;
        }

        //Bài 9: Tính lũy thừa
        static double TinhLuyThua(double d, int l)
        {
            double ketqua = 1;
            for (int i = 0; i < l; i++)
            {
                ketqua *= d;
            }
            return ketqua;
        }

        //Bài 10: Tính điểm trung bình của mảng
        static double TinhTrungBinh(int[] arr)
        {
            double tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tong += arr[i];
            }
            return (double)tong / arr.Length;
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
            Console.Write("Chọn số bạn thích: ");
            int so = int.Parse(Console.ReadLine());
            Console.WriteLine($"{so}! = {TinhGiaiThua(so)}");
            Console.WriteLine();

            //Bài 5
            Console.Write("Viết 1 câu bạn nghĩ ra: " );
            string input = Console.ReadLine();
            Console.WriteLine($"Đảo ngược lại câu là {DaoNguocChuoi(input)}");
            Console.WriteLine();

            //Bài 6
            Console.Write("Nhập số bạn muốn kiểm tra có phải là số nguyên tố hay không: ");
            int num = int.Parse(Console.ReadLine());
            if (KiemTraSoNguyenTo(num))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.WriteLine();

            //Bài 7
            Console.Write("Nhập số bất kỳ: " );
            int number = int.Parse(Console.ReadLine());
            Console.Write("Dãy Fibonacci: " );
            InDayFibonacci(number);
            Console.WriteLine();

            //Bài 8
            Console.Write("Nhập câu/ từ: " );
            string s = Console.ReadLine();
            Console.WriteLine($"Số nguyên âm có trong câu/ từ là: {DemNguyenAm(s)}" );
            Console.WriteLine();

            //Bài 9
            Console.Write("Nhập số bạn muốn tính lũy thừa: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Nhập số mũ: ");
            int l = int.Parse(Console.ReadLine());
            double ketqua = TinhLuyThua(d, l);
            Console.WriteLine($"Lũy thừa của {d}^{l} là {ketqua}");
            Console.WriteLine();

            //Bài 10
            // Bài 10
            Console.Write("Nhập số lượng phần tử: ");
            int  phantu= int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            double ketQua = TinhTrungBinh(arr);
            Console.WriteLine("Điểm trung bình = " + ketQua);
            Console.WriteLine();



        }
    }
}
