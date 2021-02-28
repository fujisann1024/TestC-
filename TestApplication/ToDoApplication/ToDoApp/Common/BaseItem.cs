using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApplication.ToDoApp.Common
{
    public class BaseItem
    {
        public BaseItem(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public BaseItem(string key)
        {
            this.Key = key;
        }

        public string Key {
            get; set;
        }

        public string Value
        {
            get; set;
        }

        public string BindName {
            get
            {
                return '@' + this.Key;
            }
           
        }


    }
}