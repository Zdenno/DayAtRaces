using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayAtRaces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if (Bettor != null)
            {
                return Bettor.Name + " bets $" + Amount + " on dog number: " + Dog;  
            } 
            else
            { 
                return "No bet was placed";
            }
            
        } 
        public int payOut(int Winner)
        {
            if (Dog == Winner)
            {
               return Amount = Amount * 2;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
