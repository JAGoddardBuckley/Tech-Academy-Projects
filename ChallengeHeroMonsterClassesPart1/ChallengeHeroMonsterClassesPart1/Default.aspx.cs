using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Character Hero = new Character();

            Hero.Name = "Hero";
            Hero.Health = 100;
            Hero.DamageMaximum = 20;
            Hero.AttackBonus = false;

            Character Monster = new Character();

            Monster.Name = "Monster";
            Monster.Health = 80;
            Monster.DamageMaximum = 10;
            Monster.AttackBonus = true;

            Dice dice = new Dice();

            if (Hero.AttackBonus)
                Monster.Defend(Hero.Attack(dice));
            if (Monster.AttackBonus)
                Hero.Defend(Monster.Attack(dice));

            while (Hero.Health > 0 && Monster.Health >0)
            {
                Monster.Defend(Hero.Attack(dice));
                Hero.Defend(Monster.Attack(dice));
                DisplayMethod(Hero);
                DisplayMethod(Monster);
            }

            displayResult(Hero, Monster);
            
                 
        }

        private void displayResult(Character Hero, Character Monster)
        {
            if (Hero.Health <= 0 && Monster.Health <= 0)
                resultLabel.Text += String.Format("<p>Both {0} and {1} died.", Hero.Name, Monster.Name);
            else if (Hero.Health <= 0)
                resultLabel.Text += String.Format("<p>{0} defeats {1}</p>", Monster.Name, Hero.Name);
            else
                resultLabel.Text += String.Format("<p>{0} defeats {1}</p>", Hero.Name, Monster.Name);
        }
       
        public void DisplayMethod(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0} - Health: {1} -" +
                "DamageMaximum: {2} - AttackBonus {3}</p>",
            character.Name,
            character.Health.ToString(),
            character.DamageMaximum.ToString(),
            character.AttackBonus.ToString());

            
        }

    }

    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            
            dice.Sides = this.DamageMaximum;
            return dice.Roll();
        }

        public void Defend(int damage)
        {
            this.Health -= damage;

        }
    }
    public class Dice
        {
            public int Sides { get; set; }

            Random random = new Random();
            public int Roll()
            {
                return random.Next(this.Sides);
                
            }

        }
    }
