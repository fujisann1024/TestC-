using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFile
{
    class TextFileWriter
    {
        private static string filePath1 = @"C:\Users\twook\TestLog\Write\test1.txt";

        private static string filePath2 = @"C:\Users\twook\TestLog\Write\test2.txt";

        /// <summary>
        /// ファイルを上書きするメソッド
        /// </summary>
        /// <param name="text"></param>
        public void writeText(string text)
        {
            using (var write = new StreamWriter(filePath1))
            {
                try
                {
                    write.WriteLine(text);
                }
                catch (IOException error)
                {
                    Console.WriteLine(error);
                }
                
            }
        }

        /// <summary>
        /// 既存のファイルの末尾に行を追加する
        /// </summary>
        /// <param name="text"></param>
        public void writeNextText(string text)
        {
            //StreamWriterの第二引数のappendフラグにtrueを設定すると既存ファイルの末尾に追記する
            using (var write = new StreamWriter(filePath1,append:true))
            {
                    try
                    {
                        write.WriteLine(text);
                    }
                    catch (IOException error)
                    {
                        Console.WriteLine(error);
                    }
            }
                
        }

        public void writeHeadText(string text)
        {
            /*
             FileMode.Open:既存のファイルをオープン
             FileAccess.ReadWrite:読み込みと書き込みの両方を行えるようにする
             FileShare.None:他からのアクセスを拒否する
             */
            using (var stream = new FileStream(filePath1,FileMode.Open,FileAccess.ReadWrite,FileShare.None))
            {
                //usingで確実にクローズ   
                using (var reader = new StreamReader(stream))
                using (var writer = new StreamWriter(stream))
                {
                    //既存のファイル内容を最後まで読み込む
                    string texts = reader.ReadToEnd();
                    //ファイルのポジションを先頭に戻す
                    stream.Position = 0;
                    //挿入する行
                    writer.WriteLine(text);

                    writer.Write(texts);
                }

            }
        }

        public void writeAllText(List<string> texts)
        {
            try
            {
                File.WriteAllLines(filePath2, texts.Where(s => s.Length > 3));
            }
            catch (IOException error)
            {
                Console.WriteLine(error);
            }
            
        }

    }
}
