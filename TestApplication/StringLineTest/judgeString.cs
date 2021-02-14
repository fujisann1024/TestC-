using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLineTest
{
    /// <summary>
    /// メソッドは暗記
    /// </summary>
    class judgeString
    {
        /// <summary>
        /// 大文字小文字の区別なく比較する
        /// </summary>
        /// <param name="str1">比較する文字列</param>
        /// <param name="str2">比較される文字列</param>
        public void judgeCompare(string str1,string str2)
        {
            Console.WriteLine($@"{str1}と{str2}を比較した結果...");
            if (String.Compare(str1,str2,true) == 0)
            {
                Console.WriteLine("等しい");
            }
            else
            {
                Console.WriteLine("等しくない");
            }
        }

        /// <summary>
        /// ひらがなとカタカナの区別なく比較する
        /// </summary>
        /// <param name="str1">比較する文字列</param>
        /// <param name="str2">比較される文字列</param>
        public void judgeCompareKana(string str1, string str2)
        {
            Console.WriteLine($@"{str1}と{str2}を比較した結果...");
            var cultureInfo = new CultureInfo("ja-JP");
            if (String.Compare(str1,str2,cultureInfo,CompareOptions.IgnoreKanaType) == 0)
            {
                Console.WriteLine("等しい");
            }
            else
            {
                Console.WriteLine("等しくない");
            }
        }

        /// <summary>
        /// 全角と半角の区別なく比較する
        /// </summary>
        /// <param name="str1">比較する文字列</param>
        /// <param name="str2">比較される文字列</param>
        public void dudgeCompareZenHan(string str1, string str2)
        {
            Console.WriteLine($@"{str1}と{str2}を比較した結果...");
            var cultureInfo = new CultureInfo("ja-JP");
            if (String.Compare(str1, str2, cultureInfo, CompareOptions.IgnoreWidth) == 0)
            {
                Console.WriteLine("等しい");
            }
            else
            {
                Console.WriteLine("等しくない");
            }
        }
        /// <summary>
        /// Nullか空かを判定する
        /// </summary>
        /// <param name="str">文字列</param>
        public void IsNullOrEmpty(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                Console.WriteLine($@"{str}はNull,または空です");
            }
            Console.WriteLine(str);
        }

        /// <summary>
        /// Nullか空か空文字列かを判定する
        /// </summary>
        /// <param name="str">文字列</param>
        public void IsNullOrWhiteSpace(string str)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine($@"{str}はNull,または空,空白文字列です");
            }
            Console.WriteLine(str);
        }

        /// <summary>
        /// 指定した文字列が先頭から始まっているか
        /// </summary>
        /// <param name="str">文字列</param>
        /// <param name="check">調査する文字列</param>
        public void StartsWith(string str , string check)
        {
            if (str.StartsWith(check))
            {
                Console.WriteLine($@"{check}で始まっている文字列");

            }
            Console.WriteLine($@"{check}で始まっている文字列でない");
        }

        /// <summary>
        /// 指定した文字列が末尾で終わっているか
        /// </summary>
        /// <param name="str">文字列</param>
        /// <param name="check">調査する文字列</param>
        public void EndsWith(string str, string check)
        {
            if (str.EndsWith(check))
            {
                Console.WriteLine($@"{check}で終わっている文字列");

            }
            Console.WriteLine($@"{check}終わっている文字列でない");
        }

        /// <summary>
        /// 指定した文字列が含まれているか
        /// </summary>
        /// <param name="str">文字列</param>
        /// <param name="check">調査する文字列</param>
        public void Contains(string str, string check)
        {
            if (str.Contains(check))
            {
                Console.WriteLine($@"{check}が含まれている文字列");
            }
            Console.WriteLine($@"{check}が含まれていない文字列");
        }







    }
}
