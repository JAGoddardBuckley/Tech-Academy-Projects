using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //NameBox = 1
            //ElectionsBox = 2
            //AddBox = 3
            if (!Page.IsPostBack)
            {
                string[] name = new string[0];
                ViewState.Add("Name", name);

                int[] elections = new int[0];
                ViewState.Add("Elections", elections);

                double[] acts = new double[0];
                ViewState.Add("Acts", acts);
            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            string[] name = (string[])ViewState["Name"];
            Array.Resize(ref name, name.Length + 1);
            string newestItem = name.Last();
            newestItem = NameBox.Text.ToString();

            int[] elections = (int[])ViewState["Elections"];
            Array.Resize(ref elections, name.Length + 1);
            elections[name.GetUpperBound(0)] = int.Parse(ElectionsBox.Text);

            double[] acts = (double[])ViewState["Acts"];
            Array.Resize(ref acts, name.Length + 1);
            acts[name.GetUpperBound(0)] = double.Parse(ActsBox.Text);



            ViewState["Name"] = name;
            ViewState["Elections"] = elections;
            ViewState["Acts"] = acts;
            
            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br />" +
                "Average Acts of Subterfuge: {1:N2}<br />" +
                "Last Asset you Added: {2}",
                elections.Sum(),
                acts.Average(),
                newestItem);


            NameBox.Text = "";
            ElectionsBox.Text = "";
            ActsBox.Text = "";

        }
    }
}