using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;

namespace TaskManagerApp.TASK.Common.HTTP
{
    public class HTTPManager
    { 

        public HttpRequest Request
        {
            get; private set;
        }

        public HttpResponse Response {
            get; private set;
        }

        public HttpServerUtility Server
        {
            get; private set;
        }

        public HTTPManager()
        {

        }

        /// <summary>
        /// クエリ文字の取得
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string getQuery(string key)
        {
            var values = this.Request.QueryString[key];
            return values;
        }

        /// <summary>
        /// HTTPリクエストに含まれるクッキーの情報
        /// </summary>
        /// <returns></returns>
        public HttpCookieCollection GetCookies()
        {
            return this.Request.Cookies;
        }

        /// <summary>
        /// HTTPリクエストのヘッダーの情報
        /// </summary>
        /// <returns></returns>
        public NameValueCollection GetHeaders()
        {
            return this.Request.Headers;
        }

        /// <summary>
        /// サーバー変数の情報
        /// </summary>
        /// <returns></returns>
        public NameValueCollection GetServerVariables()
        {
            return this.Request.ServerVariables;
        }


       /// <summary>
       /// 別のページに遷移
       /// </summary>
       /// <param name="url"></param>
        public void Redirect(string url)
        {
            try
            {
                this.Response.Redirect(url);
            }
            catch(HttpException error)
            {
                Console.WriteLine(error.Message);
            }
            
        }

        /// <summary>
        /// 仮想パスを物理パスに変換して取得
        /// </summary>
        /// <param name="fileName">仮想パス</param>
        /// <returns>物理パス</returns>
        public string GetPath(string fileName)
        {

            //仮想パス～Webアプリケーション内で使用されているパス(^/App_Data/test.data)
            //→ASP.NETアプリケーションを展開する際の実際の物理パスがどうなるか、開発時点で分からないため
            //Webアプリケーション内で有効な仮想パスを使う

            //物理パス～C:\Inetpub\root\ASP.NET\TaskManager\App\...
            //→開発時とデプロイ時でパスが異なる
            try
            {
                var filePath = this.Server.MapPath(fileName);
                return filePath;
            }
            catch (HttpException error)
            {
                Console.WriteLine(error.Message);
            }
            return string.Empty;
        }

        /// <summary>
        /// HTMLテキストをエンコード/デコードする
        /// サニタイジングを行いXSS対策
        /// </summary>
        /// <param name="text">HTMLテキスト</param>
        /// <param name="encode">エンコードするかどうか</param>
        /// <returns>エンコードorデコードされたテキスト</returns>
        public string TextEncodeORDecode(string text,bool encode = true)
        {
            ///HTMLエンコード～HTMLの特殊文字を別の文字列に変換する
            if (encode)
            {
               return this.Server.HtmlEncode(text);
            }
            else
            {
               return this.Server.HtmlDecode(text);
            }
        }

        /// <summary>
        /// URLをエンコード/デコードする
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="encode">エンコードするかどうか</param>
        /// <returns>エンコードorデコードされたURL</returns>
        public string UrlEncodeOrDecode(string url, bool encode=true)
        {
            //URLエンコード～文字列をURLで使える形式に変換すること
            if (encode)
            {
                return this.Server.UrlEncode(url);
            }
            else
            {
                return this.Server.UrlDecode(url);
            }
        }

        public void CreateFile(string filepath, string fileType)
        {
            try
            {
                //ファイルの場所の取得
                string fileName = this.GetPath(filepath);

                //出力バッファをクリア→ファイル内容以外のデータ(HTMLタグなど)が混ざってしまうのを防ぐため
                this.Response.Clear();

                //コンテンツタイプを設定【例】image/jpeg～
                Response.ContentType = fileType;

                //ファイルを出力
                Response.WriteFile(fileName);

                //レスポンス処理を終了
                try
                {
                    this.Response.End();
                }
                catch (ThreadAbortException error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            catch (HttpException error)
            {
                Console.WriteLine(error.Message);
            }
            
           
        }


    }
}