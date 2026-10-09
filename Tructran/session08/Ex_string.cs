using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT1.session08
{
    internal class Ex_string
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_01();
            Bai_02();
            Bai_03();
            Bai_04();
            Bai_05();
            Bai_06();
            Bai_07();
            Bai_08();
            Bai_09();
            Bai_10();
            Bai_11();
            Bai_12();
            Bai_13();

        }

        static string str = "";    // Chuỗi dùng chung cho hầu hết các bài
        static void Bai_01()
        {
            //Nhập chuỗi mới và in ra
            Console.Write("Nhập một chuỗi: ");
            str = Console.ReadLine();
            if (str == null) str = "";
            Console.WriteLine($"Chuỗi bạn vừa nhập là: {str}");
        }

        static void Bai_02()
        {
            // Tìm độ dài chuỗi (không dùng hàm thư viện)
            int dem = 0;
            foreach (char c in str)
                dem++;
            Console.WriteLine($"Độ dài chuỗi là: {dem}");
        }

        static void Bai_03()
        {
            //Tách từng ký tự của chuỗi
            Console.WriteLine("Chuỗi hiện tại: ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"Ký tự thứ {i}: {str[i]}");
            }
        }

        static void Bai_04()
        {
            //In các ký tự theo thứ tự ngược
            Console.WriteLine($"Chuỗi hiện tại: {str}");
            Console.Write("Các ký tự theo thứ tự ngược: ");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
        static void Bai_05()
        {
            // Đếm số từ trong chuỗi
            int words = 0;
            bool inWord = false; // đang ở trong một từ hay không

            foreach (char c in str)
            {
                if (c != ' ')
                {
                    if (!inWord)
                    {
                        words++;      // vừa bắt đầu một từ mới
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;   // gặp khoảng trắng => kết thúc từ
                }
            }

            Console.WriteLine($"Chuỗi hiện tại: {str}");
            Console.WriteLine($"Số từ trong chuỗi: {words}");
        }

        static void Bai_06()
        {
            //So sánh 2 chuỗi (không dùng hàm thư viện)
            Console.Write("Nhập chuỗi thứ nhất: ");
            string s1 = Console.ReadLine();
            Console.Write("Nhập chuỗi thứ hai: ");
            string s2 = Console.ReadLine();

            // Đếm độ dài của từng chuỗi
            int len1 = 0;
            foreach (char c in s1) len1++;
            int len2 = 0;
            foreach (char c in s2) len2++;
            bool equal = true;

            if (len1 != len2)
            {
                equal = false; // khác độ dài => chắc chắn khác nhau
            }
            else
            {
                for (int i = 0; i < len1; i++)
                {
                    if (s1[i] != s2[i])
                    {
                        equal = false; // gặp một ký tự khác nhau là dừng
                        break;
                    }
                }
            }

            if (equal)
                Console.WriteLine($"Hai chuỗi \"{s1}\" và \"{s2}\" GIỐNG nhau.");
            else
                Console.WriteLine($"Hai chuỗi \"{s1}\" và \"{s2}\" KHÁC nhau.");

        }

        static void Bai_07()
        {
            //Đếm chữ cái, chữ số, ký tự đặc biệt
            int letters = 0, digits = 0, specials = 0, spaces = 0;

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                    letters++;
                else if (char.IsDigit(c))
                    digits++;
                else if (c == ' ')
                    spaces++;      // khoảng trắng đếm riêng
                else
                    specials++;    // còn lại là ký tự đặc biệt: @ # $ ! ...
            }
            Console.WriteLine($"Chuỗi hiện tại: {str}");
            Console.WriteLine($"Số chữ cái: {letters}");
            Console.WriteLine($"Số chữ số: {digits}");
            Console.WriteLine($"Số ký tự đặc biệt: {specials}");
            Console.WriteLine($"(Số khoảng trắng: {spaces})");
        }

        static void Bai_08()
        {
            //Đếm nguyên âm và phụ âm
            int vowels = 0, consonants = 0;

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    char lower = char.ToLower(c); // đổi về chữ thường để so sánh dễ hơn

                    if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                        vowels++;
                    else
                        consonants++;
                }
            }
            Console.WriteLine($"Chuỗi hiện tại: {str}");
            Console.WriteLine($"Số nguyên âm: {vowels}");
            Console.WriteLine($"Số phụ âm: {consonants}");
        }

        static void Bai_09()
        {
            //Kiểm tra chuỗi con có trong chuỗi không
            Console.WriteLine($"Chuỗi hiện tại: {str}");
            Console.Write("Nhập chuỗi con cần kiểm tra: ");
            string sub = Console.ReadLine();

            bool found = false;

            if (sub.Length > 0)
            {
                for (int i = 0; i <= str.Length - sub.Length; i++)
                {
                    bool match = true;
                    for (int j = 0; j < sub.Length; j++)
                    {
                        if (str[i + j] != sub[j])
                        {
                            match = false; // lệch 1 ký tự là thử vị trí kế tiếp
                            break;
                        }
                    }

                    if (match)
                    {
                        found = true;
                        break;
                    }
                }
            }

            if (found)
                Console.WriteLine($"Chuỗi con \"{sub}\" CÓ trong chuỗi.");
            else
                Console.WriteLine($"Chuỗi con \"{sub}\" KHÔNG có trong chuỗi.");
        }

        static void Bai_10()
        {
            //Tìm vị trí của chuỗi con
            Console.WriteLine($"Chuỗi hiện tại: {str}");
            Console.Write("Nhập chuỗi con cần tìm: ");
            string sub = Console.ReadLine();

            int pos = -1; // -1 nghĩa là chưa tìm thấy

            if (sub.Length > 0)
            {
                for (int i = 0; i <= str.Length - sub.Length; i++)
                {
                    bool match = true;
                    for (int j = 0; j < sub.Length; j++)
                    {
                        if (str[i + j] != sub[j])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        pos = i;
                        break; // lấy vị trí đầu tiên rồi dừng
                    }
                }
            }
            if (pos == -1)
                Console.WriteLine($"Không tìm thấy chuỗi con \"{sub}\".");
            else
                Console.WriteLine($"Chuỗi con \"{sub}\" xuất hiện đầu tiên tại vị trí: {pos} (đếm từ 0)");
        }

        static void Bai_11()
        {
            // Kiểm tra ký tự có phải chữ cái không (và chữ hoa/thường)
            Console.Write("Nhập một ký tự: ");
            string input = Console.ReadLine();

            if (input == null || input.Length == 0)
            {
                Console.WriteLine("Bạn chưa nhập ký tự nào.");
            }
            else
            {
                char ch = input[0]; // lấy ký tự đầu tiên

                if (char.IsLetter(ch))
                {
                    Console.WriteLine($"'{ch}' là một chữ cái.");
                    if (char.IsUpper(ch))
                        Console.WriteLine($"'{ch}' là chữ HOA.");
                    else
                        Console.WriteLine($"'{ch}' là chữ thường.");
                }
                else
                {
                    Console.WriteLine($"'{ch}' KHÔNG phải là chữ cái.");
                }
            }
        }

        static void Bai_12()
        {
            //Đếm số lần chuỗi con xuất hiện
            Console.WriteLine($"Chuỗi hiện tại: {str}");
            Console.Write("Nhập chuỗi con cần đếm: ");
            string sub = Console.ReadLine();

            int count = 0;

            if (sub.Length > 0)
            {
                int i = 0;
                while (i <= str.Length - sub.Length)
                {
                    bool match = true;
                    for (int j = 0; j < sub.Length; j++)
                    {
                        if (str[i + j] != sub[j])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        count++;
                        i = i + sub.Length; // nhảy qua chuỗi con vừa tìm thấy
                    }
                    else
                    {
                        i++;                // không khớp thì xét vị trí kế tiếp
                    }
                }
            }

            Console.WriteLine($"Chuỗi con \"{sub}\" xuất hiện {count} lần.");
        }

        static void Bai_13()
        {
            //Chèn chuỗi con vào trước lần xuất hiện đầu tiên của một chuỗi

        }
    }
}
