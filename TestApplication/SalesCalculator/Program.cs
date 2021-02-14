using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!string.IsNullOrEmpty(args[0]))
            {
                var sales = new SalesCounter(args[0]);
                var amountPerStore = sales.GetPerStoreSales();
                foreach (var obj in amountPerStore)
                {
                    Console.WriteLine("{0},{1}",obj.Key,obj.Value);
                }
            }
            else
            {
                Console.WriteLine("対象のcsvファイルを絶対パスで指定してください");
            }
            

        }


    }
}
