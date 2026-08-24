using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Tructran.session03
{
    internal class _15baitap
    {
        static void Bai_1()
        {
            //Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang(EVN)

            Console.Write("Nhập chỉ số điện cũ (kwh): ");
            decimal csd_cu = decimal.Parse(Console.ReadLine());
            Console.Write("Nhập chỉ số điện mới (kwh): ");
            decimal csd_moi = decimal.Parse(Console.ReadLine());
            do
            {
                if (csd_moi < csd_cu)
                {
                    Console.WriteLine("Chỉ số điện mới phải lớn hơn chỉ số điện cũ. Vui lòng nhập lại.");
                    Console.Write("Nhập chỉ số điện mới (kwh): ");
                    csd_moi = Convert.ToInt32(Console.ReadLine());
                }
                    
            } while (true) ;
            decimal soDien = csd_moi - csd_cu;
            decimal tempSoDien = soDien; // Biến tạm dùng để khấu trừ theo bậc
            const decimal BAC_1 = 1806m;
            const decimal BAC_2 = 1866M;
            const decimal BAC_3 = 2167;
            const decimal BAC_4 = 2729;
            const decimal BAC_5 = 3050;

            decimal tienChuaThue = 0m;

            if (tempSoDien > 300)
            {
                tienChuaThue += tempSoDien * BAC_5;
            }
            else if (tempSoDien > 200)
                tienChuaThue += tempSoDien * BAC_4;
            else if (tempSoDien > 100)
                tienChuaThue += tempSoDien * BAC_3;
            else if (tempSoDien > 100)
                tienChuaThue += tempSoDien * BAC_2;
            else if (tempSoDien > 50)
                tienChuaThue += tempSoDien * BAC_1;
            {

            }


         
       

        }
        static void Bai_2()
        {
            //Bài 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe

        }

        public static void Main54645(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();

            

            
           
        }
    }
}
