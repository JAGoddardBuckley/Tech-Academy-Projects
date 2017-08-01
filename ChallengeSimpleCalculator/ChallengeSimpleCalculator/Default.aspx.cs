using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            int first = int.Parse(TextBoxOne.Text);
            int second = int.Parse(TextBoxTwo.Text);
            int result = first + second;
            resultLabel.Text = result.ToString();
        }

        protected void SubButton_Click(object sender, EventArgs e)
        {
            int first = int.Parse(TextBoxOne.Text);
            int second = int.Parse(TextBoxTwo.Text);
            int result = first - second;
            resultLabel.Text = result.ToString();
        }

        protected void MultButton_Click(object sender, EventArgs e)
        {
            int first = int.Parse(TextBoxOne.Text);
            int second = int.Parse(TextBoxTwo.Text);
            int result = first * second;
            resultLabel.Text = result.ToString();
        }

        protected void DivButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(TextBoxOne.Text);
            double second = double.Parse(TextBoxTwo.Text);
            double result = first / second;
            resultLabel.Text = result.ToString();
        }
    }
}