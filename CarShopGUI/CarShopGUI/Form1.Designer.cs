namespace CarShopGUI
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
            this.createACarGroupBox = new System.Windows.Forms.GroupBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.createCarBtn = new System.Windows.Forms.Button();
            this.carInventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.carInventoryListBox = new System.Windows.Forms.ListBox();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.shoppingCartGroupBox = new System.Windows.Forms.GroupBox();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.createACarGroupBox.SuspendLayout();
            this.carInventoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createACarGroupBox
            // 
            this.createACarGroupBox.Controls.Add(this.colorTextBox);
            this.createACarGroupBox.Controls.Add(this.yearTextBox);
            this.createACarGroupBox.Controls.Add(this.colorLabel);
            this.createACarGroupBox.Controls.Add(this.yearLabel);
            this.createACarGroupBox.Controls.Add(this.priceTextBox);
            this.createACarGroupBox.Controls.Add(this.modelTextBox);
            this.createACarGroupBox.Controls.Add(this.makeTextBox);
            this.createACarGroupBox.Controls.Add(this.priceLabel);
            this.createACarGroupBox.Controls.Add(this.modelLabel);
            this.createACarGroupBox.Controls.Add(this.makeLabel);
            this.createACarGroupBox.Location = new System.Drawing.Point(75, 46);
            this.createACarGroupBox.Name = "createACarGroupBox";
            this.createACarGroupBox.Size = new System.Drawing.Size(202, 214);
            this.createACarGroupBox.TabIndex = 0;
            this.createACarGroupBox.TabStop = false;
            this.createACarGroupBox.Text = "Create A Car";
            this.createACarGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(7, 46);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(52, 20);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Make:";
            this.makeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(7, 80);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(56, 20);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Model:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(7, 110);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 20);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price:";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(66, 39);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 26);
            this.makeTextBox.TabIndex = 3;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(66, 72);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 26);
            this.modelTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(66, 103);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 26);
            this.priceTextBox.TabIndex = 5;
            // 
            // createCarBtn
            // 
            this.createCarBtn.Location = new System.Drawing.Point(141, 266);
            this.createCarBtn.Name = "createCarBtn";
            this.createCarBtn.Size = new System.Drawing.Size(100, 42);
            this.createCarBtn.TabIndex = 6;
            this.createCarBtn.Text = "Create Car";
            this.createCarBtn.UseVisualStyleBackColor = true;
            this.createCarBtn.Click += new System.EventHandler(this.createCarBtn_Click);
            // 
            // carInventoryGroupBox
            // 
            this.carInventoryGroupBox.Controls.Add(this.carInventoryListBox);
            this.carInventoryGroupBox.Location = new System.Drawing.Point(284, 46);
            this.carInventoryGroupBox.Name = "carInventoryGroupBox";
            this.carInventoryGroupBox.Size = new System.Drawing.Size(200, 365);
            this.carInventoryGroupBox.TabIndex = 1;
            this.carInventoryGroupBox.TabStop = false;
            this.carInventoryGroupBox.Text = "Car Inventory";
            // 
            // carInventoryListBox
            // 
            this.carInventoryListBox.FormattingEnabled = true;
            this.carInventoryListBox.ItemHeight = 20;
            this.carInventoryListBox.Location = new System.Drawing.Point(7, 26);
            this.carInventoryListBox.Name = "carInventoryListBox";
            this.carInventoryListBox.Size = new System.Drawing.Size(187, 324);
            this.carInventoryListBox.TabIndex = 0;
            this.carInventoryListBox.SelectedIndexChanged += new System.EventHandler(this.carInventoryListBox_SelectedIndexChanged);
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 20;
            this.shoppingCartListBox.Location = new System.Drawing.Point(642, 72);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(188, 324);
            this.shoppingCartListBox.TabIndex = 2;
            // 
            // shoppingCartGroupBox
            // 
            this.shoppingCartGroupBox.Location = new System.Drawing.Point(636, 46);
            this.shoppingCartGroupBox.Name = "shoppingCartGroupBox";
            this.shoppingCartGroupBox.Size = new System.Drawing.Size(200, 365);
            this.shoppingCartGroupBox.TabIndex = 3;
            this.shoppingCartGroupBox.TabStop = false;
            this.shoppingCartGroupBox.Text = "Shopping Cart";
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.Location = new System.Drawing.Point(496, 209);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(128, 41);
            this.addToCartBtn.TabIndex = 4;
            this.addToCartBtn.Text = "Add to Cart ->";
            this.addToCartBtn.UseVisualStyleBackColor = true;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Location = new System.Drawing.Point(673, 417);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(114, 42);
            this.checkoutBtn.TabIndex = 5;
            this.checkoutBtn.Text = "Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(632, 494);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(85, 20);
            this.totalCostLabel.TabIndex = 6;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.AutoSize = true;
            this.totalCostOutputLabel.Location = new System.Drawing.Point(736, 494);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.totalCostOutputLabel.TabIndex = 7;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(8, 139);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(47, 20);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Year:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(5, 173);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(50, 20);
            this.colorLabel.TabIndex = 8;
            this.colorLabel.Text = "Color:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(66, 136);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 26);
            this.yearTextBox.TabIndex = 9;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(66, 169);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 26);
            this.colorTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 559);
            this.Controls.Add(this.totalCostOutputLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.createCarBtn);
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.shoppingCartGroupBox);
            this.Controls.Add(this.carInventoryGroupBox);
            this.Controls.Add(this.createACarGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.createCarGroupBox_Load);
            this.createACarGroupBox.ResumeLayout(false);
            this.createACarGroupBox.PerformLayout();
            this.carInventoryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox createACarGroupBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Button createCarBtn;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.GroupBox carInventoryGroupBox;
        private System.Windows.Forms.ListBox carInventoryListBox;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.GroupBox shoppingCartGroupBox;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostOutputLabel;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label yearLabel;
    }
}

