using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[]{ 5,3,4,5,7,4,7,1,1,2,7};
            Console.WriteLine(Count(numbers, delegate (int n) { return n % 7 == 0; }));

            //ラムダ式
            var count = Count(numbers, n => return n % 7 == 0);
                


        }

        /// <summary>
        /// 配列の中で一致した値の数を返す
        /// </summary>
        /// <param name="numbers">配列</param>
        /// <param name="num">指定の値</param>
        /// <returns></returns>
        public static int Count(int[] numbers,Predicate<int> judge)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (judge(n) == true)
                {
                    count++;
                }
            }
            return count;

        }
    }
}
