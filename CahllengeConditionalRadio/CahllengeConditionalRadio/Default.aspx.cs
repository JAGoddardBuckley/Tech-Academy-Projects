using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CahllengeConditionalRadio
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (PencilButton.Checked)
                resultLabel.Text = "You selected Pencil";
            else if (PenButton.Checked)
                resultLabel.Text = "You selected Pen";
            else if (PhoneButton.Checked)
                resultLabel.Text = "You selected Phone";
            else if (TabletButton.Checked)
                resultLabel.Text = "You selected Tablet";
            else
                resultLabel.Text = "Please select an option";


            if (PencilButton.Checked)
                resultImage.ImageUrl = "pencil.png";
            else if (PenButton.Checked)
                resultImage.ImageUrl = "pen.png";
            else if (PhoneButton.Checked)
                resultImage.ImageUrl = "phone.png";
            else if (TabletButton.Checked)
                resultImage.ImageUrl = "tablet.png";
        }

                
    }
}