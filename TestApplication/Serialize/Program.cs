using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var xml = new XMLSerialize();

            var novels = new Novel[]
            {
                new Novel
                {
                    Author = "ジェイムズ・P・ボーガン",
                    Title = "星を継ぐもの",
                    Published = 1977,
                },

                new Novel
                {
                    Author = "H・G・ウェルズ" ,
                    Title = "タイム・マシン",
                    Published = 1895,
                }
                
            };

            string fileName1 = @"C:\Users\twook\TestLog\XML\novel1.xml";

            string fileName2 = @"C:\Users\twook\TestLog\XML\novel2.xml";

            //シリアル化～オブジェクトの状態をネットワーク越しに転送できる形式
            xml.CreateXML(fileName1, novels);
            //デシリアライズ～シリアル化したデータを元のオブジェクトに戻す変換
            xml.CreateXML(fileName1, novels, false);

            
            xml.CreateXMLApp(fileName2, novels);

            xml.CreateXMLApp(fileName2, novels, false);



        }
    }
}
