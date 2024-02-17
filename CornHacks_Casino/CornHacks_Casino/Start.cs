namespace CornHacks_Casino
{
    
    public partial class Start : Form
    {
        Random random = new Random();
        public string name = "";
        public int diceNum;
        public string[] location = new string[] { "Dragons Lair", "South Mountains", "East Village", "Goblin Hut", "Gold Hoard", "South Mountains" };
        public int count = 0;


        public int Random(int max)
        {
            int randomNum = random.Next(1, (max + 1));
            return randomNum;
            
        }

        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!nameTextBox.Text.Equals(""))
            {
                Next0.Show();
            }
            if (nameTextBox.Text.Equals(""))
            {
                Next0.Hide();
            }
        }

        private void Next0_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                finalName.Text = "Greetings Traveler!";
            }
            if (count == 2)
            {
                finalName.Text = "Welcome to my humble Abode!";
            }
            if (count == 3)
            {
                finalName.Text = "What should I call you?";
                nameTextBox.Show();
                Next0.Hide();
            }
            if (count == 4)
            {
                diceNum = Random(6);
                Dice_Value.Text = diceNum.ToString();
                Dice_Value.Show();
                Dice.Show();
                nameTextBox.Hide();
 
                name = nameTextBox.Text;
                if (diceNum % 2 == 0)
                {
                    finalName.Text = name + " is a terrible name!\n I will call you WobbleKnob";
                    name = "Wobbleknob";
                }
                else
                {
                    finalName.Text = "Nice to meet you, " + name + "!";
                }
            }
            if (count == 5)
            {
                finalName.Text = name + ", I have a quest for you.";
            }
            if (count == 6)
            {
                finalName.Text = "I need you to travel north to the cave \nof wonders and get the gauntlet of power";
            }
            
            if (count == 7)
            {
                finalName.Text = "Are you up for the challenge?";
                YesBtn.Show();
                NoBtn.Show();
                Next0.Hide();
            }
        }

        private void finalName_Click(object sender, EventArgs e)
        {

        }

        private void Next2_Click(object sender, EventArgs e)
        {
           
        }
    }
}