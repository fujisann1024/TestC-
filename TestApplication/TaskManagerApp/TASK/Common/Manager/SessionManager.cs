using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using static System.Collections.Specialized.NameObjectCollectionBase;

namespace TaskManagerApp.TASK.Common.Manager
{
    public class SessionManager : System.Web.UI.Page
    {


        public SessionManager()
        {

        }
 

        /// <summary>
        /// セッションIDがURLに埋め込まれているか
        /// </summary>
        /// <returns></returns>
        public bool IsCookieless()
        {
            return Session.IsCookieless;
        }

        /// <summary>
        /// リクエスト時セッションが作成されたかどうか
        /// </summary>
        /// <returns></returns>
        public bool IsNewSession()
        {
            return Session.IsNewSession;
        }

        /// <summary>
        /// セッションが読み取り専用かどうか
        /// </summary>
        /// <returns></returns>
        public bool IsReadOnly()
        {
            return Session.IsReadOnly;
        }

        /// <summary>
        /// キーまたは数値インデックスによって値を取得または設定する。
        /// </summary>
        /// <param name="key"></param>
        /// <param name="text"></param>
        public void SetSession(string key, string text)
        {
            Session[key] = text;
        }

        /// <summary>
        /// セッションタイムアウトの設定
        /// </summary>
        /// <param name="minite"></param>
        public void SetSessionTimeout(int minite)
        {
            Session.Timeout = minite;
        }


        public HttpCookieMode GetCookieMode()
        {
            return Session.CookieMode;
        }

        /// <summary>
        /// セッションの数を取得
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return Session.Count;
        }

        /// <summary>
        /// セッションのキーをすべて返す
        /// </summary>
        /// <returns></returns>
        public KeysCollection GetSessionKeys()
        {
           return Session.Keys;
        }

        /// <summary>
        /// セッションのモードを取得する
        /// </summary>
        /// <returns></returns>
        public SessionStateMode GetSessionMode()
        {
            return Session.Mode;
        }

        /// <summary>
        /// セッションIDを取得する
        /// </summary>
        /// <returns></returns>
        public string GetSessionID()
        {
            return Session.SessionID;
        }


        public void Abandon()
        {
            Session.Abandon();
        }

        public void Add(string key, string value)
        {
            Session.Add(key, value);
        }

        public void Clear()
        {
            Session.Clear();
        }

        public void Remove(string key)
        {
            Session.Remove(key);
        }

        public void RemoveAt(int index)
        {
            Session.RemoveAt(index);
        }
    }
}