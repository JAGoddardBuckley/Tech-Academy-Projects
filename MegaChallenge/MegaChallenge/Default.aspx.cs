using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int bet = 0;
                leverPull(bet);
                ViewState.Add("Money", 100);
                displayMoney();
            }

        }

        

        protected void pullButton_Click(object sender, EventArgs e)
        {
            int bet = 0;
            if (!int.TryParse(betBox.Text, out bet)) return;
            int winnings = leverPull(bet);
            displayResult(bet, winnings);
            changeMoney(bet, winnings);
            displayMoney();
           
        }

       

        private int leverPull(int bet)
        {
            string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
            imageDisplay(reels);
            int multiply = spinNumber(reels);
            return bet * multiply;
        }

        private int spinNumber(string[] reels)
        {
            
            if (barLoss(reels)) return 0;
            if (sevens(reels)) return 100;
            int multiply = 0;
            if (cherryWin(reels, out multiply)) return multiply;

            return 0;
        }

       

        private bool barLoss(string[] reels)
        {
            if (reels[0] == "Bar" || reels[1] == "Bar" || reels[2] == "Bar")
            
                 return true;
            else return false;
        }

        private bool sevens(string[] reels)
        {
            if (reels[0] == "Seven" && reels[1] == "Seven" && reels[2] == "Seven")
                return true;
            else return false;
        }


        private int CountCherries(string[] reels)
        {
            int cherries = 0;
            if (reels[0] == "Cherry") cherries++;
            if (reels[1] == "Cherry") cherries++;
            if (reels[2] == "Cherry") cherries++;
            return cherries;
         }

        private bool cherryWin(string[] reels, out int multiply)
        {
            multiply = Multiplier(reels);
            if (multiply > 0) return true;
            return false;


        }
        private int Multiplier(string[] reels)
        {
            int cherries = CountCherries(reels);
            if (cherries == 1) return 2;
            if (cherries == 2) return 3;
            if (cherries == 3) return 4;
            else return 0;
        }

        private void imageDisplay(string[] reels)
        {
            Image1.ImageUrl = "/Images/" + reels[0] + ".png";
            Image2.ImageUrl = "/Images/" + reels[1] + ".png";
            Image3.ImageUrl = "/Images/" + reels[2] + ".png";
        }

        private string spinReel()
        {
            string[] images = new string[] { "Strawberry", "Bar", "Lemon", "Bell", "Clover", "Cherry", "Diamond", "Orange", "Seven", "HorseShoe", "Plum", "Watermelon" };
            return images[random.Next(11)];


        }
        protected void betBox_TextChanged(object sender, EventArgs e)
        {

        
    }
        private void changeMoney(int bet, int winnings)
        {
            int money = int.Parse(ViewState["Money"].ToString());
            money -= bet;
            money += winnings;
            ViewState["Money"] = money;
        }


        private void displayMoney()
        {
            
            moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["Money"]);
            int money = int.Parse(ViewState["Money"].ToString());
            if (money == 0)
                moneyLabel.Text = "You are out of money. GAME OVER.";
            resultLabel.Text = "";
            return;
        }

        private void displayResult(int bet, int winnings)
        {
            if (winnings > 0)
            {
                resultLabel.Text = String.Format("You bet {0:C} and won{1:C}!", bet, winnings);
            }
            else
            {
                resultLabel.Text = String.Format("Sorry you lost {0:C}. Better luck next time.", bet);
            }
        }

        
       
            
        
    }
}