namespace ecommerce
{
    partial class Bid
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.auction_label = new System.Windows.Forms.Label();
            this.product_code_label = new System.Windows.Forms.Label();
            this.min_bid_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bidBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.buyer_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auction ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minimum Valid Bid (€):";
            // 
            // auction_label
            // 
            this.auction_label.AutoSize = true;
            this.auction_label.Location = new System.Drawing.Point(171, 35);
            this.auction_label.Name = "auction_label";
            this.auction_label.Size = new System.Drawing.Size(35, 13);
            this.auction_label.TabIndex = 3;
            this.auction_label.Text = "label4";
            // 
            // product_code_label
            // 
            this.product_code_label.AutoSize = true;
            this.product_code_label.Location = new System.Drawing.Point(171, 67);
            this.product_code_label.Name = "product_code_label";
            this.product_code_label.Size = new System.Drawing.Size(35, 13);
            this.product_code_label.TabIndex = 4;
            this.product_code_label.Text = "label5";
            // 
            // min_bid_label
            // 
            this.min_bid_label.AutoSize = true;
            this.min_bid_label.Location = new System.Drawing.Point(172, 175);
            this.min_bid_label.Name = "min_bid_label";
            this.min_bid_label.Size = new System.Drawing.Size(35, 13);
            this.min_bid_label.TabIndex = 5;
            this.min_bid_label.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "€";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bid Amount:";
            // 
            // bidBox
            // 
            this.bidBox.Location = new System.Drawing.Point(116, 243);
            this.bidBox.Name = "bidBox";
            this.bidBox.Size = new System.Drawing.Size(60, 20);
            this.bidBox.TabIndex = 8;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(129, 307);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(74, 24);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(29, 307);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(74, 24);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // buyer_label
            // 
            this.buyer_label.AutoSize = true;
            this.buyer_label.Location = new System.Drawing.Point(171, 98);
            this.buyer_label.Name = "buyer_label";
            this.buyer_label.Size = new System.Drawing.Size(35, 13);
            this.buyer_label.TabIndex = 14;
            this.buyer_label.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "User name Buyer:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(241, 307);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 24);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Bid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 372);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.buyer_label);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bidBox);
            this.Controls.Add(this.min_bid_label);
            this.Controls.Add(this.product_code_label);
            this.Controls.Add(this.auction_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bid";
            this.Text = "Bid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label auction_label;
        private System.Windows.Forms.Label product_code_label;
        private System.Windows.Forms.Label min_bid_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bidBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label buyer_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cancelButton;
    }
}