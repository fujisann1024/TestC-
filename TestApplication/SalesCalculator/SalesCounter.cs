using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator
{
    /// <summary>
    /// 売上集計クラス
    /// </summary>
    class SalesCounter
    {
        //Listのインターフェースに変更
        private IEnumerable<Sale> _sales;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }

        /// <summary>
        /// 店舗別売上を求めるメソッド
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, int> GetPerStoreSales()
        {
            //Dictionary<TKey,TValue>～TKey型のキーに対応するTValue型の値をもつ配列
            var dict = new Dictionary<string, int>();
            //_salesディクショナリからSaleオブジェクトを1つずつ取り出し処理をする
            foreach (Sale sale in _sales)
            {
                //指定したShopNameがdict内に格納されているか調べる
                if (dict.ContainsKey(sale.ShopName))
                {
                    //次の行で最初の売上高をdictに格納する
                    dict[sale.ShopName] += sale.Amount;
                }
                else
                {
                    //次に示す行で最初の売上高をdictに格納する
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
        }

        public static IEnumerable<Sale> ReadSales(string filePath)
        {
            //売上データを入れるリストオブジェクトを生成
            var sales = new List<Sale>();
            //ファイルから一気に読み込む
            var lines = File.ReadAllLines(filePath);
            //読み込んだ行の数だけ繰り返す
            foreach (var line in lines)
            {
                //カンマで分割し配列に格納
                var items = line.Split(',');
                //Saleオブジェクトを生成(オブジェクト初期化子)
                var sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                //Saleオブジェクトをリストに追加
                sales.Add(sale);

            }
            return sales;
        }
    }
}
