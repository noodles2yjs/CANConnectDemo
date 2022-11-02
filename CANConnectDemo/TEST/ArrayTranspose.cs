using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public class ArrayTranspose
    {
        /// <summary>
        /// 矩阵转置
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr1"></param>
        public static void CTL<T>(T[,] arr1)
        {
            //执行换行 // 3行3列
            // 计算 Matrix 的行与列  不会
           int row = arr1.GetLength(0);
           int col = arr1.GetLength(1);
            int trow = col;
            int tcol = row;

            T[,] arr2 = new T[trow, tcol];
            for (int i = 0; i < trow; i++)
            {
                for (int j = 0; j < tcol; j++)
                {
                    arr2[i, j] = arr1[j, i]; // 转置
                }
            }

            //将换行数据输出
            Console.WriteLine("互换后:\n");
            for (int i = 0; i < trow; i++)
            {
                for (int j = 0; j < tcol; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }

                Console.WriteLine("\n");
            }
        }

    }
}

