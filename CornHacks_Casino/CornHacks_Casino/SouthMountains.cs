using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CornHacks_Casino
{
    public partial class SouthMountains : Form
    {
        public int count = 0;
        
        Random random = new Random();
        public int diceNum;

        public int Random(int max)
        {
            int randomNum = random.Next(1, (max + 1));
            Dice_Value.Text = randomNum.ToString();
            return randomNum;

        }
        public SouthMountains()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                dialogue.Text = "It's been a long day of traveling,\nbut I am proud you made it this far";
            }
            if (count == 2)
            {
                dialogue.Text = "Would you like to stay here and rest\nor continue on?";
                YesBtn.Show();
                NoBtn.Show(); //rest
                Next.Hide(); //continue
            }
            if (count == 41)
            {
                diceNum = Random(10);
                if (diceNum <= 4)
                {
                    dialogue.Text = "You sit downt to rest, but you hear a\nstrange noise coming from the woods";
                    count = 30;
                }
                else
                {
                    dialogue.Text = "You decide the journey isn't\nworth it. Click next to close";
                }
            }
            if (count == 42)
            {
                this.Close();
            }
            if (count == 31)
            {
                dialogue.Text = "You move on with your journey.";
            }
            if (count == 21)
            {
                diceNum = Random(10);
                if (diceNum <= 4)
                {
                    dialogue.Text = "You try to continue, but it seems\nyou are too tired.";
                }
                else
                {
                    dialogue.Text = "You move on with your journey.";
                    count = 31;
                }
            }
            if (count == 22)
            {
                this.Close();
            }
            if (count == 32)
            {
                diceNum = Random(10);
                if (diceNum <= 2)
                {
                    Girl.Show();
                    Wizard.Hide();
                    Speaker.Text = "???";
                    dialogue.Text = "Where you goin, huh? You got any riches?";
                    count = 60;
                }
                else
                {
                    CaveOfWonder cave = new CaveOfWonder();
                    cave.Show();
                    this.Hide();
                }
            }
            if (count == 61)
            {
                Girl.Hide();
                Wizard.Show();
                Speaker.Text = "Wizard";
                dialogue.Text = "It looks like you are getting robbed!";
            }
            if (count == 62)
            {
                Girl.Show();
                Wizard.Hide();
                Speaker.Text = "Robber";
                dialogue.Text = "I will take all of your gold!";
            }
            if (count == 63)
            {
                Girl.Hide();
                Wizard.Show();
                Speaker.Text = "Wizard";
                dialogue.Text = "The robber took everything you have.\nUnfortunately you must return home";
            }
            if (count == 64)
            {
                dialogue.Text = "You made it far, young traveler.\nClick next to close.";
            }
            if (count == 65)
            {
                this.Close();
            }


        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            count = 40;
            YesBtn.Hide();
            NoBtn.Hide();
            Next.Show();
            dialogue.Text = "It seems you would like to stay and rest.";
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            count = 20;
            YesBtn.Hide();
            NoBtn.Hide();
            Next.Show();
            dialogue.Text = "You choose to continue.";
        }
    }
}
