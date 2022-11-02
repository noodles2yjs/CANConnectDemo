using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        /* static void Main(string[] args)
         {
             double[] a = { 1, 2, 3, 4, 5, 6 };
             double[,] b = Row2VecD(a);
             double[,] c = Row2ArrT(a, 2); // 行向量变数组 一维变二维
             //double[,] c = RowToArrD(a, 2);
             double[] d = Arr2RowD(c);

             Console.WriteLine("数组:");
             var aList = a.ToList();
             aList.ForEach(n => { Console.Write(n + " "); });

             Console.WriteLine("\n行向量→列向量");
             for (int i = 0; i < b.GetLength(0); i++)
             {
                 for (int j = 0; j < b.GetLength(1); j++)
                 {
                     Console.WriteLine("b[{0},{1}]：{2}", i, j, b[i, j]);
                 }
             }

             Console.WriteLine("\n\n行向量→数组");
             for (int i = 0; i < c.GetLength(0); i++)
             {
                 for (int j = 0; j < c.GetLength(1); j++)
                 {
                     Console.WriteLine("c[{0},{1}]：{2}", i, j, c[i, j]);
                 }
             }

             Console.WriteLine("\n\n数组→行向量");
             for (int i = 0; i < d.Length; i++)
             {
                 Console.WriteLine("d[{0}]：{1}", i, d[i]);
             }

             Console.ReadKey();
         }*/
        static void Main(string[] args)
        {
            //程序2二维数组互换位置
            int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, };
            Console.WriteLine("互换前:\n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            ArrayTranspose.CTL(arr);


            Console.ReadLine();
        }

        //  行向量→数组（内存复制版）
        static double[,] RowToArrD(double[] src, int row)
        {
            if (src.Length % row != 0) return null;
            int col = src.Length / row;
            double[,] dst = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                //说明：“二维数组”【顺序储存】<=>“一维数组”
                Buffer.BlockCopy(src, i * col * sizeof(double),
                    dst, i * col * sizeof(double), col * sizeof(double));
            }
            return dst;
        }

        //行向量→列向量（内存复制版）
        static double[,] Row2VecD(double[] src)
        {
            double[,] dst = new double[src.Length, 1];
            Buffer.BlockCopy(src, 0, dst, 0, sizeof(double) * src.Length);
            return dst;
        }

        //行向量→数组（循环版；泛型版）
        static T[,] Row2ArrT<T>(T[] vec, int row)
        {
            if (vec.Length % row != 0) return null;
            int col = vec.Length / row;
            T[,] ret = new T[row, col];
            for (int i = 0; i < vec.Length; i++)
            {
                ret[i / col, i % col] = vec[i];
            }
            return ret;
        }

        //数组→行向量（内存复制版）
        static double[] Arr2RowD(double[,] src)
        {
            int elem = src.GetLength(0) * src.GetLength(1);
            double[] dst = new double[elem];
            Buffer.BlockCopy(src, 0, dst, 0, elem * sizeof(double));
            return dst;
        }
    }
}

