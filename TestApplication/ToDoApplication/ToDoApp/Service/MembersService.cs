using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using ToDoApplication.ToDoApp.Common;

namespace ToDoApplication.ToDoApp.Service
{
    public class MembersService
    {
        
       public string Select()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0}, ",membersColumn.id);
            stringBuilder.AppendFormat("{0}, ",membersColumn.name);
            stringBuilder.AppendFormat("{0}, ",membersColumn.age);
            stringBuilder.AppendFormat("{0}, ",membersColumn.birthday);
            stringBuilder.AppendFormat("{0}, ",membersColumn.email);
            stringBuilder.AppendFormat("{0}, ",membersColumn.address);
            stringBuilder.AppendFormat("{0} ",membersColumn.password);

            return stringBuilder.ToString();
        }

        public string From()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("FROM ");
            stringBuilder.AppendFormat("{0} with(nolock)",membersColumn.tableName);
            return stringBuilder.ToString();
            
        }

        public string GetMembers()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(this.Select());
            stringBuilder.AppendLine(this.From());

            return stringBuilder.ToString();
      
        }
    }
}