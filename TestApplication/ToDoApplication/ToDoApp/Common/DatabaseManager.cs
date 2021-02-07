using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ToDoApplication.ToDoApp.Common
{
    public class DatabaseManager
    {
        public SqlConnection sqlConnection;
        public SqlTransaction sqlTransaction;

        public DatabaseManager()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"LAPTOP-05JSUJKP\SQLEXPRESS";
            builder.InitialCatalog = "TODODB";
            builder.IntegratedSecurity = true;
            string connectionString = builder.ToString();

            // SqlConnection の新しいインスタンスを生成 (接続文字列を指定)
            this.sqlConnection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// DB接続を開く
        /// </summary>
        public void Open()
        {
            try
            {
                this.sqlConnection.Open();
            }
            catch (SqlException error)
            {
                Console.WriteLine(error.Message);
            } 
        }

        /// <summary>
        /// DB切断
        /// </summary>
        public void Close()
        {
            try
            {
                this.sqlConnection.Close();
            }
            catch (SqlException error)
            {
                Console.WriteLine(error.Message);
            }
        }

        /// <summary>
        /// トランザクション開始
        /// </summary>
        public void BeginTransaction()
        {
            try
            {
                this.sqlTransaction = this.sqlConnection.BeginTransaction();
            }
            catch (SqlException error)
            {
                Console.WriteLine(error.Message);
            }
            
        }

        /// <summary>
        /// コミット
        /// </summary>
        public void Commit()
        {
            if (this.sqlTransaction.Connection != null)
            {
                try
                {
                    this.sqlTransaction.Commit();
                    this.sqlTransaction.Dispose();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }

        /// <summary>
        /// ロールバック
        /// </summary>
        public void RollBack()
        {
            if (this.sqlTransaction.Connection != null)
            {
                try
                {
                    this.sqlTransaction.Rollback();
                    this.sqlTransaction.Dispose();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }

        /// <summary>
        /// クエリー実行　抽出系
        /// </summary>
        /// <param name="query">SQL文</param>
        /// <param name="paramDict">SQLパラメーター</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader ExecuteQuery(string query, Dictionary<string, Object> paramDict)
        {
            SqlCommand sqlCommand = new SqlCommand();

            //クエリー送信先、トランザクションの指定
            sqlCommand.Connection = this.sqlConnection;
            sqlCommand.Transaction = this.sqlTransaction;

            sqlCommand.CommandText = query;
            foreach (KeyValuePair<string, Object> item in paramDict)
            {
                sqlCommand.Parameters.Add(new SqlParameter(item.Key, item.Value));
            }

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            return sqlDataReader;
        }

        /// <summary>
        /// クエリー実行
        /// </summary>
        /// <param name="query">SQL文</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader ExecuteQuery(string query)
        {
            return this.ExecuteQuery(query, new Dictionary<string, Object>());
        }
        /// <summary>
        /// クエリー実行 更新系
        /// </summary>
        /// <param name="query">SQL文</param>
        /// <param name="paramDict">SQLパラメーター</param>
        public void ExecuteNonQuery(string query, Dictionary<string, Object> paramDict)
        {
            SqlCommand sqlCommand = new SqlCommand();

            //クエリー送信先,トランザクションの指定
            sqlCommand.Connection = this.sqlConnection;
            sqlCommand.Transaction = this.sqlTransaction;

            sqlCommand.CommandText = query;
            foreach (KeyValuePair<string, Object> item in paramDict)
            {
                sqlCommand.Parameters.Add(new SqlParameter(item.Key, item.Value));
            }

            //SQLを実行
            sqlCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// クエリー実行
        /// </summary>
        /// <param name="sql">SQL文</param>
        /// <returns>DataTable</returns>
        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, this.sqlConnection))
            {
                this.Open();
                dataAdapter.Fill(dt);
            }
            return dt;
        }




    }
}