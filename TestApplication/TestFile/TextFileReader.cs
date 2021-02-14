using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFile
{
    class TextFileReader
    {
        public static string fileParh1 = @"C:\Users\twook\TestLog\Read\test1.txt";

        public static string filePath2 = @"C:\Users\twook\TestLog\Read\test2.txt";

        public static string filePath3 = @"C:\Users\twook\TestLog\Read\test3.txt";

        public static string filePath4 = @"C:\Users\twook\TestLog\Read\test4.txt";

        public static string filePath5 = @"C:\Users\twook\TestLog\Read\test5.txt";
        /// <summary>
        /// テキストファイルを1行ずつ読み込む
        /// </summary>
        public void dispText1()
        {
            //File.Exists～ファイルが存在しているか
            if (File.Exists(fileParh1))
            {
                Console.WriteLine("-------test1.txt-------");
                //StreamReader(ファイルの絶対パス,文字コード)～ファイルを開く
                //usingで確実にCloseする
                using (var reader = new StreamReader(fileParh1, Encoding.UTF8))
                {
                    //EndOfStreamプロパティ～ファイルの最後まで読み込んだかどうか
                    while (!reader.EndOfStream)
                    {
                        //ReadLineメソッド～テキストを1行ずつ読み込む
                        var line = reader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
        }

        /// <summary>
        /// テキストファイルを一気に読み込む
        /// </summary>
        public void dispText2()
        {
            Console.WriteLine("------test2.txt-------");
            if (File.Exists(filePath2))
            {
                //File.ReadAllLines～すべての行を読み込み、結果をstring[]として返す
                var lines = File.ReadAllLines(filePath2,Encoding.UTF8);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// 先頭3行を表示
        /// Windowsが含まれる行数をカウント
        /// 空白行、空文字を省いた行を表示する
        /// </summary>
        public void dispText3()
        {
            Console.WriteLine("-----test3.txt-------");
            if (File.Exists(filePath3))
            {
                //File.ReadLines～IEnumerable<string>を返すのえLinqと組み合わせる
                  //先頭5行をstring[]として返す
                var headLines = File.ReadLines(filePath3, Encoding.UTF8)
                                .Take(3)
                                .ToArray();
                Console.WriteLine("test3.txtの先頭3行");
                foreach (string headLine in headLines)
                {
                    Console.WriteLine(headLine);
                }

                  //Windowsが含まれる行をカウントする
                int count = File.ReadLines(filePath3, Encoding.UTF8)
                                .Count(s => s.Contains("Windows"));

                Console.WriteLine($@"条件に一致した行数:{count} 条件:「Windows」");

                  //
                var lines = File.ReadLines(filePath3, Encoding.UTF8)
                                .Where(s => !String.IsNullOrWhiteSpace(s))
                                .ToArray();

                Console.WriteLine("空文字列や空白行以外を取り出す");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// ファイル内に数字行が存在する確認
        /// 重複行,空白行を除き、並び替える
        /// </summary>
        public void dispText4()
        {
            if (File.Exists(filePath4))
            {
                Console.WriteLine("----test4.txt-------");
                //Whereメソッドを設けないとAllメソッドが適用され空の行に対してtureを返してしまう
                bool exists = File.ReadLines(filePath4, Encoding.UTF8)
                                .Where(s => !String.IsNullOrWhiteSpace(s))
                                .Any(s => s.All(c => Char.IsDigit(c)));

                if (exists)
                {
                    Console.WriteLine("数字行が存在します");
                }
                else
                {
                    Console.WriteLine("数字行は存在しません");
                }

                //重複行,空白行を除き、並び替える
                var lines = File.ReadLines(filePath4, Encoding.UTF8)
                                .Distinct()
                                .Where(s => !String.IsNullOrWhiteSpace(s))
                                .OrderBy(s => s.Length)
                                .ToArray();
                Console.WriteLine("空白行,重複行をはぶいて行の短い順に並べた結果");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            
        }

        /// <summary>
        /// 行ごとに何らかの変更処理を行う
        /// </summary>
        public void dispText5()
        {

            if (File.Exists(filePath5))
            {
                Console.WriteLine("----test5.txt-------");
                var lines = File.ReadLines(filePath5)
                             .Select((s, ix) => String.Format("{0,4}: {1}", ix + 1, s))
                             .ToArray();

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }

        


    }
}
