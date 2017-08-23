using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleString
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
  
                string[] stringarray = new string[]
                {
                "Greetings and hello from",
                "the town of Clackamas OR",
                "on this beautiful summer",
                 "day."};

                string together = String.Join("\n", stringarray);
                writeResult.Text = together;
      
              
            
            
        }  
    }

}
    
