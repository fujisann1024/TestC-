using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApplication.ToDoApp.Common
{
    public class ServiceManager
    {
        public DatabaseManager DBManager {
            get; set;
        }

        internal ServiceManager(DatabaseManager dbManager)
        {
            this.DBManager = dbManager;
        }

        //public T GetService<T>() where T : DatabaseManager, new()
        //{
        //    var type = typeof(T);

        //    var svc = new T();

           
        //}
        

    }
}