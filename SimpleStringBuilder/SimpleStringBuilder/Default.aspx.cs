using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SimpleStringBuilder
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder Greeting = new StringBuilder();
            Greeting.Append("Greetings and hello ");
            Greeting.Append("from the town ");
            Greeting.Append("of Clackamas, OR ");
            Greeting.Append("on this beautiful ");
            Greeting.Append("summer day.");

            string together = Greeting.ToString();
            writeResult.Text = together;
        }
    }
}