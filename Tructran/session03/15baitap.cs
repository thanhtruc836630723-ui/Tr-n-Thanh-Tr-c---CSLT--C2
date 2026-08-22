using System;
using System.Collections.Generic;
using System.Text;

namespace Tructran.session03
{
    internal class _15baitap
    {
        static void Bai_1()
        {
            //Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang(EVN)

            Console.Write("Nhập chỉ số điện cũ (kwh): ");
            int csd_cu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập chỉ số điện mới (kwh): ");
            int csd_moi = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (csd_moi < csd_cu)
                {
                    Console.WriteLine("Chỉ số điện mới phải lớn hơn chỉ số điện cũ. Vui lòng nhập lại.");
                    Console.Write("Nhập chỉ số điện mới (kwh): ");
                    csd_moi = Convert.ToInt32(Console.ReadLine());
                }
                else;
                    
            } while (true) ;
            float tieuthu = csd_moi - csd_cu;
            float dongia = 3059f;
            decimal tienDien = (decimal)(tieuthu * dongia);
            decimal vat = (decimal)(tieuthu * 0.08f);
       

            Console.WriteLine($"Số điện tiêu thụ = {tieuthu} (kwh)");
            Console.WriteLine($"Tiền điện chưa tính thuế = {tienDien} (VNĐ)");
            Console.WriteLine($"Thuế VAT = {vat} (VNĐ)");
           
        }
        static void Bai_2()
        {
            //Bài 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe

        }

        public static void Main2122(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Bai_1();

            
           
        }
    }
}
