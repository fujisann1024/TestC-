using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQtoXML
{
    class dispXML
    {
        XDocument document;
        /// <summary>
        /// 特定の要素を取り出す
        /// </summary>
        /// <param name="xElemens">XDocumentオブジェクト</param>
         public void DispElementXML(XDocument xDocument)
        {
            //読みがな順に並び替える
            var xnovelists = xDocument.Root.Elements()
                                      .OrderBy(x => (string)(x.Element("name").Attribute("kana")));
            foreach (var xnovelist in xnovelists)
            {
                var xname = xnovelist.Element("name");
                var xbirth = (DateTime)xnovelist.Element("birth");
                var xkana = xnovelist.Attribute("kana");
                Console.WriteLine($@"{xname.Value}({xkana.Value}) {xbirth.ToShortDateString()}");
            }
        }

        
    }
}
