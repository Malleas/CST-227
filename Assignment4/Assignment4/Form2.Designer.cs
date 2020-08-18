namespace Assignment4
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
            this.heroListBox = new System.Windows.Forms.ListBox();
            this.heroLabel = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // heroListBox
            // 
            this.heroListBox.FormattingEnabled = true;
            this.heroListBox.ItemHeight = 20;
            this.heroListBox.Location = new System.Drawing.Point(33, 64);
            this.heroListBox.Name = "heroListBox";
            this.heroListBox.Size = new System.Drawing.Size(377, 364);
            this.heroListBox.TabIndex = 0;
            this.heroListBox.SelectedIndexChanged += new System.EventHandler(this.heroListBox_SelectedIndexChanged);
            // 
            // heroLabel
            // 
            this.heroLabel.AutoSize = true;
            this.heroLabel.Location = new System.Drawing.Point(29, 41);
            this.heroLabel.Name = "heroLabel";
            this.heroLabel.Size = new System.Drawing.Size(52, 20);
            this.heroLabel.TabIndex = 1;
            this.heroLabel.Text = "Heros";
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Location = new System.Drawing.Point(435, 41);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(52, 20);
            this.aboutLabel.TabIndex = 2;
            this.aboutLabel.Text = "About";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(33, 434);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(155, 52);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.Location = new System.Drawing.Point(439, 65);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(652, 363);
            this.aboutTextBox.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 531);
            this.Controls.Add(this.aboutTextBox);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.heroLabel);
            this.Controls.Add(this.heroListBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox heroListBox;
        private System.Windows.Forms.Label heroLabel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox aboutTextBox;
    }
}