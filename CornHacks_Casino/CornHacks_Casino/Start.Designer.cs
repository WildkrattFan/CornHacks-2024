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
            this.next1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Elf_text1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bjorkNameBox = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.Next0 = new System.Windows.Forms.Button();
            this.Dice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(615, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 618);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // next1
            // 
            this.next1.BackColor = System.Drawing.SystemColors.Info;
            this.next1.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.next1.Location = new System.Drawing.Point(915, 595);
            this.next1.Margin = new System.Windows.Forms.Padding(4);
            this.next1.Name = "next1";
            this.next1.Size = new System.Drawing.Size(126, 48);
            this.next1.TabIndex = 1;
            this.next1.Text = "NEXT";
            this.next1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Elf_text1
            // 
            this.Elf_text1.AutoSize = true;
            this.Elf_text1.BackColor = System.Drawing.Color.MistyRose;
            this.Elf_text1.Font = new System.Drawing.Font("SimSun", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Elf_text1.Location = new System.Drawing.Point(271, 48);
            this.Elf_text1.Name = "Elf_text1";
            this.Elf_text1.Size = new System.Drawing.Size(522, 50);
            this.Elf_text1.TabIndex = 3;
            this.Elf_text1.Text = "Welcome to Valdoria!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(291, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 4;
            // 
            // bjorkNameBox
            // 
            this.bjorkNameBox.AutoSize = true;
            this.bjorkNameBox.BackColor = System.Drawing.Color.MistyRose;
            this.bjorkNameBox.Font = new System.Drawing.Font("SimSun", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bjorkNameBox.Location = new System.Drawing.Point(291, 120);
            this.bjorkNameBox.Name = "bjorkNameBox";
            this.bjorkNameBox.Size = new System.Drawing.Size(479, 33);
            this.bjorkNameBox.TabIndex = 5;
            this.bjorkNameBox.Text = "I\'m Bjork! What is your name?";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(396, 182);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(269, 38);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.UseWaitCursor = true;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // Next0
            // 
            this.Next0.BackColor = System.Drawing.Color.MistyRose;
            this.Next0.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Next0.Location = new System.Drawing.Point(474, 254);
            this.Next0.Name = "Next0";
            this.Next0.Size = new System.Drawing.Size(116, 47);
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
            this.Dice.Location = new System.Drawing.Point(491, 327);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(174, 154);
            this.Dice.TabIndex = 8;
            this.Dice.TabStop = false;
            this.Dice.Visible = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1082, 573);
            this.Controls.Add(this.Dice);
            this.Controls.Add(this.Next0);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.bjorkNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Elf_text1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.next1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1100, 620);
            this.MinimumSize = new System.Drawing.Size(1100, 620);
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
        private Button next1;
        private Label label1;
        public Label Elf_text1;
        public Label label2;
        public Label bjorkNameBox;
        private TextBox nameTextBox;
        private Button Next0;
        private PictureBox Dice;
    }
}