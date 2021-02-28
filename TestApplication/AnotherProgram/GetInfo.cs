using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnotherProgram
{
    class GetInfo
    {
        /// <summary>
        /// アセンブリバージョンの表示
        /// </summary>
        public void dispAssembly()
        {
            var asm = Assembly.GetExecutingAssembly();
            var version = asm.GetName().Version;
            Console.WriteLine($@"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}");
        }

        public void dispFileVersion()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            var version = FileVersionInfo.GetVersionInfo(location);
            Console.WriteLine($@"{version.FileMajorPart}.{version.FileMinorPart}.{version.FileBuildPart}.{version.FilePrivatePart}");
        }
    }
}
