namespace StopWatchApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.displayTimerLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreValueLabel = new System.Windows.Forms.Label();
            this.gameBoardBtn = new System.Windows.Forms.Button();
            this.targetBtn = new System.Windows.Forms.Button();
            this.playAgainBtn = new System.Windows.Forms.Button();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.highScoreValueLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.levelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(629, 261);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(133, 34);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(629, 301);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(133, 33);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // displayTimerLabel
            // 
            this.displayTimerLabel.AutoSize = true;
            this.displayTimerLabel.Location = new System.Drawing.Point(634, 72);
            this.displayTimerLabel.Name = "displayTimerLabel";
            this.displayTimerLabel.Size = new System.Drawing.Size(0, 20);
            this.displayTimerLabel.TabIndex = 3;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Location = new System.Drawing.Point(625, 33);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(105, 20);
            this.elapsedTimeLabel.TabIndex = 5;
            this.elapsedTimeLabel.Text = "Elapsed Time";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(625, 115);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(51, 20);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Score";
            // 
            // scoreValueLabel
            // 
            this.scoreValueLabel.AutoSize = true;
            this.scoreValueLabel.Location = new System.Drawing.Point(634, 148);
            this.scoreValueLabel.Name = "scoreValueLabel";
            this.scoreValueLabel.Size = new System.Drawing.Size(0, 20);
            this.scoreValueLabel.TabIndex = 7;
            // 
            // gameBoardBtn
            // 
            this.gameBoardBtn.BackColor = System.Drawing.Color.White;
            this.gameBoardBtn.ImageIndex = 0;
            this.gameBoardBtn.Location = new System.Drawing.Point(12, 12);
            this.gameBoardBtn.Name = "gameBoardBtn";
            this.gameBoardBtn.Size = new System.Drawing.Size(592, 514);
            this.gameBoardBtn.TabIndex = 5;
            this.gameBoardBtn.UseVisualStyleBackColor = false;
            this.gameBoardBtn.Click += new System.EventHandler(this.gameBoardBtn_Click);
            // 
            // targetBtn
            // 
            this.targetBtn.Location = new System.Drawing.Point(236, 218);
            this.targetBtn.Name = "targetBtn";
            this.targetBtn.Size = new System.Drawing.Size(100, 100);
            this.targetBtn.TabIndex = 4;
            this.targetBtn.Text = "Target";
            this.targetBtn.UseVisualStyleBackColor = true;
            this.targetBtn.Click += new System.EventHandler(this.targetBtn_Click);
            // 
            // playAgainBtn
            // 
            this.playAgainBtn.BackColor = System.Drawing.Color.Green;
            this.playAgainBtn.ForeColor = System.Drawing.Color.White;
            this.playAgainBtn.Location = new System.Drawing.Point(629, 375);
            this.playAgainBtn.Name = "playAgainBtn";
            this.playAgainBtn.Size = new System.Drawing.Size(132, 92);
            this.playAgainBtn.TabIndex = 8;
            this.playAgainBtn.Text = "Play Again!";
            this.playAgainBtn.UseVisualStyleBackColor = false;
            this.playAgainBtn.Visible = false;
            this.playAgainBtn.Click += new System.EventHandler(this.playAgainBtn_Click);
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Location = new System.Drawing.Point(625, 177);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(88, 20);
            this.highScoreLabel.TabIndex = 10;
            this.highScoreLabel.Text = "High Score";
            // 
            // highScoreValueLabel
            // 
            this.highScoreValueLabel.AutoSize = true;
            this.highScoreValueLabel.Location = new System.Drawing.Point(634, 206);
            this.highScoreValueLabel.Name = "highScoreValueLabel";
            this.highScoreValueLabel.Size = new System.Drawing.Size(0, 20);
            this.highScoreValueLabel.TabIndex = 11;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Untitled.png");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(629, 505);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(0, 20);
            this.levelLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.highScoreValueLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.playAgainBtn);
            this.Controls.Add(this.targetBtn);
            this.Controls.Add(this.gameBoardBtn);
            this.Controls.Add(this.scoreValueLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.elapsedTimeLabel);
            this.Controls.Add(this.displayTimerLabel);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label displayTimerLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreValueLabel;
        private System.Windows.Forms.Button gameBoardBtn;
        private System.Windows.Forms.Button targetBtn;
        private System.Windows.Forms.Button playAgainBtn;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label highScoreValueLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label levelLabel;
    }
}

