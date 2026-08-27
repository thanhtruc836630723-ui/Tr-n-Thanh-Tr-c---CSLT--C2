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
            decimal csd_cu = Convert.ToDecimal(Console.ReadLine());
            decimal csd_moi;
            do
            {
                Console.Write("Nhập chỉ số điện mới (kwh): ");
                csd_moi = Convert.ToDecimal(Console.ReadLine());
                if (csd_moi < csd_cu)
                {
                    Console.WriteLine("Chỉ số điện mới phải lớn hơn chỉ số điện cũ. Vui lòng nhập lại.");
                }
            } while (csd_moi < csd_cu);
            decimal soDien = csd_moi - csd_cu;
            decimal tempSoDien = soDien; // Biến tạm dùng để khấu trừ theo bậc
            const decimal BAC_1 = 1806m;
            const decimal BAC_2 = 1866M;
            const decimal BAC_3 = 2167;
            const decimal BAC_4 = 2729;
            const decimal BAC_5 = 3050;

            decimal tienChuaThue = 0m;

            if (tempSoDien > 50)
            {
                tienChuaThue += 50 * BAC_1;
                tempSoDien -= 50;
            }
            else
            {
                tienChuaThue += tempSoDien * BAC_1;
                tempSoDien = 0;
            }
            if (tempSoDien > 50)
            {
                tienChuaThue += 50 * BAC_2;
                tempSoDien -= 50;
            }
            else
            {
                tienChuaThue += tempSoDien * BAC_2;
                tempSoDien = 0;
            }
            if (tempSoDien > 100)
            {
                tienChuaThue += 100 * BAC_3;
                tempSoDien -= 100;
            }
            else
            {
                tienChuaThue += tempSoDien * BAC_3;
                tempSoDien = 0;
            }
            if (tempSoDien > 100)
            {
                tienChuaThue += 100 * BAC_4;
                tempSoDien -= 100;
            }
            else
            {
                tienChuaThue += tempSoDien * BAC_4;
                tempSoDien = 0;
            }
            if (tempSoDien > 0)
            {
                tienChuaThue += tempSoDien * BAC_5;
            }
            decimal thue = tienChuaThue * 0.08m;
            decimal tongThanhToan = tienChuaThue + thue;
            Console.WriteLine($"Số điện tiêu thụ = {soDien} kwh");
            Console.WriteLine($"Tiền điện chưa thuế = {tienChuaThue:#,##0} VNĐ");
            Console.WriteLine($"Thuế = {thue:#,##0} VNĐ");
            Console.WriteLine($"Tổng thanh toán = {tongThanhToan:#,##0} VNĐ");
        }
        static void Bai_2()
        {
            //Bài 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe
            Console.WriteLine("            ");
            Console.Write("Nhập cân nặng (kg): ");
            double canNang = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều cao (m): ");
            double chieuCao = double.Parse(Console.ReadLine());

            double BMI = canNang / Math.Pow(chieuCao, 2);
            double canNangMin = 18.5 * Math.Pow(chieuCao, 2);
            double canNangMax = 24.9 * Math.Pow(chieuCao, 2);
            string phanLoai = "";
            if (BMI < 18.5)
            {
                phanLoai = "Thiếu cân";
            }
            else if (BMI < 23.0)
            {
                phanLoai = "Bình thường";
            }
            else if (BMI < 25.0)
            {
                phanLoai = "Thừa cân";
            }
            else
            {
                phanLoai = "Béo phì";
            }
            Console.WriteLine($"Chỉ số BMI của bạn là: {BMI:F2}");
            Console.WriteLine($"Phân loại: {phanLoai}");
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {canNangMin:F2} kg đến {canNangMax:F2} kg. ");
        }
        //Khai báo enum CurrencyType (bắt đầu từ 1 để khớp với menu lựa chọn)
        enum CurrencyType
        {
            USD = 1,
            EUR = 2,
            JPY = 3,
            GBP = 4,
        }
        static void Bai_3()
        {
            //Bài 3: Ứng Dụng Quy Đổi Tiền Tệ Ngoại Tệ Đa Tỷ Giá Ngân Hàng 
            Console.WriteLine("           ");
            Console.Write("Nhập số tiền VNĐ:");
            decimal tienVND = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Chọn ngoại tệ bạn muốn quy đổi (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            CurrencyType LoaiNgoaiTe = (CurrencyType)choice;
            const decimal tyGiaUSD = 25400m;
            const decimal tyGiaEUR = 27200m;
            const decimal tyGiaJPY = 165m;
            const decimal tyGiaGBP = 32100m;

            decimal Phidv = tienVND % 0.005m;
            decimal soTienQuyDoi = tienVND - Phidv;
            decimal soTienNgoaiTe = 0m;
                switch (LoaiNgoaiTe)
                {
                    case CurrencyType.USD:
                        soTienNgoaiTe = tyGiaUSD;
                        break;
                    case CurrencyType.EUR:
                        soTienNgoaiTe = tyGiaEUR;
                        break;
                    case CurrencyType.JPY:
                        soTienNgoaiTe = tyGiaJPY;
                        break;
                    case CurrencyType.GBP:
                        soTienNgoaiTe = tyGiaGBP;
                        break;
                    default:
                        Console.WriteLine("Bạn chọn ngoại tệ không hợp lệ. Vui lòng chọn lại (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
                        break;
                    
                }


        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();
            Bai_3();

            Console.ReadKey();
            
           
        }
    }
}
