namespace TextFileDataAccessDemoGUIApp
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
            this.loadFromFileBtn = new System.Windows.Forms.Button();
            this.personsListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addToListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadFromFileBtn
            // 
            this.loadFromFileBtn.Location = new System.Drawing.Point(62, 334);
            this.loadFromFileBtn.Name = "loadFromFileBtn";
            this.loadFromFileBtn.Size = new System.Drawing.Size(126, 35);
            this.loadFromFileBtn.TabIndex = 29;
            this.loadFromFileBtn.Text = "Load from File";
            this.loadFromFileBtn.UseVisualStyleBackColor = true;
            this.loadFromFileBtn.Click += new System.EventHandler(this.loadFromFileBtn_Click);
            // 
            // personsListBox
            // 
            this.personsListBox.BackColor = System.Drawing.SystemColors.Window;
            this.personsListBox.FormattingEnabled = true;
            this.personsListBox.ItemHeight = 20;
            this.personsListBox.Location = new System.Drawing.Point(251, 23);
            this.personsListBox.Name = "personsListBox";
            this.personsListBox.Size = new System.Drawing.Size(529, 404);
            this.personsListBox.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 35);
            this.button2.TabIndex = 27;
            this.button2.Text = "Save to File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(113, 91);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(100, 26);
            this.urlTextBox.TabIndex = 26;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(113, 56);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.lastNameTextBox.TabIndex = 25;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(113, 23);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.firstNameTextBox.TabIndex = 24;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(78, 97);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 20);
            this.urlLabel.TabIndex = 23;
            this.urlLabel.Text = "Url";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(21, 62);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 22;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(21, 29);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameLabel.TabIndex = 21;
            this.firstNameLabel.Text = "First Name";
            // 
            // addToListBtn
            // 
            this.addToListBtn.Location = new System.Drawing.Point(25, 148);
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Size = new System.Drawing.Size(202, 49);
            this.addToListBtn.TabIndex = 20;
            this.addToListBtn.Text = "Add To List ->";
            this.addToListBtn.UseVisualStyleBackColor = true;
            this.addToListBtn.Click += new System.EventHandler(this.addToListBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadFromFileBtn);
            this.Controls.Add(this.personsListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.addToListBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFromFileBtn;
        private System.Windows.Forms.ListBox personsListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button addToListBtn;
    }
}

