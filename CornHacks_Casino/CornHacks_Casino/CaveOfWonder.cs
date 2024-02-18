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
    public partial class CaveOfWonder : Form
    {
        public int count = 0;
        Random random = new Random();
        public int diceNum;
        public int Random(int max)
        {
            int randomNum = random.Next(1, (max + 1));
            return randomNum;

        }
        public CaveOfWonder()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                dialogue.Text = "You made it this far, you should be proud!";
            }
            if (count == 2)
            {
                dialogue.Text = "It has been a long journey. You got the\ngauntlet of power!";
            }
            if (count == 3)
            {
                dialogue.Text = "You pawn the gauntlet of power.\nClick next to see how much you get";
            }
            if (count == 4)
            {
                diceNum = Random(10);
                if (diceNum <= 5)
                {
                    dialogue.Text = "Turns out the gauntlet was counterfeit.\nYou got 10 dollars";
                }
                else
                {
                    dialogue.Text = "You got a million dollars!";
                }
            }
            if (count == 5)
            {
                if (diceNum <= 5)
                {
                    dialogue.Text = "Maybe it was all for nothing...";
                }
                else
                {
                    dialogue.Text = "You return home a hero. Your courage\nhas inspired all.";
                }
            }
            if (count == 6)
            {
                this.Close();
            }
        }
    }
}
