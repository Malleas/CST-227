namespace ChessBoardGUIApp
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.pieceComboBox = new System.Windows.Forms.ComboBox();
            this.gameBoardPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(398, 13);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Select a type of chess piece and then click the grid.  I will show you all legal " +
    "moves";
            // 
            // pieceComboBox
            // 
            this.pieceComboBox.FormattingEnabled = true;
            this.pieceComboBox.Items.AddRange(new object[] {
            "Knight",
            "King",
            "Rook",
            "Bishop",
            "Queen"});
            this.pieceComboBox.Location = new System.Drawing.Point(441, 6);
            this.pieceComboBox.Name = "pieceComboBox";
            this.pieceComboBox.Size = new System.Drawing.Size(121, 21);
            this.pieceComboBox.TabIndex = 1;
            this.pieceComboBox.SelectedIndexChanged += new System.EventHandler(this.pieceComboBox_SelectedIndexChanged);
            // 
            // gameBoardPanel
            // 
            this.gameBoardPanel.Location = new System.Drawing.Point(43, 49);
            this.gameBoardPanel.Name = "gameBoardPanel";
            this.gameBoardPanel.Size = new System.Drawing.Size(500, 500);
            this.gameBoardPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.gameBoardPanel);
            this.Controls.Add(this.pieceComboBox);
            this.Controls.Add(this.instructionsLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.ComboBox pieceComboBox;
        private System.Windows.Forms.Panel gameBoardPanel;
    }
}

