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
            return a + b;
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
            for (int i = 1; i <= so; i++)
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
            if (num < 2)
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
            foreach (char c in s.ToLower())
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

        //Bài 11: Kiểm tra tính đối xứng
        static bool KiemTraDoiXung(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        //Bài 12: Chuyển đổi nhiệt độ C sang độ F
        static double ChuyenDoiNhietDo(double c)
        {
            return 9 / 5 * c + 32;
        }

        //Bài 13: Tìm giá trị nhỏ nhất trong mảng
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        //Bài 14: Tính tổng các chữ số của một số nguyên
        static int TongCacChuSo(int n)

        {
            int tong = 0;

            while (n > 0)
            {
                tong += n % 10;
                n /= 10;
            }

            return tong;
        }

        //Bài 15: Sắp xếp mảng tăng dần
        static void XepTangDan(int[] arr)
        {
            Array.Sort(arr);

            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
        }

        //Bài 16: Xóa ký tự trùng lặp
        static string XoaTrungLap(string s)
        {
            string ketQua = "";

            foreach (char c in s)
            {
                if (!ketQua.Contains(c))
                {
                    ketQua += c;
                }
            }

            return ketQua;
        }

        //Bài 17: Tìm ước chung lớn nhất (UCLN)
        static int TimUCLN(int sodau, int sosau)
        {
            while (sodau != 0)
            {
                int temp = sosau;
                sosau = sodau % sosau;
                sodau = temp;
            }

            return sodau;
        }

        //Bài 18: Đổi thập phân sang nhị phân
        static string DecimalToBinary(int n)
        {
            if (n == 0)
                return "0";

            string ketQua = "";

            while (n > 0)
            {
                int phanDu = n % 2;

                ketQua = phanDu + ketQua;

                n /= 2;
            }

            return ketQua;
        }

        //Bài 19: Kiểm tra năm nhuận
        static bool KiemTraNamNhuan(int year)
        {
            return year % 400 == 0 ||
                   (year % 4 == 0 && year % 100 != 0);
        }

        //Bài 20: Đếm số từ trong câu
        static int DemSoTu(string sentence)
        {
            string[] cacTu = sentence.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );

            return cacTu.Length;
        }





        public static void Main444(string[] args)
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
            Console.Write("Nhập 1 số bất kỳ bạn muốn kiểm tra chẵn hay lẻ: ");
            int n = int.Parse(Console.ReadLine());
            if (KiemTraChan(n))
                Console.WriteLine($"{n} là số chẵn");
            else
                Console.WriteLine($"{n} là số lẻ");
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
            Console.Write("Viết 1 câu bạn nghĩ ra: ");
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
            Console.Write("Nhập số bất kỳ: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Dãy Fibonacci: ");
            InDayFibonacci(number);
            Console.WriteLine();

            //Bài 8
            Console.Write("Nhập câu/ từ: ");
            string s = Console.ReadLine();
            Console.WriteLine($"Số nguyên âm có trong câu/ từ là: {DemNguyenAm(s)}");
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
            Console.Write("Nhập số lượng phần tử: ");
            int phantu = int.Parse(Console.ReadLine());

            int[] arr = new int[phantu];

            for (int i = 0; i < phantu; i++)
            {
                Console.Write("Nhập phần tử thứ " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            double ketQua = TinhTrungBinh(arr);
            Console.WriteLine("Điểm trung bình = {ketQua}");
            Console.WriteLine();

            //Bài 11
            Console.Write("Nhập từ cần kiểm tra đối xứng: ");
            string m = Console.ReadLine();
            if (KiemTraDoiXung(s))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.WriteLine();

            //Bài 12
            Console.Write("Nhập độ C: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Độ Fah là: {ChuyenDoiNhietDo(c)} F");
            Console.WriteLine();

            //Bài 13
            Console.Write("Nhập một dãy số: ");
            int ptu = int.Parse(Console.ReadLine());

            int[] Arr = new int[ptu];
            for (int i = 0; i < ptu; i++)
            {
                Console.Write("Nhập phần tử thứ " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int min = TimMin(arr);
            Console.WriteLine("Giá trị nhỏ nhất là: {min}");

            //Bài 14
            Console.Write("Nhập các số bạn muốn tính tổng");
            int chuso = int.Parse(Console.ReadLine());
            int tong = TongCacChuSo(n);
            Console.WriteLine("Input: {chuso} -> Output: {tong}");
            Console.WriteLine();

            //Bài 15
            Console.Write("Nhập dãy số cần sắp xếp tăng dần: ");
            int cso = int.Parse(Console.ReadLine());
            int[] aarr = new int[cso];
            for (int i = 0; i < cso; i++)
            {
                Console.Write("Nhập phần tử thứ " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            XepTangDan(arr);

            //Bài 16
            Console.Write("Nhập chuỗi: ");
            string chuoi = Console.ReadLine();
            string output = XoaTrungLap(s);
            Console.WriteLine("Chuỗi sau khi xóa ký tự trùng lặp: {output}");
            Console.WriteLine();

            //Bài 17
            Console.Write("Nhập số đầu: ");
            int sodau = int.Parse(Console.ReadLine());
            Console.Write("Nhập số sau: ");
            int sosau = int.Parse(Console.ReadLine());
            int uoc = TimUCLN(a, b);
            Console.WriteLine("UCLN = {uoc}");
            Console.WriteLine();

            //Bài 18
            Console.Write("Nhập số thập phân: ");
            int sothapphan = int.Parse(Console.ReadLine());
            string sonhiphan = DecimalToBinary(n);
            Console.WriteLine("Số nhị phân: {sonhiphan}");
            Console.WriteLine();

            //Bài 19
            Console.Write("Nhập năm: ");
            int year = int.Parse(Console.ReadLine());
            bool namnhuan = KiemTraNamNhuan(year);
            Console.WriteLine("Năm nhuận: {namnhuan}");
            Console.WriteLine();

            //Bài 20
            Console.Write("Nhập câu: ");
            string sentence = Console.ReadLine();
            int sotu = DemSoTu(sentence);
            Console.WriteLine("Số từ trong câu: {sotu}");
            Console.WriteLine();





        }
    }
}
