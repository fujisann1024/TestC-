using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFile
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFileReader textFile = new TextFileReader();
            textFile.dispText1();
            textFile.dispText2();
            textFile.dispText3();
            textFile.dispText4();
        }
    }
}
