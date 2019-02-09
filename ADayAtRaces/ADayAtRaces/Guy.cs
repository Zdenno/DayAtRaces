using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;

namespace ADayAtRaces
{
    public class Guy
    {
        public string Name;
        public int Cash;
        public Bet MyBet;

        public RadioButton radioButtoon;
        public Label label;

        public void UpdateLabels()
        {
            if (MyBet != null)
            {
                label.Text = MyBet.GetDescription();
            }
            else
            {
                label.Text = "No bet was placed";
            }
            radioButtoon.Text = Name + " have $" + Cash;
           
        } 
        public bool PlaceABet(int amount, int dogToWin)
        {
            if (Cash >= amount)
            {
                MyBet = new Bet() {Amount = amount, Dog = dogToWin, Bettor = this };
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ClearBet()
        {
            MyBet = null;
        }
        public void Collect(int Winner)
        {
            if (MyBet != null)
            {
                this.Cash += MyBet.payOut(Winner); 
            }
        }


    }
}
