using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book> { 
                new Book{Title = "こころ"      ,Price = 400, Pages = 378 },
                new Book{Title = "人間失格"　  ,Price = 281, Pages = 212 },
                new Book{Title = "伊豆の踊子"  ,Price = 389, Pages = 201 },
                new Book{Title = "若草物語"    ,Price = 637, Pages = 464 },
                new Book{Title = "銀河鉄道の夜",Price = 411, Pages = 276 },
                new Book{Title = "二都物語"    ,Price = 961, Pages = 666 },
                new Book{Title = "遠野物語"    ,Price = 514, Pages = 268 },                
            };

            //第一引数を第二引数分生成してList配列として返す
            var numbers = Enumerable.Repeat(-1,20)
                                    .ToList();
            dispIntList(numbers);

            //第一引数から第二引数までの範囲の連続した数値を配列として返す
            var array = Enumerable.Range(1,20)
                                  .ToArray();
            dispIntArray(array);

            //平均を求める
            var average = books.Average(x => x.Price);
            Console.WriteLine($@"金額平均値:{average}");

            //合計を求める
            var totalPrice = books.Sum(x => x.Price);
            Console.WriteLine($@"合計金額:{totalPrice}");

            //最大値を求める
            var pages = books.Max(x => x.Pages);
            Console.WriteLine($@"最大ページ数:{pages}");

            //条件に一致する要素をカウントした値を返す
            var count = books.Count(x => x.Title.Contains("物語"));
            Console.WriteLine($@"物語本:{count}");

            //コレクションの判定
            bool exists = books.Any(x => x.Price >= 1000);
            if (exists)
            {
                Console.WriteLine("1000円以上の書籍がある");
            }
            




        }

        static void dispIntList(List<int> lists)
        {
            foreach (var value in lists)
            {
                Console.WriteLine(value+",");
            }
        }

        static void dispStrintList(List<string> lists)
        {
            foreach (var value in lists)
            {
                Console.WriteLine(value + ",");
            }
        }

        static void dispIntArray(int[] arrays)
        {
            foreach (var value in arrays)
            {
                Console.WriteLine(value + ",");
            }
        }
    }
}
