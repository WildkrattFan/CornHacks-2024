namespace CornHacks_Casino
{
    partial class EastVillage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EastVillage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dialogue = new System.Windows.Forms.Label();
            this.Speaker = new System.Windows.Forms.Label();
            this.finalName = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Wizard = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wizard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dialogue);
            this.panel1.Controls.Add(this.Speaker);
            this.panel1.Controls.Add(this.finalName);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Location = new System.Drawing.Point(302, 367);
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
            this.dialogue.Size = new System.Drawing.Size(544, 27);
            this.dialogue.TabIndex = 17;
            this.dialogue.Text = "Oh no! You ended up in a dragons lair!";
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
            // 
            // Wizard
            // 
            this.Wizard.BackColor = System.Drawing.Color.Transparent;
            this.Wizard.Image = ((System.Drawing.Image)(resources.GetObject("Wizard.Image")));
            this.Wizard.Location = new System.Drawing.Point(618, 34);
            this.Wizard.Name = "Wizard";
            this.Wizard.Size = new System.Drawing.Size(379, 493);
            this.Wizard.TabIndex = 18;
            this.Wizard.TabStop = false;
            // 
            // EastVillage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CornHacks_Casino.Properties.Resources.village;
            this.ClientSize = new System.Drawing.Size(984, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Wizard);
            this.MaximumSize = new System.Drawing.Size(1000, 508);
            this.MinimumSize = new System.Drawing.Size(1000, 508);
            this.Name = "EastVillage";
            this.Text = "EastVillage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wizard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label dialogue;
        private Label Speaker;
        private Label finalName;
        private Button Next;
        private PictureBox Wizard;
    }
}