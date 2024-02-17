namespace CornHacks_Casino
{
    
    public partial class Start : Form
    {
        public string name = "";
        public int diceNum;

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
            diceNum = 1;
            Dice_Value.Text = diceNum.ToString();
            Dice_Value.Show();
            Dice.Show();
            Next0.Hide();
            Elf_text1.Hide();
            bjorkNameBox.Hide();
            
            if (diceNum % 2 == 0)
            {
                finalName.Text = "You rolled a " + diceNum + "! You get to keep you name!";
                name = nameTextBox.Text;
            }
            else
            {
                name = "Wobbleknob";
                finalName.Text = "You rolled a " + diceNum + "! Your name is Wobbleknob ";
            }
            
            finalName.Show();
        }

        private void finalName_Click(object sender, EventArgs e)
        {

        }
    }
}