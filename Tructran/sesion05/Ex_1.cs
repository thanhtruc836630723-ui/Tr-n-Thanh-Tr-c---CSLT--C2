using System;
using System.Collections.Generic;
using System.Text;

namespace Tructran.sesion05
{
    internal class Ex_1
    {
   
        static void BangCuuChuong()
        {
            for (int i = 10; i < 20; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($" {i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
  
         
        }
        static void GameRandom()
        {
            Random rnd = new Random();
            int com_num = rnd.Next(10) + 1;
            
            for (int a= 0; a < 10; a++)
            {
                Console.Write(" Bạn chọn số mấy? " );
                int user_num = int.Parse(Console.ReadLine());
                if (user_num == com_num)
                {
                    Console.WriteLine("Yaassss! Đúng òi =))");
                    break;
                } else if (user_num < com_num )
                {
                    Console.WriteLine("Số bạn chọn bé hơn số máy chọn");
                }
                else if (user_num > com_num )
                {
                    Console.WriteLine("Số bạn chọn lớn hơn số máy chọn");
                }
 
            }
            Console.WriteLine( );
        }

        static void Bai_1()
        {
            //Viết chương trình kiểm tra xem một tam giác là tam giác đều, tam giác cân hay tam giác thường.
            Console.Write(" Nhập cạnh a: " );
            double a = double.Parse(Console.ReadLine());
            Console.Write(" Nhập cạnh b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write(" Nhập cạnh c: " );
            double c = double.Parse(Console.ReadLine());

                if (a == b && a == c && b == c && a + b > c)
                {
                    Console.WriteLine(" Đây là tam giác đều");
                }
                else if (a == c || a == b | b == c && a + b >c)
                {
                    Console.WriteLine(" Đây là tam giác cân");
                }
                else
                {
                    Console.WriteLine(" Đây là tam giác thường");
                }

        }

        static void Bai_2()
        {
            //Viết chương trình đọc 10 số, sau đó tính tổng và giá trị trung bình của chúng.
            double sum = 0;
            for (int e = 1; e < 20; e++)
            {
                Console.WriteLine("Nhập số thứ {i}: ");
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }
            double averange = sum / 20;
            Console.WriteLine($"Tổng của các số ở trên = {sum}");
            Console.WriteLine($"Trung bình cộng của các số trên = {averange}");
        }

        static void Bai_4_5()
        {
            //Hãy viết chương trình hiển thị một hình mẫu dạng tam giác sử dụng các con số.

            //Dạng 1
            int rows = 4;
            for ( int k = 1; k <= rows; k++)
            {
                for (int m = 1; m <= k; m++)
                {
                    Console.Write(m);
                }
                Console.WriteLine( );
            }
            Console.WriteLine( );

            //Dạng 2
            int val = 1;
            for ( int n = 1; n  < rows; n++)
            {
                for (int f = 1; f <= n; f++)
                {
                    Console.Write(val + " ");
                    val++;
                }
                Console.WriteLine( );
            }

            //Dạng 3
            for (int o = 1; o <= rows; o++)
            {
                for (int space = 1; space <= rows - o; o++)
                {
                    Console.Write(" " );
                }
                for (int o1 = 1; o1 <= o; o1++)
                {
                    Console.Write(val + " " );
                    val++;
                }
                Console.WriteLine();
            }
          


         
        }
        static void Bai_6()
        {
           // Hãy viết chương trình hiển thị n số hạng của chuỗi điều hòa và tổng của chúng: 1 + 1/2 + 1/3 + 1/4 + 1/5 + ... + 1/n.
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //BangCuuChuong();
            //GameRandom();
            //Bai_1();
            //Bai_2();
            Bai_4_5();
            Bai_6();
        }
    }
}
