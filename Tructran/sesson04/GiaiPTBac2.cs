using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Text;

namespace Tructran.sesson04
{
    internal class GiaiPTBac2
    {
        static void GiaiPTBac2(int a,int b,int c)
        {
            //Bài tập giải phương trình bậc 2.
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phương trình có vô số nghiệm ");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm ");
                    }
                }
                else
                {
                    Console.WriteLine("Nghiệm của phương trình là { x = -c/b}");
                }
            }
            else
            {

            }
            {

            }
               
            }

            
        }

        public static void Main4(string[] args)
        {
            Console.Write("Nhập hệ số a: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập hệ số b: "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập hệ số c: "); int c = Convert.ToInt32(Console.ReadLine());

  
            GiaiPTBac2(a,b,c);
        }
    }
}
