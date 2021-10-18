using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanh5
{
    class bai1
    {
        static void Main()
        {
            Console.WriteLine("Nhap so nguyen n");
            int n = Convert.ToInt32(Console.ReadLine());
            bool kq = ktsonguyen(n);
            Console.WriteLine(kq);
        }
        static bool ktsonguyen(int n)
        {
            if(n<2)
            {
                return false;
            }
            if (n % n == 0 || n % 1 == 0)
            {
                return true;
            }
            else
                return false;             
        }
    }
}
