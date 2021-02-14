using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator
{
    /// <summary>
    /// 売上クラス
    /// </summary>
    class Sale
    {
        /// <summary>
        /// 店舗名
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 商品カテゴリ
        /// </summary>
        public string ProductCategory { get; set; }

        /// <summary>
        /// 売上高
        /// </summary>
        public int Amount { get; set; }

    }
}
