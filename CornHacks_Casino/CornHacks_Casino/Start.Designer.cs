namespace CornHacks_Casino
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Elf_text1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bjorkNameBox = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.Next0 = new System.Windows.Forms.Button();
            this.Dice = new System.Windows.Forms.PictureBox();
            this.Dice_Value = new System.Windows.Forms.Label();
            this.finalName = new System.Windows.Forms.Label();
            this.Next2 = new System.Windows.Forms.Button();
            this.Roll_Again = new System.Windows.Forms.Label();
            this.Next3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(620, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 493);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Elf_text1
            // 
            this.Elf_text1.AutoSize = true;
            this.Elf_text1.BackColor = System.Drawing.Color.MistyRose;
            this.Elf_text1.Font = new System.Drawing.Font("SimSun", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Elf_text1.Location = new System.Drawing.Point(211, 39);
            this.Elf_text1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Elf_text1.Name = "Elf_text1";
            this.Elf_text1.Size = new System.Drawing.Size(417, 40);
            this.Elf_text1.TabIndex = 3;
            this.Elf_text1.Text = "Welcome to Valdoria!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(226, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 4;
            // 
            // bjorkNameBox
            // 
            this.bjorkNameBox.AutoSize = true;
            this.bjorkNameBox.BackColor = System.Drawing.Color.MistyRose;
            this.bjorkNameBox.Font = new System.Drawing.Font("SimSun", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bjorkNameBox.Location = new System.Drawing.Point(226, 97);
            this.bjorkNameBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bjorkNameBox.Name = "bjorkNameBox";
            this.bjorkNameBox.Size = new System.Drawing.Size(389, 26);
            this.bjorkNameBox.TabIndex = 5;
            this.bjorkNameBox.Text = "I\'m Bjork! What is your name?";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(312, 147);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(210, 32);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.UseWaitCursor = true;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // Next0
            // 
            this.Next0.BackColor = System.Drawing.Color.MistyRose;
            this.Next0.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Next0.Location = new System.Drawing.Point(365, 206);
            this.Next0.Margin = new System.Windows.Forms.Padding(2);
            this.Next0.Name = "Next0";
            this.Next0.Size = new System.Drawing.Size(90, 38);
            this.Next0.TabIndex = 7;
            this.Next0.Text = "Next";
            this.Next0.UseVisualStyleBackColor = false;
            this.Next0.Visible = false;
            this.Next0.Click += new System.EventHandler(this.Next0_Click);
            // 
            // Dice
            // 
            this.Dice.BackColor = System.Drawing.Color.Transparent;
            this.Dice.Image = global::CornHacks_Casino.Properties.Resources.dice;
            this.Dice.Location = new System.Drawing.Point(382, 265);
            this.Dice.Margin = new System.Windows.Forms.Padding(2);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(73, 68);
            this.Dice.TabIndex = 8;
            this.Dice.TabStop = false;
            this.Dice.Visible = false;
            // 
            // Dice_Value
            // 
            this.Dice_Value.AutoSize = true;
            this.Dice_Value.Font = new System.Drawing.Font("SimSun", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dice_Value.Location = new System.Drawing.Point(394, 276);
            this.Dice_Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dice_Value.Name = "Dice_Value";
            this.Dice_Value.Size = new System.Drawing.Size(41, 43);
            this.Dice_Value.TabIndex = 9;
            this.Dice_Value.Text = "3";
            this.Dice_Value.Visible = false;
            // 
            // finalName
            // 
            this.finalName.AutoSize = true;
            this.finalName.BackColor = System.Drawing.Color.MistyRose;
            this.finalName.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finalName.Location = new System.Drawing.Point(141, 152);
            this.finalName.Name = "finalName";
            this.finalName.Size = new System.Drawing.Size(68, 27);
            this.finalName.TabIndex = 10;
            this.finalName.Text = "text";
            this.finalName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.finalName.Visible = false;
            this.finalName.Click += new System.EventHandler(this.finalName_Click);
            // 
            // Next2
            // 
            this.Next2.BackColor = System.Drawing.Color.MistyRose;
            this.Next2.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Next2.Location = new System.Drawing.Point(365, 353);
            this.Next2.Margin = new System.Windows.Forms.Padding(2);
            this.Next2.Name = "Next2";
            this.Next2.Size = new System.Drawing.Size(90, 38);
            this.Next2.TabIndex = 11;
            this.Next2.Text = "Roll";
            this.Next2.UseVisualStyleBackColor = false;
            this.Next2.Visible = false;
            this.Next2.Click += new System.EventHandler(this.Next2_Click);
            // 
            // Roll_Again
            // 
            this.Roll_Again.AutoSize = true;
            this.Roll_Again.BackColor = System.Drawing.Color.MistyRose;
            this.Roll_Again.Font = new System.Drawing.Font("SimSun", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Roll_Again.Location = new System.Drawing.Point(194, 218);
            this.Roll_Again.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Roll_Again.Name = "Roll_Again";
            this.Roll_Again.Size = new System.Drawing.Size(480, 26);
            this.Roll_Again.TabIndex = 12;
            this.Roll_Again.Text = "Roll again to determine where you go";
            this.Roll_Again.Visible = false;
            // 
            // Next3
            // 
            this.Next3.BackColor = System.Drawing.Color.MistyRose;
            this.Next3.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Next3.Location = new System.Drawing.Point(365, 353);
            this.Next3.Margin = new System.Windows.Forms.Padding(2);
            this.Next3.Name = "Next3";
            this.Next3.Size = new System.Drawing.Size(90, 38);
            this.Next3.TabIndex = 13;
            this.Next3.Text = "Next";
            this.Next3.UseVisualStyleBackColor = false;
            this.Next3.Visible = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 469);
            this.Controls.Add(this.Next3);
            this.Controls.Add(this.Roll_Again);
            this.Controls.Add(this.Next2);
            this.Controls.Add(this.finalName);
            this.Controls.Add(this.Dice_Value);
            this.Controls.Add(this.Dice);
            this.Controls.Add(this.Next0);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.bjorkNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Elf_text1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1000, 508);
            this.MinimumSize = new System.Drawing.Size(1000, 508);
            this.Name = "Start";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        public Label Elf_text1;
        public Label label2;
        public Label bjorkNameBox;
        private TextBox nameTextBox;
        private Button Next0;
        private PictureBox Dice;
        private Label Dice_Value;
        private Label finalName;
        private Button Next2;
        public Label Roll_Again;
        private Button Next3;
    }
}