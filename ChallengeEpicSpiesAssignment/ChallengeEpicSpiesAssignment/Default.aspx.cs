using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Today;
                Calendar2.SelectedDate = Calendar1.SelectedDate.AddDays(14);
                Calendar3.SelectedDate = Calendar1.SelectedDate.AddDays(21);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TimeSpan j = Calendar3.SelectedDate.Subtract(Calendar2.SelectedDate);
            double Budget = j.TotalDays * 500;

            if (j.TotalDays > 21)
            {
                Budget += 1000;
            }

            var totalAmount = Budget.ToString("C2");
            resultLabel.Text = String.Format("Assignment of {0} " +
             "to assignment {1} is authorized. " +
             "<br />Budget total: {2:C}",
             NameBox.Text,
             AssignBox.Text,
             totalAmount);


            TimeSpan i = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate);
            if (i.TotalDays < 14)
            {
                resultLabel.Text = "Error: Must allow at least two weeks between " +
                                "previous assignment and new assignment.";
                 DateTime k = Calendar1.SelectedDate.AddDays(14);

                 Calendar2.SelectedDate = k;
                 Calendar2.VisibleDate = k;

            }
                
            
            {

                
                }
            }

                }
            }
      
   


    

    
