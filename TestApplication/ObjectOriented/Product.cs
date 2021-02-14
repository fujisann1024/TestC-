using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    /// <summary>
    /// 商品クラス
    /// </summary>
    class Product
    {
        //商品コード
        public int Code { get; private set; }
        //商品名
        public string Name { get; private set; }

        //商品価格
        public int Price { get; private set; }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Product(int code, string name, int price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }

        /// <summary>
        /// 消費税額を求める
        /// </summary>
        /// <returns>int</returns>
        public int GetTax()
        {
            return (int)(Price * 0.1);
        }

        /// <summary>
        /// 税込み価格を求める
        /// </summary>
        /// <returns></returns>
        public int GetPriceIncludingTax()
        {
            return Price * GetTax();
        }

    }
}
