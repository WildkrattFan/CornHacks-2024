namespace CornHacks_Casino
{
    partial class GoblinHut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoblinHut));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dialogue = new System.Windows.Forms.Label();
            this.Speaker = new System.Windows.Forms.Label();
            this.finalName = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Wizard = new System.Windows.Forms.PictureBox();
            this.Dice_Value = new System.Windows.Forms.Label();
            this.Dice = new System.Windows.Forms.PictureBox();
            this.Goblin = new System.Windows.Forms.PictureBox();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goblin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dialogue);
            this.panel1.Controls.Add(this.Speaker);
            this.panel1.Controls.Add(this.finalName);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Location = new System.Drawing.Point(308, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 104);
            this.panel1.TabIndex = 19;
            // 
            // dialogue
            // 
            this.dialogue.AutoSize = true;
            this.dialogue.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dialogue.Location = new System.Drawing.Point(7, 22);
            this.dialogue.Name = "dialogue";
            this.dialogue.Size = new System.Drawing.Size(488, 27);
            this.dialogue.TabIndex = 17;
            this.dialogue.Text = "It seems you got lost on your way!";
            // 
            // Speaker
            // 
            this.Speaker.AutoSize = true;
            this.Speaker.Location = new System.Drawing.Point(-1, 0);
            this.Speaker.Name = "Speaker";
            this.Speaker.Size = new System.Drawing.Size(49, 17);
            this.Speaker.TabIndex = 16;
            this.Speaker.Text = "Wizard";
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
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.MistyRose;
            this.Next.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Next.Location = new System.Drawing.Point(599, 51);
            this.Next.Margin = new System.Windows.Forms.Padding(2);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(69, 34);
            this.Next.TabIndex = 7;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Wizard
            // 
            this.Wizard.BackColor = System.Drawing.Color.Transparent;
            this.Wizard.Image = ((System.Drawing.Image)(resources.GetObject("Wizard.Image")));
            this.Wizard.Location = new System.Drawing.Point(624, 36);
            this.Wizard.Name = "Wizard";
            this.Wizard.Size = new System.Drawing.Size(379, 493);
            this.Wizard.TabIndex = 18;
            this.Wizard.TabStop = false;
            // 
            // Dice_Value
            // 
            this.Dice_Value.AutoSize = true;
            this.Dice_Value.Font = new System.Drawing.Font("SimSun", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dice_Value.Location = new System.Drawing.Point(35, 23);
            this.Dice_Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dice_Value.Name = "Dice_Value";
            this.Dice_Value.Size = new System.Drawing.Size(41, 43);
            this.Dice_Value.TabIndex = 21;
            this.Dice_Value.Text = "0";
            this.Dice_Value.Click += new System.EventHandler(this.Dice_Value_Click);
            // 
            // Dice
            // 
            this.Dice.BackColor = System.Drawing.Color.Transparent;
            this.Dice.Image = global::CornHacks_Casino.Properties.Resources.dice;
            this.Dice.Location = new System.Drawing.Point(18, 12);
            this.Dice.Margin = new System.Windows.Forms.Padding(2);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(73, 68);
            this.Dice.TabIndex = 20;
            this.Dice.TabStop = false;
            // 
            // Goblin
            // 
            this.Goblin.BackColor = System.Drawing.Color.Transparent;
            this.Goblin.Image = ((System.Drawing.Image)(resources.GetObject("Goblin.Image")));
            this.Goblin.Location = new System.Drawing.Point(278, 107);
            this.Goblin.Name = "Goblin";
            this.Goblin.Size = new System.Drawing.Size(379, 493);
            this.Goblin.TabIndex = 22;
            this.Goblin.TabStop = false;
            this.Goblin.Visible = false;
            // 
            // YesBtn
            // 
            this.YesBtn.BackColor = System.Drawing.Color.MistyRose;
            this.YesBtn.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YesBtn.Location = new System.Drawing.Point(178, 402);
            this.YesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(95, 53);
            this.YesBtn.TabIndex = 18;
            this.YesBtn.Text = "Fight";
            this.YesBtn.UseVisualStyleBackColor = false;
            this.YesBtn.Visible = false;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // NoBtn
            // 
            this.NoBtn.BackColor = System.Drawing.Color.MistyRose;
            this.NoBtn.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoBtn.Location = new System.Drawing.Point(53, 402);
            this.NoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(92, 53);
            this.NoBtn.TabIndex = 19;
            this.NoBtn.Text = "Flee";
            this.NoBtn.UseVisualStyleBackColor = false;
            this.NoBtn.Visible = false;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // GoblinHut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CornHacks_Casino.Properties.Resources.goblinHut;
            this.ClientSize = new System.Drawing.Size(984, 469);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.Dice_Value);
            this.Controls.Add(this.Dice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Wizard);
            this.Controls.Add(this.Goblin);
            this.MaximumSize = new System.Drawing.Size(1000, 508);
            this.MinimumSize = new System.Drawing.Size(1000, 508);
            this.Name = "GoblinHut";
            this.Text = "GoblinHut";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goblin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label dialogue;
        private Label Speaker;
        private Label finalName;
        private Button Next;
        private PictureBox Wizard;
        private Label Dice_Value;
        private PictureBox Dice;
        private PictureBox Goblin;
        private Button YesBtn;
        private Button NoBtn;
    }
}