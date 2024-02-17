namespace CornHacks_Casino
{
    
    public partial class Start : Form
    {
        Random random = new Random();
        public string name = "";
        public int diceNum;
        string[] location = new string[] { "Dragons Lair", "South Mountains", "East Village", "Goblin Hut", "Gold Hoard", "South Mountains" };


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
            diceNum = Random(6);
            Dice_Value.Text = diceNum.ToString();
            Dice_Value.Show();
            Dice.Show();
            Next0.Hide();
            Elf_text1.Hide();
            bjorkNameBox.Hide();
            
            if (diceNum % 2 == 0)
            {
                finalName.Text = "You rolled a " + diceNum + "! You get to keep your name!";
                name = nameTextBox.Text;
            }
            else
            {
                name = "Wobbleknob";
                finalName.Text = "You rolled a " + diceNum + "! Your name is Wobbleknob ";
            }
            Next2.Show();
            Roll_Again.Show();
            nameTextBox.Hide();
            finalName.Show();
        }

        private void finalName_Click(object sender, EventArgs e)
        {

        }

        private void Next2_Click(object sender, EventArgs e)
        {
            diceNum = Random(6);
            Dice_Value.Text = diceNum.ToString();
            finalName.Text = "You rolled a " + diceNum + "! Click next to see where you go!";
            Next2.Hide();
            Next3.Show();
            Roll_Again.Hide();
        }
    }
}