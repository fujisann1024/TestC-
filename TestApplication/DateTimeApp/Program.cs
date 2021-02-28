using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //読み込み専用
            var today = DateTime.Today;
            DayOfWeek dayOfWeek = today.DayOfWeek;//曜日
            var now = DateTime.Now;
            var year = now.Year;
            var month = now.Month;
            var day = now.Day;
            var hour = now.Hour;
            var minute = now.Minute;
            var second = now.Second;
            int millisecond = now.Millisecond;

            //うるう年かどうか判定
            var isLeapYear = DateTime.IsLeapYear(2005);

            //日時を文字列に変換する
            var oneday = new DateTime(2016,4,7,20,30,50);
            var s1 = oneday.ToString("d");
            var s2 = oneday.ToString("D");
            var s3 = oneday.ToString("yyyy-MM-dd");
            var s4 = oneday.ToString("yyyy年M月d日");
            var s5 = oneday.ToString("yyyy年MM月dd日 HH時mm分dd秒");
            var s6 = oneday.ToString("f");
            var s7 = oneday.ToString("F");
            var s8 = oneday.ToString("t");
            var s9 = oneday.ToString("T");
            var s10 = oneday.ToString("tt hh:mm");
            var s11 = oneday.ToString("HH時mm分ss秒");


                
            //日付を和暦で表示
            var date = new DateTime(2016, 6, 5);

            var calture = new CultureInfo("ja-JP");
            calture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = date.ToString("ggyy年M月d日",calture);

            //元号コードを得る
            var era = calture.DateTimeFormat.Calendar.GetEra(date);
            //元号コードから元号名を得る
            var eraName = calture.DateTimeFormat.GetEraName(era);

            //日時の計算
            var now1 = DateTime.Now;
            //h時間m分s秒後を求める
            var feature = now + new TimeSpan(1,30,0);
            //h時間m分s秒前を求める
            var past = now - new TimeSpan(1,30,0);





        }
    }
}
