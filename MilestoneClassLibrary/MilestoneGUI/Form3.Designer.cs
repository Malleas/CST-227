namespace MilestoneGUI
{
    partial class Form3
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
            this.highScoreListBox = new System.Windows.Forms.ListBox();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.playAgainLabel = new System.Windows.Forms.Label();
            this.playerInitialsTextBox = new System.Windows.Forms.TextBox();
            this.enterInitialsLabel = new System.Windows.Forms.Label();
            this.saveScoreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // highScoreListBox
            // 
            this.highScoreListBox.FormattingEnabled = true;
            this.highScoreListBox.ItemHeight = 20;
            this.highScoreListBox.Location = new System.Drawing.Point(21, 15);
            this.highScoreListBox.Name = "highScoreListBox";
            this.highScoreListBox.Size = new System.Drawing.Size(364, 384);
            this.highScoreListBox.TabIndex = 0;
            // 
            // yesBtn
            // 
            this.yesBtn.Location = new System.Drawing.Point(428, 208);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(155, 88);
            this.yesBtn.TabIndex = 1;
            this.yesBtn.Text = "Yes!";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Location = new System.Drawing.Point(428, 311);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(155, 88);
            this.noBtn.TabIndex = 2;
            this.noBtn.Text = "No, I Quit!";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // playAgainLabel
            // 
            this.playAgainLabel.AutoSize = true;
            this.playAgainLabel.Location = new System.Drawing.Point(456, 172);
            this.playAgainLabel.Name = "playAgainLabel";
            this.playAgainLabel.Size = new System.Drawing.Size(92, 20);
            this.playAgainLabel.TabIndex = 3;
            this.playAgainLabel.Text = "Play Again?";
            // 
            // playerInitialsTextBox
            // 
            this.playerInitialsTextBox.Location = new System.Drawing.Point(428, 50);
            this.playerInitialsTextBox.Name = "playerInitialsTextBox";
            this.playerInitialsTextBox.Size = new System.Drawing.Size(155, 26);
            this.playerInitialsTextBox.TabIndex = 4;
            // 
            // enterInitialsLabel
            // 
            this.enterInitialsLabel.AutoSize = true;
            this.enterInitialsLabel.Location = new System.Drawing.Point(411, 15);
            this.enterInitialsLabel.Name = "enterInitialsLabel";
            this.enterInitialsLabel.Size = new System.Drawing.Size(195, 20);
            this.enterInitialsLabel.TabIndex = 5;
            this.enterInitialsLabel.Text = "Enter initials to track score";
            // 
            // saveScoreBtn
            // 
            this.saveScoreBtn.Location = new System.Drawing.Point(428, 96);
            this.saveScoreBtn.Name = "saveScoreBtn";
            this.saveScoreBtn.Size = new System.Drawing.Size(155, 42);
            this.saveScoreBtn.TabIndex = 6;
            this.saveScoreBtn.Text = "<- Save Score!";
            this.saveScoreBtn.UseVisualStyleBackColor = true;
            this.saveScoreBtn.Click += new System.EventHandler(this.saveScoreBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.saveScoreBtn);
            this.Controls.Add(this.enterInitialsLabel);
            this.Controls.Add(this.playerInitialsTextBox);
            this.Controls.Add(this.playAgainLabel);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.highScoreListBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox highScoreListBox;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Label playAgainLabel;
        private System.Windows.Forms.TextBox playerInitialsTextBox;
        private System.Windows.Forms.Label enterInitialsLabel;
        private System.Windows.Forms.Button saveScoreBtn;
    }
}