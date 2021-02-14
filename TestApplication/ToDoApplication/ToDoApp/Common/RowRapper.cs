using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ToDoApplication.ToDoApp.Common
{
    public class RowRapper
    {
        public DataRow DataRow
        {
            get; private set;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="dataRow"></param>
        public RowRapper(DataRow dataRow)
        {
            this.DataRow = dataRow;
        }

        //それぞれデータベースから受け取ったDataRow型を他の型に変換して
        //値を返す。DBの中に指定したカラムがなければNull以外の値を返す
        public string ToString(string columnName)
        {
            if (this.DataRow[columnName] == DBNull.Value)
            {
                return "";
            }
            else
            {
                return this.DataRow[columnName].ToString();
            }
        }

        public int ToInt(string columnName)
        {
            if (this.DataRow[columnName] == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(this.DataRow[columnName]);
                    
            }
        }

        public decimal ToDecimal(string columnName)
        {
            if (this.DataRow[columnName] == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return decimal.Parse(DataRow[columnName].ToString());
            }
        }

    }
}