using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT1.session07
{
    internal class Ex
    {
      //  1. to calculate the average value of array elements.
       static int calcu_Avg(int[] arr)
        {
            int sum = 0;
            foreach (int v in arr)
                sum += v;
            return sum / arr.Length;
        }
      //2. to test if an array contains a specific value.
      static bool searchByValue(int[] a, int x)
        {
            foreach (int v in a)
                if (v == x)
                    return true;
            return false;
        }

      //3. to find the index of an array element.
      static int searchIndex(int[] b, int y)
        {
            for (int i = 0; ; i < b.Length; i++)
            {
                if (b[i] == y)
                    return i;
                return -1;
            }
        }







        //4. to remove a specific element from an array.
        //5. to find the maximum and minimum value of an array.
        //6. to reverse an array of integer values.
        //7. to find duplicate values in an array of values.
        //8. to remove duplicate elements from an array.





        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Tạo mảng ngẫu nhiên cho các bài 
            Random rnd = new Random();
            Console.Write("Nhập số lượng phân tử của mảng bạn muốn: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            

            //bài 1
            
            int avg = calcu_Avg(arr);
            Console.WriteLine($"Trung bình của dãy số là {arr}" );
            Console.WriteLine();

            //bài 2
            Console.Write("Nhập số cần tìm:  " );
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng phần tử: ");
            int phantu = int.Parse(Console.ReadLine());

            int[] a = new int[phantu];

            for (int i = 0; i < phantu; i++)
            {
                Console.Write("Nhập phần tử thứ " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            bool kq = searchByValue(a, x);
            if (kq)
            {
                Console.WriteLine($"Tìm thấy {x} trong mảng");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy {x} trong mảng" );
            }




        }
        
    }
}
