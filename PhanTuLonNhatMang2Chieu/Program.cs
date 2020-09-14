using System;
using System.Text;

namespace PhanTuLonNhatMang2Chieu
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] A = new int[100, 100];
            int d, c;
            do
            {
                Console.WriteLine("Nhập số dòng :");
                d = int.Parse(Console.ReadLine());
                if (d <= 0)
                {
                    Console.WriteLine("Số dòng không hợp lệ, nhập lại");
                }
            } while (d <= 0);
            do
            {
                Console.WriteLine("Nhập số cột :");
                c = int.Parse(Console.ReadLine());
                if (c <= 0)
                {
                    Console.WriteLine("Số cột không hợp lệ, nhập lại");
                }
            } while (c <= 0);
            nhapmang(ref A, ref d, ref c);
            xuatmang(A, d, c);
            int Max = max(A, d, c);
            Console.WriteLine("Phần tử lớn nhất = {0} ", Max);
            Console.ReadLine();
        }
        static void nhapmang(ref int[,] A, ref int d, ref int c)
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < d * c; i++)
            {
                Console.Write("Nhập theo thứ tự dòng -> cột[{0}][{1}] :", i / c, i % c);
                A[i / c, i % c] = int.Parse(Console.ReadLine());
            }
        }
        static void xuatmang(int[,] A, int d, int c)
        {
            for (int i = 0; i < d * c; i++)
            {
                Console.Write("{0}    ", A[i / c, i % c]);
                if ((i + 1) % c == 0)
                {
                    Console.Write("\n");
                }
            }
        }

        static int max(int[,] A, int d, int c)
        {
            int max = A[0, 0];
            for (int i = 0; i < d * c; i++)
            {
                if (max < A[i / c, i % c])
                {
                    max = A[i / c, i % c];
                }
            }
            return max;
        }
    }
}
