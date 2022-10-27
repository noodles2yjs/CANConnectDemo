using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLearningDemo
{
    class Program
    {
        /*  static void Main(string[] args)
          {
              var calculatorDelegate = new CalculatorDelegate(Add); // 必须要传一个参数,否则报错
              var @delegate = calculatorDelegate(12, 23);
              calculatorDelegate += Sub;
              var i = calculatorDelegate(20, 10);
              calculatorDelegate -= Sub;
              var m = calculatorDelegate(20, 10);

              Console.WriteLine($"结果:{@delegate} ");
              Console.WriteLine($"结果:{i} ");
              Console.WriteLine($"结果:{m} ");
              Console.Read();
          }

  */

      /*  static void Main(string[] args)
        {
            
             int a = 2, b = 3;
             int temp = 0;
            // 交换变量 -- 使用临时变量
            *//*  temp = a;
              a = b;
              b = temp;*//*
            // 交换变量 -- 使用异或方法 交换变量 只能是数值类型的
            a = a ^ b;
            b= a ^ b;
            a = a ^ b;

            Console.WriteLine($"a: {a}");
             Console.WriteLine($"b: {b}");

             Console.Read();
        }*/


   /*   static void Main(string[] args)
      {
          const int N = 5;
          var nums = new int[N];
          var seekSeed = Guid.NewGuid().ToString();
          var random = new Random(seekSeed.GetHashCode());
          for (int i = 0; i < N; i++)
          {
              nums[i] = random.Next(1, 100);
          }

          foreach (var VARIABLE in nums)
          {
              Console.WriteLine(VARIABLE);
          }
          #region 查找最大值

          int max = int.MinValue;
          for (int i = 0; i < N; i++)
          {
              if (nums[i] > max)
              {
                  max = nums[i];
              }
          }

          Console.WriteLine($"最大值: {max}");
            #endregion

            #region 查找最小值

            int min = int.MaxValue;
            for (int i = 0; i < N; i++)
            {
                if (nums[i]< min)
                {
                    min = nums[i];
                }
            }

            Console.WriteLine($"最小值: {min}");
            #endregion

            #region 冒泡排序 最值在后面

            for (int i = 0; i < N-1; i++)
            {
                for (int j = i+1; j < N; j++)
                {
                    
                    if (nums[j] < nums[i])  // 后面的比前面小 交换变量 小的在前
                    {
                        nums[i] = nums[i] ^ nums[j];
                        nums[j] = nums[i] ^ nums[j];
                        nums[i] = nums[i] ^ nums[j];
                    }
                }
            }

            Console.WriteLine("冒泡的结果: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(nums[i]);
            }
            #endregion

            Console.Read();
      }*/

   static void Main(string[] args)
   {

   }

   static int Add(int a ,int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
