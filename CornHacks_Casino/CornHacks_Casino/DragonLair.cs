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
    public partial class DragonLair : Form
    {
        public int count = 0;
        public int diceNum;
        Random random = new Random();

        public int Random(int max)
        {
            int randomNum = random.Next(1, (max + 1));
            return randomNum;

        }

        public DragonLair()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            bool isDragon;
            SouthMountains mountains = new SouthMountains();
            count++;
            if (count == 1)
            {
                
                diceNum = Random(10);
                
                
            }
            if (diceNum % 2 == 0) //50 percent chance
            {
                isDragon = true;
            }
            else
            {
                isDragon = false;
            }
            if (count == 2)
            {
                if (isDragon == true) //option 1 face the dragon
                {
                    Dragon.Show();
                    Wizard.Hide();
                    Speaker.Text = "Dragon";
                    dialogue.Text = "RAWRRRRRRRR";
                }
                else
                {
                    count = 20; //option 2 dragon isn't here
                    dialogue.Text = "The dragon isn't here!\nHurry and leave!";
                }
            }
            if (count == 21)
            {
                this.Hide();
                mountains.Show();
            }
            if (count == 3)
            {
                Dragon.Hide();
                Wizard.Show();
                dialogue.Text = "The dragon is here! Click next to roll\nthe dice and see what you do!";
                Speaker.Text = "Wizard";

            }
            if (count == 4)
            {
                diceNum = Random(10);
                if (diceNum == 1)
                {
                    Dragon.Show();
                    Wizard.Hide();
                    Speaker.Text = "";
                    dialogue.Text = "You chose to fight the dragon, you won!\nclick next to move on.";
                    count = 30;
                }
                if (diceNum == 2)
                {
                    Dragon.Show();
                    Wizard.Hide();
                    Speaker.Text = "";
                    dialogue.Text = "You tried to escape and died.\nClick next to close.";
                    count = 40;
                }
                if (diceNum <= 5 && diceNum >= 3)
                {
                    dialogue.Text = "You escaped and survived!\nClick next to move on.";
                    count = 30;
                }
                if (diceNum >= 6 && diceNum <= 10)
                {
                    dialogue.Text = "You tried to fight but died.\nClick next to close";
                    count = 40;
                    Dragon.Show();
                    Wizard.Hide();
                    
                }
                if (count == 31)
                {
                    this.Hide();
                    mountains.Show();
                }
                if (count == 41)
                {
                    this.Close();
                }
                Dice_Value.Text = diceNum.ToString();
            }
           
        }
    }
}
