using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQtoXML
{
    class Program
    {
        static void Main(string[] args)
        {
            dispXML disp = new dispXML();
            //Lord～XMLファイルを読み込む
            var xdoc = XDocument.Load(@"C:\Users\twook\TestLog\XML\novelists.xml");
            //Root.Elements()～ルート直下にある要素を取得
            var xelements = xdoc.Root.Elements();
            //disp.DispElementXML(xelements);
        }
    }
}
