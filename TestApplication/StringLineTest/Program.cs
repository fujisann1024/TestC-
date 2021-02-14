using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLineTest
{
    class Program
    {
        static void Main(string[] args)
        {

            judgeString judge = new judgeString();
            string fruitsSmall = "apple";
            string fruitsLarge = "APPLE";
            judge.judgeCompare(fruitsSmall,fruitsLarge);
        }
    }
}
