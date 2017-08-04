using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            int most = 0;
            int least = 0;



            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] < numbers[least])
                {
                    least = i;
                }
                if (numbers[i] > numbers[most])
                {
                    most = i;
                }
          
            }
            result = String.Format("Most battles won by: {0} with {1} battles.<br />", names[most], numbers[most]);
            result += String.Format("Least battles won by: {0} with {1} battles.", names[least], numbers[least]);
            resultLabel.Text = result;
        }
    }
}