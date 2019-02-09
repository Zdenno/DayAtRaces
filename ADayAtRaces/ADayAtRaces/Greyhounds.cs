using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtRaces
{
    public class Greyhounds
    {
        public int StartingPosition;
        public int raceTrackLength;
        public int Location;
        public PictureBox MyPictureBox;
        public Random randomizer;

        //Determines if dog is still running or not
        public bool Run()
        {
            if (MyPictureBox.Left <= raceTrackLength)
            { 
                MyPictureBox.Left += randomizer.Next(1, 5); 
                Location = MyPictureBox.Left;
                return true;
            }
            else
            {
                return false;
            } 
        }

        public void TakeAStartingPosition()
        { 
            MyPictureBox.Left = StartingPosition;
        }

    }
}
