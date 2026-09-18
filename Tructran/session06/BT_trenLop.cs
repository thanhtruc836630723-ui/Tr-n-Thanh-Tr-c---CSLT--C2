using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Sockets;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT1.session06
{
    internal class BT_trenLop
    {
         static int TimGiaTriLonNhat(int a, int b, int c)
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
        static int TimGiaTriLonNhatCaiTien(int first, params int[] rest)
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
            if (num < 2) 
                return false;
            for (int i = 2; i * i < num ; i++)
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
                if (IsPrimeNumber(i))
                    Console.Write($"{i}, ");
            }
        }

        //4.2. In N số nguyên tố đầu tiên.
        static void PrintFirstNPrimeNumbers(int numPrime)
        {
            int dem = 0;
            int num = 2;
            while (dem < numPrime)
            {
                if (IsPrimeNumber(numPrime))
                {
                    Console.Write($"{numPrime}, ");
                    dem++;
                }
                numPrime++;
            }
            
        }

        //5. Hãy viết một hàm C# để kiểm tra xem một số có phải là số hoàn hảo hay không. Sau đó, in ra tất cả các số hoàn hảo nhỏ hơn 1000.
        static bool IsPerfect(int soHoanHao)
        {
            if (soHoanHao < 2)
                return false;
            int sum = 1;
            for (int i = 2; i * i <= soHoanHao ; i++)
            {
                if (soHoanHao % i == 0 )
                {
                    sum += i;
                    int pair = soHoanHao / i;
                    if (pair != i)
                        sum += pair;
                }
              
            }
            return sum == soHoanHao;
        }

        //Viết một hàm C# để kiểm tra xem một chuỗi có phải là pangram hay không.
        //(Lưu ý: Pangram là từ hoặc câu chứa ít nhất một chữ cái trong bảng chữ cái.)

        static bool IsPangram( string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;
            bool[] mark = new bool[26];

            // Biến đếm số lượng chữ cái duy nhất đã tìm thấy
            int uniqueLetterCount = 0;

            // Duyệt qua từng ký tự trong chuỗi
            foreach (char c in text)
            {
                int index = -1;

                // Kiểm tra xem ký tự là chữ thường hay chữ hoa để quy về index từ 0 đến 25
                if (c >= 'a' && c <= 'z')
                {
                    index = c - 'a';
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    index = c - 'A';
                }

                // Nếu là chữ cái hợp lệ và chưa từng xuất hiện (mark[index] == false)
                if (index != -1 && !mark[index])
                {
                    mark[index] = true; // Đánh dấu là đã xuất hiện
                    uniqueLetterCount++; // Tăng biến đếm

                    // TỐI ƯU: Nếu đã tìm đủ 26 chữ cái thì thoát và trả về true ngay lập tức
                    if (uniqueLetterCount == 26)
                    {
                        return true;
                    }
                }
            }

            return false;


        }


        public static void Main12(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số thứ nhất: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba: ");
            int c = int.Parse(Console.ReadLine());

            int kq = TimGiaTriLonNhat(a, b, c);
            Console.WriteLine($"Số lớn nhất trong 3 số bạn nhập là số {kq} " );

            Console.Write("Nhập số n: " );
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n}! = {CalculateFactorial(n)}");

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

            Console.Write("Nhập N: ");
            int numPrime = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numPrime} số nguyên tố đầu tiên");
            PrintFirstNPrimeNumbers(numPrime);
            Console.WriteLine();

            Console.WriteLine("Các số hoàn hảo bè hơn 1000");
            for (int soHoanhao = 1; so <1000; so++)
            {
                if (IsPerfect(so))
                    Console.Write($"{soHoanhao}, ");
            }

            Console.WriteLine();

            Console.Write("Nhập vào một câu tiếng Anh để kiểm tra: ");
            string inputStr = Console.ReadLine();
            if (IsPangram(inputStr))
            {
                Console.WriteLine("=> Đây LÀ một câu Pangram.");
            }
            else
            {
                Console.WriteLine("=> Đây KHÔNG PHẢI là câu Pangram.");
            }

            Console.ReadLine();










        }
    }
}
