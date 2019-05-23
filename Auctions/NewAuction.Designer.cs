namespace ecommerce
{
    partial class NewAuction
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
            this.seller_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.product_code_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bidBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.beginning_dtp = new System.Windows.Forms.DateTimePicker();
            this.finish_dtp = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // seller_label
            // 
            this.seller_label.AutoSize = true;
            this.seller_label.Location = new System.Drawing.Point(172, 62);
            this.seller_label.Name = "seller_label";
            this.seller_label.Size = new System.Drawing.Size(35, 13);
            this.seller_label.TabIndex = 18;
            this.seller_label.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "User name Seller:";
            // 
            // product_code_label
            // 
            this.product_code_label.AutoSize = true;
            this.product_code_label.Location = new System.Drawing.Point(172, 31);
            this.product_code_label.Name = "product_code_label";
            this.product_code_label.Size = new System.Drawing.Size(35, 13);
            this.product_code_label.TabIndex = 16;
            this.product_code_label.Text = "label5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Product Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "€";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Minimum Bid Amount:";
            // 
            // bidBox
            // 
            this.bidBox.Location = new System.Drawing.Point(147, 175);
            this.bidBox.Name = "bidBox";
            this.bidBox.Size = new System.Drawing.Size(60, 20);
            this.bidBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Beginning Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Finish Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Set Auction parameters below:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(241, 343);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 24);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(129, 343);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(74, 24);
            this.clearButton.TabIndex = 28;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(29, 343);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(74, 24);
            this.submitButton.TabIndex = 27;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // beginning_dtp
            // 
            this.beginning_dtp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.beginning_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginning_dtp.Location = new System.Drawing.Point(147, 215);
            this.beginning_dtp.Name = "beginning_dtp";
            this.beginning_dtp.Size = new System.Drawing.Size(142, 20);
            this.beginning_dtp.TabIndex = 31;
            // 
            // finish_dtp
            // 
            this.finish_dtp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.finish_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.finish_dtp.Location = new System.Drawing.Point(147, 257);
            this.finish_dtp.Name = "finish_dtp";
            this.finish_dtp.Size = new System.Drawing.Size(142, 20);
            this.finish_dtp.TabIndex = 32;
            // 
            // NewAuction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 412);
            this.Controls.Add(this.finish_dtp);
            this.Controls.Add(this.beginning_dtp);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bidBox);
            this.Controls.Add(this.seller_label);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.product_code_label);
            this.Controls.Add(this.label2);
            this.Name = "NewAuction";
            this.Text = "New Auction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label seller_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label product_code_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bidBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker beginning_dtp;
        private System.Windows.Forms.DateTimePicker finish_dtp;
    }
}