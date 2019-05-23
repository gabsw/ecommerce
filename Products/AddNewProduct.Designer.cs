namespace ecommerce
{
    partial class AddNewProduct
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(288, 280);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(66, 25);
            this.cancelButton.TabIndex = 47;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(179, 280);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 25);
            this.clearButton.TabIndex = 46;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(63, 280);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(66, 25);
            this.submitButton.TabIndex = 45;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Description";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(167, 97);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(205, 20);
            this.DescriptionBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Fill all the information below:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(167, 60);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(205, 20);
            this.NameBox.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Category";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(167, 140);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(205, 21);
            this.categoryBox.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Seller";
            // 
            // userBox
            // 
            this.userBox.FormattingEnabled = true;
            this.userBox.Location = new System.Drawing.Point(167, 184);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(205, 21);
            this.userBox.TabIndex = 53;
            // 
            // AddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Name = "AddNewProduct";
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.AddNewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userBox;
    }
}