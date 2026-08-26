using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Tructran.sesson04
{
    internal class Ex_1
    {
        static void Bai_1()
        {
            //1. Viết chương trình kiểm tra xem một tam giác là tam giác đều, tam giác cân hay tam giác thường.
            Console.Write("Nhập cạnh bên 1: ");
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập cạnh bên 2: ");
            double c2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập cạnh bên 3: ");
            double c3 = Convert.ToDouble(Console.ReadLine());
            
            if ( c1 == c2 && c2 == c3)
            {
                Console.WriteLine("Tam giác này là tam giác đều ");
            }
            else if ( c1 == c2 || c2 == c3 || c1 == c3)
            {
                Console.WriteLine("Tam giác này là tam giác cân "); 
            }
            else
            {
                Console.WriteLine("Tam giác này là tam giác thường");
            }
        }
        static void Bai_2()
        {
            //2. Viết chương trình đọc 10 số, sau đó tính tổng và giá trị trung bình của chúng.
            double sum = 0;
            int count = 10;
            
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Nhập số {i}: ");
                sum += Convert.ToDouble(Console.ReadLine());
            }
            double tb = sum / count;
            Console.WriteLine($"\nSum: {sum}");
            Console.WriteLine($"Trung bình: {tb}");
        }
        static void Bai_3()
        {
            //3. Viết chương trình hiển thị bảng cửu chương của một số nguyên cho trước.
            Console.Write("Nhập số nguyên bất kỳ: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Bảng cửu chương for {n}:");
            for (int i = 1; i <= 10;  i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }
        static void Bai_4()
        {
            //4.Viết chương trình hiển thị một mẫu hình dạng tam giác sử dụng các con số.
            Console.Write("Nhập hàng số bạn muốn: ");
 

        }
        static void Bai_5()
        {

        }
   
        







        public static void Main434333(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Bai_1();
            Bai_2();
            Bai_3();
            Bai_4();
            Bai_5();
          


            Console.Write("\n Nhấn bất kỳ để kết thúc");
            Console.ReadKey();
        }


    }
}
