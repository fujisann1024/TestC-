using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var getInfo = new GetInfo();
            getInfo.dispAssembly();
            getInfo.dispFileVersion();
        }
    }
}
