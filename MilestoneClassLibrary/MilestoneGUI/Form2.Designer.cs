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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.turnsLabel = new System.Windows.Forms.Label();
            this.turnsCountLabel = new System.Windows.Forms.Label();
            this.gameBoardPanel = new System.Windows.Forms.Panel();
            this.gameImageList = new System.Windows.Forms.ImageList(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.displayTimerLabel = new System.Windows.Forms.Label();
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
            // gameImageList
            // 
            this.gameImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("gameImageList.ImageStream")));
            this.gameImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.gameImageList.Images.SetKeyName(0, "minesweeper bomb.png");
            this.gameImageList.Images.SetKeyName(1, "flag_icon.png");
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Location = new System.Drawing.Point(546, 101);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(105, 20);
            this.elapsedTimeLabel.TabIndex = 3;
            this.elapsedTimeLabel.Text = "Elapsed Time";
            // 
            // displayTimerLabel
            // 
            this.displayTimerLabel.AutoSize = true;
            this.displayTimerLabel.Location = new System.Drawing.Point(568, 134);
            this.displayTimerLabel.Name = "displayTimerLabel";
            this.displayTimerLabel.Size = new System.Drawing.Size(0, 20);
            this.displayTimerLabel.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.displayTimerLabel);
            this.Controls.Add(this.elapsedTimeLabel);
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
        private System.Windows.Forms.ImageList gameImageList;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private System.Windows.Forms.Label displayTimerLabel;
    }
}