namespace CreatePersonApp
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
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.loadFromFileBtn = new System.Windows.Forms.Button();
            this.saveToFileBtn = new System.Windows.Forms.Button();
            this.addToListBtn = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // peopleListBox
            // 
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.ItemHeight = 20;
            this.peopleListBox.Location = new System.Drawing.Point(283, 43);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(476, 364);
            this.peopleListBox.TabIndex = 19;
            // 
            // loadFromFileBtn
            // 
            this.loadFromFileBtn.Location = new System.Drawing.Point(105, 319);
            this.loadFromFileBtn.Name = "loadFromFileBtn";
            this.loadFromFileBtn.Size = new System.Drawing.Size(126, 39);
            this.loadFromFileBtn.TabIndex = 18;
            this.loadFromFileBtn.Text = "Load from File";
            this.loadFromFileBtn.UseVisualStyleBackColor = true;
            // 
            // saveToFileBtn
            // 
            this.saveToFileBtn.Location = new System.Drawing.Point(105, 279);
            this.saveToFileBtn.Name = "saveToFileBtn";
            this.saveToFileBtn.Size = new System.Drawing.Size(126, 34);
            this.saveToFileBtn.TabIndex = 17;
            this.saveToFileBtn.Text = "Save to File";
            this.saveToFileBtn.UseVisualStyleBackColor = true;
            // 
            // addToListBtn
            // 
            this.addToListBtn.Location = new System.Drawing.Point(42, 169);
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Size = new System.Drawing.Size(207, 43);
            this.addToListBtn.TabIndex = 16;
            this.addToListBtn.Text = "Add to List ->";
            this.addToListBtn.UseVisualStyleBackColor = true;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(149, 120);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(100, 26);
            this.urlTextBox.TabIndex = 15;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(149, 81);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.lastNameTextBox.TabIndex = 14;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(149, 43);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.firstNameTextBox.TabIndex = 13;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(114, 120);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 20);
            this.urlLabel.TabIndex = 12;
            this.urlLabel.Text = "Url";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(57, 87);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(57, 49);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameLabel.TabIndex = 10;
            this.firstNameLabel.Text = "First Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.peopleListBox);
            this.Controls.Add(this.loadFromFileBtn);
            this.Controls.Add(this.saveToFileBtn);
            this.Controls.Add(this.addToListBtn);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleListBox;
        private System.Windows.Forms.Button loadFromFileBtn;
        private System.Windows.Forms.Button saveToFileBtn;
        private System.Windows.Forms.Button addToListBtn;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
    }
}

