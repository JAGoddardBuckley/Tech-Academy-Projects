using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Problem 1.
            /*
            string name = "Jennifer Goddard Buckley";
            string reverse = "";
            for (int i = name.Length -1; i >= 0; i--)
            {
                reverse += name[i];
            }
            resultLabel.Text = reverse;
            
            //Problem 2.
            
            string names = "Luke, Leia, Han, Chewbacca";
            string[] backwards = (names.Split(','));
            resultLabel.Text = backwards[3] + "," + backwards[2] 
                + ", " + backwards[1] + ", " + backwards[0];*/


            //Problem 3.
            /*
            string names = "Luke,Leia,Han,Chewbacca";
            string[] padded = names.Split(',');
            resultLabel.Text = "*****" + padded[0].PadRight(9, '*') +
                "<br />*****" + padded[1].PadRight(9, '*') +
                "<br />*****" + padded[2].PadRight(9, '*') +
                "<br />**" + padded[3].PadRight(12, '*');*/


            //Problem 4.

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN" +
                " ZO COME ZO ZHE AID OF ZHEIR COUNTRY.";
            string puzzle1 =puzzle.Replace("Z", "T");
            string puzzle2 = puzzle1.Remove(10,9);
            string puzzle3 = puzzle2.ToLower();
            string puzzle4 = puzzle3.Remove(0,1);
            resultLabel.Text = "N" + puzzle4;

            
        }
    }
}