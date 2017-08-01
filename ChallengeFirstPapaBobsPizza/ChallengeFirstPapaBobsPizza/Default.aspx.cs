using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsPizza
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double i = 0;
            if (BabyBobButton.Checked)
            {
                i = 10;
            }
            else if (MamaBobButton.Checked)
            {
                i = 13;
            }
            else if (PapaBobButton.Checked)
            {
                i = 16;
            }
            else
            {
                resultLabel.Text = "Please choose a size.";
            }
            resultLabel.Text = "$" + i.ToString();


            if (DeepButton.Checked)
            {
                i = i + 2; 
            }
            resultLabel.Text = "$" + i.ToString();

            if (PepperoniBox.Checked)
            {
                i = i + 1.5;
            }
            resultLabel.Text = "$" + i.ToString();
            if (OnionBox.Checked)
            {
                i = i + .75;
            }
            resultLabel.Text = "$" + i.ToString();
            if (GreenBox.Checked)
            {
                i = i + .5;
            }
            resultLabel.Text = "$" + i.ToString();
            if (RedBox.Checked)
            {
                i = i + .75;
            }
            resultLabel.Text = "$" + i.ToString();
            if (FishBox.Checked)
            {
                i = i + 2;
            }
            resultLabel.Text = "$" + i.ToString();

            if (PepperoniBox.Checked 
                && GreenBox.Checked
                && FishBox.Checked
                || PepperoniBox.Checked
                && RedBox.Checked
                && OnionBox.Checked)
            {
                i = i - 2;
            }
            resultLabel.Text = "$" + i.ToString();
        }



            
        
    }
}