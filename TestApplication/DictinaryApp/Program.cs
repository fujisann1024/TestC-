using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictinaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ディクショナリの初期化
            var flowerDict = new Dictionary<string, int>()
            {
                ["sunfloewr"] = 400,
                ["pansy"] = 300,
                ["tulip"] = 350,
                ["rose"] = 500,
                ["dahlia"] = 450,
            };

            //Valueにはユーザーが定義したオブジェクトを格納する
            var employeeDict = new Dictionary<int, Employees>
            {
                {100, new Employees(100, "佐藤") },
                {112, new Employees(112, "鈴木") },
                {125, new Employees(125, "高橋") },
            };

            //追加
            //flowerDict["violet"] = 600;
            //employeeDict[126] = new Employees(126, "伊藤");

            //追加(Addメソッド)
            flowerDict.Add("violet",600);
            employeeDict.Add(126, new Employees(126, "伊藤"));

            //要素を取り出す
            int price = flowerDict["rose"];
            var employee = employeeDict[125];

            //ディクショナリにキーが存在するか確かめる
            var key = "pansy";

            if (flowerDict.ContainsKey(key))
            {
                Console.WriteLine("pansyは存在する");
            }

            //削除
            var result = flowerDict.Remove("pansy");

            //すべての値を表示する
            foreach (KeyValuePair<string, int> item in flowerDict)
            {
                Console.WriteLine("{0} = {1}",item.Key,item.Value);
            }

            //LINQ
            //平均
            var average = flowerDict.Average(x => x.Value);
            //合計
            var total = flowerDict.Sum(x => x.Value);
            //要素をフィルタリング
            var items = flowerDict.Where(x => x.Key.Length <= 5);




        }
    }
}
