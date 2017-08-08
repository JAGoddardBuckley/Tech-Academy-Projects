using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ChangePost(object sender, EventArgs e)
        {
            postVolume();
        }
/*
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

            postVolume();
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            postVolume();
        }

        protected void heightBox_TextChanged(object sender, EventArgs e)
        {
            postVolume();
        }

        protected void groundButton_CheckedChanged(object sender, EventArgs e)
        {
            postVolume();
        }

        protected void airButton_CheckedChanged(object sender, EventArgs e)
        {
            postVolume();
        }

        protected void nextDayButton_CheckedChanged(object sender, EventArgs e)
        {
            postVolume();
        }*/

        

        private void postVolume()
        {
            //selected values? 
            if (!selectedValues()) return;

            //what is the volume?
            int volume = 0;
            if (!getVolume(out volume)) return;

            //multiplier?
            double postMultiply = getPostMultiply();

            //cost?
            double cost = volume * postMultiply;

            //result
            resultLabel.Text = String.Format(
                "It will cost {0:C} to post this parcel.", cost);
           
        }



        private bool selectedValues()
        {
            if (widthBox.Text.Trim().Length == 0
                || heightBox.Text.Trim().Length == 0)
                return false;
            if (!groundButton.Checked
                && !airButton.Checked
                && !nextDayButton.Checked)
                return false;
            return true;
        }


        private bool getVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;

            if (!int.TryParse(widthBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightBox.Text.Trim(), out height)) return false;
            if (!int.TryParse(lengthBox.Text.Trim(), out length)) length = 1;
            volume = width * height * length;
            return true;
        }
        private double getPostMultiply()

        {
            if (groundButton.Checked) return .15;
            else if (airButton.Checked) return .25;
            else if (nextDayButton.Checked) return .45;
            else return 0;

        }
    }
}