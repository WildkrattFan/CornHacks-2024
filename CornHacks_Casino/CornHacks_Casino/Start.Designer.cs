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
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.Next0 = new System.Windows.Forms.Button();
            this.Dice = new System.Windows.Forms.PictureBox();
            this.Dice_Value = new System.Windows.Forms.Label();
            this.finalName = new System.Windows.Forms.Label();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice)).BeginInit();
            this.panel1.SuspendLayout();
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
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(51, 420);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(210, 32);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.UseWaitCursor = true;
            this.nameTextBox.Visible = false;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // Next0
            // 
            this.Next0.BackColor = System.Drawing.Color.MistyRose;
            this.Next0.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Next0.Location = new System.Drawing.Point(599, 51);
            this.Next0.Margin = new System.Windows.Forms.Padding(2);
            this.Next0.Name = "Next0";
            this.Next0.Size = new System.Drawing.Size(69, 34);
            this.Next0.TabIndex = 7;
            this.Next0.Text = "Next";
            this.Next0.UseVisualStyleBackColor = false;
            this.Next0.Click += new System.EventHandler(this.Next0_Click);
            // 
            // Dice
            // 
            this.Dice.BackColor = System.Drawing.Color.Transparent;
            this.Dice.Image = global::CornHacks_Casino.Properties.Resources.dice;
            this.Dice.Location = new System.Drawing.Point(10, 9);
            this.Dice.Margin = new System.Windows.Forms.Padding(2);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(73, 68);
            this.Dice.TabIndex = 8;
            this.Dice.TabStop = false;
            // 
            // Dice_Value
            // 
            this.Dice_Value.AutoSize = true;
            this.Dice_Value.Font = new System.Drawing.Font("SimSun", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dice_Value.Location = new System.Drawing.Point(27, 20);
            this.Dice_Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dice_Value.Name = "Dice_Value";
            this.Dice_Value.Size = new System.Drawing.Size(41, 43);
            this.Dice_Value.TabIndex = 9;
            this.Dice_Value.Text = "0";
            // 
            // finalName
            // 
            this.finalName.AutoSize = true;
            this.finalName.BackColor = System.Drawing.Color.Transparent;
            this.finalName.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finalName.Location = new System.Drawing.Point(3, 17);
            this.finalName.Name = "finalName";
            this.finalName.Size = new System.Drawing.Size(26, 27);
            this.finalName.TabIndex = 10;
            this.finalName.Text = " ";
            this.finalName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.finalName.Click += new System.EventHandler(this.finalName_Click);
            // 
            // YesBtn
            // 
            this.YesBtn.BackColor = System.Drawing.Color.MistyRose;
            this.YesBtn.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YesBtn.Location = new System.Drawing.Point(171, 420);
            this.YesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(90, 38);
            this.YesBtn.TabIndex = 13;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = false;
            this.YesBtn.Visible = false;
            // 
            // NoBtn
            // 
            this.NoBtn.BackColor = System.Drawing.Color.MistyRose;
            this.NoBtn.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoBtn.Location = new System.Drawing.Point(51, 420);
            this.NoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(90, 38);
            this.NoBtn.TabIndex = 14;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = false;
            this.NoBtn.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.finalName);
            this.panel1.Controls.Add(this.Next0);
            this.panel1.Location = new System.Drawing.Point(304, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 104);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Wizard";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.Dice_Value);
            this.Controls.Add(this.Dice);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1000, 508);
            this.MinimumSize = new System.Drawing.Size(1000, 508);
            this.Name = "Start";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        public Label label2;
        private TextBox nameTextBox;
        private Button Next0;
        private PictureBox Dice;
        private Label Dice_Value;
        private Label finalName;
        private Button YesBtn;
        private Button NoBtn;
        private Panel panel1;
        private Label label1;
    }
}