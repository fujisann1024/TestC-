using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiApp.View
{
    public partial class Test1_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //asyncキーワード～非同期メソッドになる
        protected async void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            //awaitキーワード～
            await Task.Run(() => DoSomething());
            label1.Text = "終了";
        }

        protected void DoSomething()
        {
            result.Text = DoLongTimeWork();
        }

        protected string DoLongTimeWork() {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < 100; i++)
            {
                sb.Append(i + ",");

                if (i % 10 == 0)
                {
                    sb.Append("<br>");
                }
                
            }
            return sb.ToString();
        }
    }
}