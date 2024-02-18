using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CornHacks_Casino
{
    public partial class GoblinHut : Form
    {
        public int count = 0;
        public int diceNum;
        Random random = new Random();

        public int Random(int max)
        {
            int randomNum = random.Next(1, (max + 1));
            Dice_Value.Text = randomNum.ToString();
            return randomNum;

        }
        public GoblinHut()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                Wizard.Hide();
                Goblin.Show();
                dialogue.Text = "What are ya looking at, huh?\nYou wanna fight?";
                Speaker.Text = "Goblin";
            }
            if (count == 2)
            {
                Wizard.Show();
                Goblin.Hide();
                Speaker.Text = "Wizard";
                dialogue.Text = "An ill omen looms!\nYou stumbled across a goblin hut!";

            }
            if (count == 3)
            {
                Goblin.Show();
                Wizard.Hide();
                dialogue.Text = "You better scramble before I pounce!";
                Speaker.Text = "Goblin";
            }
            if (count == 4)
            {
                Goblin.Hide();
                Wizard.Show();
                dialogue.Text = "Will you stay and fight, or flee?\nChoose quickly!";
            }
            if (count == 5)
            {
                Next.Hide();
                YesBtn.Show();
                NoBtn.Show();
            }
            if (count == 6)
            {
                diceNum = Random(10);
                if (diceNum <= 3)
                {
                    Goblin.Show();
                    Wizard.Hide();
                    Speaker.Text = "Goblin";
                    dialogue.Text = "Ha! Puny mortal, taste the sting\nof a goblin knight!";
                    
                }
                else
                {
                    Goblin.Show();
                    Wizard.Hide();
                    Speaker.Text = "Goblin";
                    dialogue.Text = "Gah! Curse you puny creature!\nLucky strike, you got!";
                    count = 40;
                }
            }
            if (count == 7)
            {
                Wizard.Show();
                Goblin.Hide();
                Speaker.Text = "Wizard";
                dialogue.Text = "You may have lost, but defeat is a\nfleeting shadow of a hero";
            }
            if (count == 8)
            {
                dialogue.Text = "Good luck next time,\nclick next to close the game";
            }
            if (count == 9)
            {
                this.Close();
            }
            if (count == 41)
            {
                Wizard.Show();
                Goblin.Hide();
                Speaker.Text = "Wizard";
                dialogue.Text = "You tried, and you won! Congratulations!\nClick next to move on";
            }
            if (count == 42)
            {
                EastVillage village = new EastVillage();
                this.Hide();
                village.Show();
            }
            if (count == 21)
            {
                diceNum = Random(10);
                if (diceNum <= 3)
                {
                    Goblin.Show();
                    Wizard.Hide();
                    Speaker.Text = "Goblin";
                    dialogue.Text = "You silly human! You thought you could run?";
                }
                else
                {
                    Goblin.Show();
                    Wizard.Hide();
                    Speaker.Text = "Goblin";
                    dialogue.Text = "Yeah that's right! Run away from me,\nThe goblin knight!";
                    count = 30;
                }
            }
            if (count == 22)
            {
                Goblin.Hide();
                Wizard.Show();
                Speaker.Text = "Wizard";
                dialogue.Text = "The goblin decided to fight anyways!\nFear not, you can still attack!";
            }
            if (count == 23)
            {
                dialogue.Text = "Fight back!\nClick next to find out what happens";
                count = 5;
            }
            if (count == 31)
            {
                Goblin.Hide();
                Wizard.Show();
                Speaker.Text = "Wizard";
                dialogue.Text = "Phew! The goblin didn't fight.\nClick next to move on";
            }
            if (count == 32)
            {
                EastVillage village = new EastVillage();
                village.Show();
                this.Hide();
            }

        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            count = 20;
            dialogue.Text = "You chose to flee! Click next to find\nout what happens!";
            Next.Show();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            dialogue.Text = "You chose to fight! Click next to find\nout what happens!";
            Next.Show();
        }

        private void Dice_Value_Click(object sender, EventArgs e)
        {

        }
    }
}
