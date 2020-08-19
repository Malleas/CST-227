namespace MilestoneGUI
{
    partial class Form2
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
            this.turnsLabel = new System.Windows.Forms.Label();
            this.turnsCountLabel = new System.Windows.Forms.Label();
            this.gameBoardPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // turnsLabel
            // 
            this.turnsLabel.AutoSize = true;
            this.turnsLabel.Location = new System.Drawing.Point(568, 32);
            this.turnsLabel.Name = "turnsLabel";
            this.turnsLabel.Size = new System.Drawing.Size(53, 20);
            this.turnsLabel.TabIndex = 0;
            this.turnsLabel.Text = "Turns:";
            // 
            // turnsCountLabel
            // 
            this.turnsCountLabel.AutoSize = true;
            this.turnsCountLabel.Location = new System.Drawing.Point(568, 65);
            this.turnsCountLabel.Name = "turnsCountLabel";
            this.turnsCountLabel.Size = new System.Drawing.Size(0, 20);
            this.turnsCountLabel.TabIndex = 1;
            // 
            // gameBoardPanel
            // 
            this.gameBoardPanel.Location = new System.Drawing.Point(12, 32);
            this.gameBoardPanel.Name = "gameBoardPanel";
            this.gameBoardPanel.Size = new System.Drawing.Size(500, 500);
            this.gameBoardPanel.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.gameBoardPanel);
            this.Controls.Add(this.turnsCountLabel);
            this.Controls.Add(this.turnsLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label turnsLabel;
        private System.Windows.Forms.Label turnsCountLabel;
        private System.Windows.Forms.Panel gameBoardPanel;
    }
}