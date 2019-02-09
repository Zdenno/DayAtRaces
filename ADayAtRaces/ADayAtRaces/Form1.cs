using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtRaces
{
    public partial class Form1 : Form
    {
        Greyhounds[] dogs = new Greyhounds[4];
        Random random = new Random();
        Guy[] guys = new Guy[3];
        int winnerDog;
        public void InstantiateGrehoundObjects()
        {
            dogs[0] = new Greyhounds()
            {
                MyPictureBox = pictureBoxDog1,
                raceTrackLength = RaceTrackpictureBox.Width - pictureBoxDog1.Width,
                randomizer = random,
                StartingPosition = 0,
                Location = pictureBoxDog1.Left
            };
            dogs[1] = new Greyhounds()
            {
                MyPictureBox = pictureBoxDog2,
                raceTrackLength = RaceTrackpictureBox.Width - pictureBoxDog2.Width,
                randomizer = random,
                StartingPosition = 0,
                Location = pictureBoxDog2.Left
            };
            dogs[2] = new Greyhounds()
            {
                MyPictureBox = pictureBoxDog3,
                raceTrackLength = RaceTrackpictureBox.Width - pictureBoxDog3.Width,
                randomizer = random,
                StartingPosition = 0,
                Location = pictureBoxDog3.Left
            };
            dogs[3] = new Greyhounds()
            {
                MyPictureBox = pictureBoxDog4,
                raceTrackLength = RaceTrackpictureBox.Width - pictureBoxDog4.Width,
                randomizer = random,
                StartingPosition = 0,
                Location = pictureBoxDog4.Left
            };
            foreach (Greyhounds dog in dogs)
            {
                dog.TakeAStartingPosition();
            }
        }
        public void InstantiateGuyObjects()
        {
            guys[0] = new Guy()
            {
                Name = "Al",
                Cash = 50,
                radioButtoon = AlradioButton,
                label = Allabel
            };
            guys[1] = new Guy()
            {
                Name = "Bob",
                Cash = 50,
                radioButtoon = BobradioButton,
                label = Boblabel
            };
            guys[2] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                radioButtoon = JoeradioButton,
                label = Joelabel
            };

            foreach (Guy guy in guys)
            {
                guy.UpdateLabels();
            }
        }
        public void getLocationOfGreyHounds()
        {
            Dog1Location.Text = "Dog 1: " + dogs[0].Location / 2 + " meters";
            Dog2Location.Text = "Dog 2: " + dogs[1].Location / 2 + " meters";
            Dog3Location.Text = "Dog 3: " + dogs[2].Location / 2 + " meters";
            Dog4Location.Text = "Dog 4: " + dogs[3].Location / 2 + " meters";

        }
        public Form1()
        {
            InitializeComponent();
            InstantiateGrehoundObjects();
            InstantiateGuyObjects();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dogs.Length; i++)
            {
                getLocationOfGreyHounds();

                if (!dogs[i].Run())
                {
                    timer1.Stop();
                    winnerDog = i + 1;
                    MessageBox.Show("Winner is dog number: " + winnerDog, "We have a winner");
                    foreach (Greyhounds dogo in dogs)
                    {
                        dogo.TakeAStartingPosition();
                    }
                    foreach (Guy guy in guys)
                    {
                        guy.Collect(winnerDog);
                        guy.ClearBet();
                        guy.UpdateLabels();
                    }
                    groupBox1.Enabled = true;
                }
            }
        }

        public bool checkIfThereAnyBet(Guy[] guys)
        {
            foreach (Guy guy in guys)
            {
                if (guy.MyBet != null)
                {
                    timer1.Enabled = true;
                    groupBox1.Enabled = false;
                    return true;
                }
            }
            return false;
        }
        private void StartTheGameButton_Click(object sender, EventArgs e)
        {
            if (!checkIfThereAnyBet(guys))
            {
                MessageBox.Show("Please place a bet");
            }
        }

        private void AlradioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = "Al";
        }

        private void BobradioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = "Bob";
        }

        private void JoeradioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = "Joe";
        }

        public void ResetLabelAndBetAmount()
        {
            NameLabel.Text = "";
            numericUpDown1.Value = numericUpDown1.Minimum;
            numericUpDown2.Value = numericUpDown2.Minimum;
            Dog1Location.Text = "Dog 1: 0 meters.";
            Dog2Location.Text = "Dog 2: 0 meters.";
            Dog3Location.Text = "Dog 3: 0 meters.";
            Dog4Location.Text = "Dog 4: 0 meters.";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int dog = (int)numericUpDown2.Value;
            if (AlradioButton.Checked)
            {
                guys[0].PlaceABet((int)numericUpDown1.Value, dog);
                AlradioButton.Checked = false;
                ResetLabelAndBetAmount();
            }
            else if (BobradioButton.Checked)
            {
                guys[1].PlaceABet((int)numericUpDown1.Value, dog);
                BobradioButton.Checked = false;
                ResetLabelAndBetAmount();
            }
            else if (JoeradioButton.Checked)
            {
                guys[2].PlaceABet((int)numericUpDown1.Value, dog);
                JoeradioButton.Checked = false;
                ResetLabelAndBetAmount();
            }
            else
            {
                MessageBox.Show("Pick a guy");
            }
            foreach (Guy guy in guys)
            {
                guy.UpdateLabels();
            }

        }
    }
}
