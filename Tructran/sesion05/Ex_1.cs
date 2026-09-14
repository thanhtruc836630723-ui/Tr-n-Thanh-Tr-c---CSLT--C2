using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            bool continue_play = true;
            int dem_thang = 0;int tong_so_van_choi = 0;
         
            do
            {
                int com_num = rnd.Next(100) + 1;
                int so_lan_doan = 0;

                Console.Write("Hãy chọn level bạn muốn nè <1-dễ, 2-cũng cũng, 3-khó> : ");
                int level = int.Parse(Console.ReadLine());
      

                switch (level)
                {
                    case 1:
                        so_lan_doan = 10;
                        break;
                    case 2:
                        so_lan_doan = 7;
                        break;
                    case 3:
                        so_lan_doan = 5;
                        break;
                    default:
                        Console.WriteLine("Ban đã chọn level không hợp lệ! Không cho chơi :))");
                        continue_play = false;
                        break;
                }
                Console.WriteLine($"Bạn có {so_lan_doan} lần đoán số từ 1- 100");
                Console.WriteLine();
                tong_so_van_choi++;
                bool thang = false;

                for (int a = 0; a < so_lan_doan ; a++)
                {
                    Console.Write("Bạn chọn số mấy nè? ");
                    int user_num = int.Parse(Console.ReadLine());
                    if (user_num == com_num)
                    {
                        dem_thang++;
                        Console.WriteLine("Yaassss! Đúng òi =))");
                        Console.WriteLine($"Bạn đã thắng sau {a + 1} lần chơi");
                        break;
                    }
                    else if (user_num < com_num)
                    {
                        Console.WriteLine("Số bạn chọn bé hơn số máy chọn");
                    }
                    else if (user_num > com_num)
                    {
                        Console.WriteLine("Số bạn chọn lớn hơn số máy chọn");
                    }
                }
                Console.WriteLine($"Số máy chọn là: {com_num}");

                Console.Write("Bạn muốn chơi tiếp nữa không? <c/k>: ");
                string tl = Console.ReadLine();
                if (tl.ToLower() == "c")
                    continue_play = true;
                else continue_play = false;                           
              

            } while (continue_play);



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
            int dem = 1;
            for ( int n = 1; n  < rows; n++)
            {
                for (int f = 1; f <= n; f++)
                {
                    Console.Write(dem + " ");
                    dem++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Dạng 3

            int dem3 = 1;
            for (int g = 1; g <= rows; g++)
            {
                for (int space = 1; space <= rows - g; space++)
                {
                    Console.Write(" ");
                }

                for (int p =1; p <= g; p++ )
                {
                    Console.Write(dem3 + " ");
                    dem3++;
                }

                Console.WriteLine();
                
            }


         
        }
        static void Bai_6()
        {
           // Hãy viết chương trình hiển thị n số hạng của chuỗi điều hòa và tổng của chúng: 1 + 1/2 + 1/3 + 1/4 + 1/5 + ... + 1/n.
        }
        static void Bai_7()
        {
            //Viết chương trình để tìm các số "hoàn hảo" trong một phạm vi số cho trước.
            Console.Write(" Nhập số cần kiểm tra: " );
            int so = int.Parse(Console.ReadLine());

            int tong = 0;
            for (int i = 1; i <= so/2; i++)
            {
                if (so % i == 0)
                    tong += i;
            }

            if (tong == so)
            {
                Console.Write($"Số {so} là số hoàn thiện" );
            }else
                Console.WriteLine($"Số {so} KHÔNG là số hoàn thiện" );
        }

        static void Bai_8()
        {
            //Hãy viết chương trình xác định xem một số cho trước có phải là số nguyên tố hay không.
            Console.Write("Nhập số cần kiểm tra: " );
            int sckt = int.Parse(Console.ReadLine());

            bool kt = true; 
            for (int i = 2; i <= sckt/2; i++)
            {
                if ( sckt % i == 0)
                {
                    kt = false;
                    break;
                }
            if (kt)
                {
                    Console.WriteLine($"Số {sckt} là số nguyên tố");
                }
            else
                {
                    Console.WriteLine($"Số {sckt} kHÔNG là số nguyên tố");
                }
              
            }
        }

        static void Bai_in_N_snt_dautien()
        {

        }
        public static void Main44444(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //BangCuuChuong();
            //GameRandom();
            //Bai_1();
            //Bai_2();
            //Bai_4_5();
            Bai_6();
            //Bai_7();
            Bai_8();
            Bai_in_N_snt_dautien();

        }
    }
}
