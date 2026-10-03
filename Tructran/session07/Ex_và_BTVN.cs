using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT1.session07
{
    internal class Ex_và_BTVN
    {
        //Hàm in mảng ngẫu nhiên
        static void printArray(int[] arr)
        {
            foreach (int v in arr)
            {
                Console.Write(v + " ");
            }

            Console.WriteLine();
        }


        //  1. to calculate the average value of array elements.
        static double calcu_Avg(int[] arr)
        {
            int sum = 0;
            foreach (int v in arr)
                sum += v;
            return (double)sum / arr.Length;
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
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == y)
                {
                    return i;
                }
               
            }
            return -1;
      }


        //4. to remove a specific element from an array.
        static int[] removeElement(int[] arr, int x)
        {
            int index = searchIndex(arr, x);
            // Không tìm thấy phần tử
            if (index == -1)
            {
                return arr;
            }
            int[] newArr = new int[arr.Length - 1];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i != index)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            return newArr;
        }
        //5. to find the maximum and minimum value of an array.
        static int findMax(int[] arr)
        {
            int max = arr[0];
            foreach (int v in arr)
            {
                if (v > max)
                {
                    max = v;
                }
            }
            return max;
        }
        static int findMin(int[] arr)
        {
            int min = arr[0];

            foreach (int v in arr)
            {
                if (v < min)
                {
                    min = v;
                }
            }

            return min;
        }
        //6. to reverse an array of integer values.
        static int[] reverseArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[arr.Length - 1 - i];
            }
            return newArr;
        }

        //7. to find duplicate values in an array of values.
        static void findDuplicates(int[] arr)
        {
            bool hasDuplicate = false;
            Console.Write("Các phần tử bị trùng: ");
            for (int i = 0; i < arr.Length; i++)
            {
                // Kiểm tra xem phần tử này đã được in trước đó chưa
                bool alreadyPrinted = false;
                for (int k = 0; k < i; k++)
                {
                    if (arr[k] == arr[i])
                    {
                        alreadyPrinted = true;
                        break;
                    }
                }
                if (alreadyPrinted)
                {
                    continue;
                }
                // Kiểm tra phần tử hiện tại có xuất hiện phía sau không
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write(arr[i] + " ");
                        hasDuplicate = true;
                        break;
                    }
                }
            }
            if (!hasDuplicate)
            {
                Console.Write("Không có phần tử trùng");
            }
            Console.WriteLine();
        }

        //8. to remove duplicate elements from an array.
        static int[] removeDuplicates(int[] arr)
        {
            int[] temp = new int[arr.Length];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool exists = false;
                for (int j = 0; j < count; j++)
                {
                    if (temp[j] == arr[i])
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    temp[count] = arr[i];
                    count++;
                }
            }
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }





        public static void Main2334(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Tạo mảng ngẫu nhiên cho các bài 
            Random rnd = new Random();
            Console.Write("Nhập số lượng phân tử của mảng bạn muốn: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 20) + 1;
            }
            Console.WriteLine("\nMảng ngẫu nhiên: ");
            printArray(arr);
           

            //bài 1
            
            double avg = calcu_Avg(arr);
            Console.WriteLine($"Trung bình của dãy số là {avg}");
            Console.WriteLine();

            //bài 2
            Console.Write("Nhập số cần tìm:  " );
            int x = int.Parse(Console.ReadLine());
            bool kq = searchByValue(arr, x);
            if (kq)
            {
                Console.WriteLine($"Tìm thấy { x} trong mảng");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy { x} trong mảng");
            }
            Console.WriteLine();

            //Bài 3
            Console.Write("Nhập số cần tìm index: ");
            int y = int.Parse(Console.ReadLine());

            int index = searchIndex(arr, y);

            if (index != -1)
            {
                Console.WriteLine($"Tìm thấy {y} tại index: {index}");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy " + y + " trong mảng");
            }
            Console.WriteLine();

            //Bài 4
            Console.Write("Nhập phần tử muốn xóa: ");
            int removeValue = int.Parse(Console.ReadLine());
            int[] removedArr = removeElement(arr, removeValue);
            Console.WriteLine("Mảng sau khi xóa:");
            if (removedArr.Length == arr.Length)
            {
                Console.WriteLine($"Không tìm thấy {removedArr} trong mảng");
            }
            printArray(removedArr);

            //Bài 5
            int max = findMax(arr);
            int min = findMin(arr);
            Console.WriteLine($"Giá trị lớn nhất: {max}");
            Console.WriteLine($"Giá trị nhỏ nhất: {min}");
            Console.WriteLine();
            //Bài 6
            int[] reversedArr = reverseArray(arr);
            Console.WriteLine("Mảng ban đầu:");
            printArray(arr);

            Console.WriteLine("Mảng sau khi đảo ngược:");
            printArray(reversedArr);
            Console.WriteLine();
            //Bài 7
            findDuplicates(arr);
            Console.WriteLine();
            //Bài 8
            int[] uniqueArr = removeDuplicates(arr);
            Console.WriteLine("Mảng sau khi xóa phần tử trùng:");
            printArray(uniqueArr);
            Console.WriteLine();


        }

    }
}
