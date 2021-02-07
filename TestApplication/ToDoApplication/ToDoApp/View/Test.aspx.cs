using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToDoApplication.ToDoApp.Common;

namespace ToDoApplication.ToDoApp.View
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseManager database = new DatabaseManager();
            string sql = @"SELECT 
                            id, name, age, address, gender, birthday
                           FROM members";
            var table = database.GetDataTable(sql);

            var id = table.Rows[0]["id"];
            var name = table.Rows[0]["name"];
            var age = table.Rows[0]["age"];
            var address = table.Rows[0]["address"];
            var gender = table.Rows[0]["gender"];
            var birthday = table.Rows[0]["birthday"];

            string memberList = "<ul>";
            memberList += "<li>" + id + "</li>";
            memberList += "<li>" + name + "</li>";
            memberList += "<li>" + age + "</li>";
            memberList += "<li>" + address + "</li>";
            memberList += "<li>" + gender + "</li>";
            memberList += "<li>" + birthday + "<li>";
            memberList += "</ul>";

            memberTable.Text = memberList;
           
        }
    }
}