using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serialize
{
    class XMLSerialize
    {
        /// <summary>
        /// DataContactSerializerを使ってシリアル化,逆シリアル化を行う
        /// ※名前空間が一致していないと逆シリアル化できない
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="novel"></param>
        /// <param name="serialize"></param>
        public void CreateXML(string fileName, Novel[] novels,bool serialize = true)
        {
            //xmlの設定
            var settings = new XmlWriterSettings
            {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

           
            if (serialize){

                using (var writer = XmlWriter.Create(fileName, settings))
                {
                    var serializer = new DataContractSerializer(novels.GetType());
                    serializer.WriteObject(writer, novels);
                }
            }else{

                using (var reader = XmlReader.Create(fileName))
                {
                    var serializer = new DataContractSerializer(typeof(Novel[]));
                    var reverseNovels = serializer.ReadObject(reader) as Novel[];
                    foreach (var novel in reverseNovels)
                    {
                        Console.WriteLine(novel);
                    }
                }
                   
            }
                
            
        }

        public void CreateXMLApp(string fileName, Novel[] novels, bool serialize = true)
        {
            if (serialize)
            {
                using (var writer = XmlWriter.Create(fileName))
                {
                    var serializer = new XmlSerializer(novels.GetType());
                    serializer.Serialize(writer, novels);
                }
            }
            else
            {
                using (var reader = XmlReader.Create(fileName))
                {
                    var serializer = new XmlSerializer(typeof(Novel[]));
                    var reverseNovels = serializer.Deserialize(reader) as Novel[];
                    foreach (var novel in reverseNovels)
                    {
                        Console.WriteLine(novel);
                    }
                }
            }
            
        }

        public void CreateXMLApp2(string fileName, Novel[] novels, bool serialize = true)
        {
            var novelCollection = new NovelCollection { 
                Novels = novels
            };
            if (serialize)
            {
                using (var writer = XmlWriter.Create(fileName))
                {
                    var serializer = new XmlSerializer(novelCollection.GetType());
                    serializer.Serialize(writer, novelCollection);
                }
            }
            else
            {
                using (var reader = XmlReader.Create(fileName))
                {
                    var serializer = new XmlSerializer(typeof(Novel[]));
                    var reverseNovels = serializer.Deserialize(reader) as Novel[];
                    foreach (var novel in reverseNovels)
                    {
                        Console.WriteLine(novel);
                    }
                }
            }

        }

        //XMLを文字列に変換する
        public string stringXML(Novel novel)
        {
            var sb = new StringBuilder();
            using (var writer = XmlWriter.Create(sb))
            {
                var serializer = new XmlSerializer(novel.GetType());
                serializer.Serialize(writer,novel);
            }
            return sb.ToString();
        }

        //メモリーストリームに出力
        public void memoryXML(Novel novel)
        {
            var stream = new MemoryStream();
            using (var writer = XmlWriter.Create(stream))
            {
                var serializer = new XmlSerializer(novel.GetType());
                serializer.Serialize(writer, novel);
            }
        }


        
    }

}
