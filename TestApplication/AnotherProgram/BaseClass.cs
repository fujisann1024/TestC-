using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherProgram
{
    class BaseClass
    {
        public void StartSakura()
        {
            string path = @"C:\sakura\sakura.exe";
            //プログラムを実行
            using (var process = Process.Start(path))
            {
                //プロセスが終了するまで待機
                process.WaitForExit();
            }
        }

        
    }
}
