using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobsMegaChallenege
{
    public partial class OrderManagement : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            var orders = PapaBobsMega.Domain.OrderManager.GetOrders();
            GridView1.DataSource = orders;
            GridView1.DataBind();

        }
        
    }
}