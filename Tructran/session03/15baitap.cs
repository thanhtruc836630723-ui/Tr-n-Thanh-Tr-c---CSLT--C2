using System;
using System.Collections.Generic;
using System.Globalization;
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

            decimal Phidv = tienVND * 0.005m;
            decimal soTienQuyDoi = tienVND - Phidv;
            decimal tyGia = 0m;
            switch (LoaiNgoaiTe)
            {
                case CurrencyType.USD:
                    tyGia = tyGiaUSD;
                    break;
                case CurrencyType.EUR:
                    tyGia = tyGiaEUR;
                    break;
                case CurrencyType.JPY:
                    tyGia = tyGiaJPY;
                    break;
                case CurrencyType.GBP:
                    tyGia = tyGiaGBP;
                    break;
                default:
                    Console.WriteLine("Bạn chọn ngoại tệ không hợp lệ. Vui lòng chọn lại (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
                    return;
            }
            decimal soTienNgoaiTeNha = soTienQuyDoi / tyGia;
            Console.WriteLine($"Phí dịch vụ = {Phidv:#,##0} VNĐ");
            Console.WriteLine($"Số tiền sẽ được quy đổi = {soTienQuyDoi:#,##0} VNĐ ");
            Console.WriteLine($"Số tiền {LoaiNgoaiTe} nhận được = {soTienNgoaiTeNha:#,##0.00} {LoaiNgoaiTe}");
        }
        static void Bai_4()
        {
            //Bài 4: Tính Tuổi Chính Xác &Đếm Ngược Ngày Sinh Nhật
            Console.WriteLine("                  ");
            Console.Write("Nhập ngày sinh của bạn (dd/MM/yyyy): ");
            string input = Console.ReadLine();
            DateTime ngaySinh;
            bool isValid = DateTime.TryParseExact(
                    input,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out ngaySinh
            );

            // Lấy ngày hiện tại của hệ thống (bỏ qua phần giờ phút giây)
            DateTime ngayHienTai = DateTime.Now.Date;

            if (!isValid || ngaySinh > ngayHienTai)
            {
                Console.WriteLine("Lỗi: Ngày sinh không đúng định dạng dd/MM/yyyy hoặc lớn hơn ngày hiện tại!");
                return;
            }

            // Tính tuổi chính xác
            int tuoi = ngayHienTai.Year - ngaySinh.Year;
            // Nếu trong năm nay chưa tới ngày sinh nhật thì trừ đi 1 tuổi
            if (ngayHienTai < ngaySinh.AddYears(tuoi))
            {
                tuoi--;
            }

            // Tính tổng số ngày đã sống từ lúc sinh ra (dùng TimeSpan)
            TimeSpan daSong = ngayHienTai - ngaySinh;
            int tongSoNgaySong = (int)daSong.TotalDays;

            // Xác định ngày sinh nhật kế tiếp
            DateTime sinhNhatTiepTheo = new DateTime(ngayHienTai.Year, ngaySinh.Month, ngaySinh.Day);
            // Nếu sinh nhật năm nay đã qua, dời sang năm sau
            if (sinhNhatTiepTheo < ngayHienTai)
            {
                sinhNhatTiepTheo = sinhNhatTiepTheo.AddYears(1);
            }

            // Tính số ngày còn lại đến sinh nhật kế tiếp
            TimeSpan conLai = sinhNhatTiepTheo - ngayHienTai;
            int soNgayDenSinhNhat = (int)conLai.TotalDays;
            Console.WriteLine($"Tuổi hiện tại: {tuoi} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {tongSoNgaySong:#,##0} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {soNgayDenSinhNhat} ngày nữa");
        }
        static void Bai_5()
        {
            //Bài 5: Quản Lý Điểm Học Phần & Quy Đổi Thang Điểm GPA(4.0)
            Console.WriteLine("           ");
            int tc1 = 4;
            int tc2 = 3;
            int tc3 = 2;
            Console.Write($"C# ({tc1} TC): ");
            double diemCsharp = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Toán Rời Rạc ({tc2} TC): ");
            double diemToan = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Tiếng Anh ({tc3} TC): ");
            double diemTA = Convert.ToDouble(Console.ReadLine());
            // Tính điểm trung bình trọng số (Weighted Average Score): 
            int tongTC = tc1 + tc2 + tc3;
            double diemTb = (diemCsharp * tc1 + diemToan * tc2 + diemTA * tc3) / tongTC;
            char diemChu = 'F';
            double gpaThang4 = 0.0;
            string xepLoai = "";

            if (diemTb >= 8.5)
            {
                diemChu = 'A';
                gpaThang4 = 4.0;
                xepLoai = "Xuất sắc/Giỏi";
            }
            else if (diemTb >= 7.0)
            {
                diemChu = 'B';
                gpaThang4 = 3.0;
                xepLoai = "Khá";
            }
            else if (diemTb >= 5.5)
            {
                diemChu = 'C';
                gpaThang4 = 2.0;
                xepLoai = "Trung bình";
            }
            else if (diemTb >= 4.0)
            {
                diemChu = 'D';
                gpaThang4 = 1.0;
                xepLoai = "Yếu";
            }
            else if (diemTb < 4.0)
            {
                diemChu = 'F';
                gpaThang4 = 0.0;
                xepLoai = "Kém (Trượt)";
            }
            Console.WriteLine($"Điểm TB Thang 10: {diemTb:0.00}");
            Console.WriteLine($"Điểm chữ quy đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA thang 4: {gpaThang4:0.00}");
            Console.WriteLine($"Xếp Loại Học Lực: {xepLoai}");
        }
        static void Bai_6()
        {
          //Bài 6: Chuẩn Hóa Họ Tên Người Dùng &Tự Động Tạo Email / Username
        }

        public static void Main56454(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();
            Bai_3();
            Bai_4();
            Bai_5();
            Bai_6();

            Console.ReadKey();
            
           
        }
    }
}
