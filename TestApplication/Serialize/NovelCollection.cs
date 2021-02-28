using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialize
{
    /// <summary>
    /// コレクションをシリアル化するためのNovelCollectionクラス
    /// </summary>
    [XmlRoot("novels")]
    class NovelCollection
    {
        //Novelsプロパティに型と要素を付与
        [XmlElement(Type = typeof(Novel), ElementName ="novel")]
        public Novel[] Novels { get; set; }

    }
}
