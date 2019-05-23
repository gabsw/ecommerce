namespace ecommerce
{
    partial class Reviews
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
            this.reviewsLV = new System.Windows.Forms.ListView();
            this.review = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.purchase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buyer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buyerBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.purchaseBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sellerBox = new System.Windows.Forms.ComboBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.productCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.purchase2Box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // reviewsLV
            // 
            this.reviewsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.review,
            this.purchase,
            this.productCode,
            this.buyer,
            this.seller,
            this.rating,
            this.date,
            this.comment});
            this.reviewsLV.GridLines = true;
            this.reviewsLV.Location = new System.Drawing.Point(29, 25);
            this.reviewsLV.Name = "reviewsLV";
            this.reviewsLV.Size = new System.Drawing.Size(805, 204);
            this.reviewsLV.TabIndex = 0;
            this.reviewsLV.UseCompatibleStateImageBehavior = false;
            this.reviewsLV.View = System.Windows.Forms.View.Details;
            // 
            // review
            // 
            this.review.Text = "Review ID";
            this.review.Width = 63;
            // 
            // purchase
            // 
            this.purchase.Text = "Purchase ID";
            this.purchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.purchase.Width = 72;
            // 
            // buyer
            // 
            this.buyer.Text = "Buyer";
            this.buyer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buyer.Width = 107;
            // 
            // seller
            // 
            this.seller.Text = "Seller";
            this.seller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seller.Width = 117;
            // 
            // rating
            // 
            this.rating.Text = "Rating";
            this.rating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Width = 155;
            // 
            // comment
            // 
            this.comment.Text = "Comment";
            this.comment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comment.Width = 181;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(231, 242);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 25);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add New";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(542, 242);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(72, 25);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(867, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Buyer\'s username:";
            // 
            // buyerBox
            // 
            this.buyerBox.FormattingEnabled = true;
            this.buyerBox.Location = new System.Drawing.Point(870, 103);
            this.buyerBox.Name = "buyerBox";
            this.buyerBox.Size = new System.Drawing.Size(186, 21);
            this.buyerBox.TabIndex = 73;
            this.buyerBox.SelectedIndexChanged += new System.EventHandler(this.buyerBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(867, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "All Purchases:";
            // 
            // purchaseBox
            // 
            this.purchaseBox.FormattingEnabled = true;
            this.purchaseBox.Location = new System.Drawing.Point(870, 175);
            this.purchaseBox.Name = "purchaseBox";
            this.purchaseBox.Size = new System.Drawing.Size(186, 21);
            this.purchaseBox.TabIndex = 75;
            this.purchaseBox.SelectedIndexChanged += new System.EventHandler(this.purchaseBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(868, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Seller\'s username:";
            // 
            // sellerBox
            // 
            this.sellerBox.FormattingEnabled = true;
            this.sellerBox.Location = new System.Drawing.Point(870, 36);
            this.sellerBox.Name = "sellerBox";
            this.sellerBox.Size = new System.Drawing.Size(186, 21);
            this.sellerBox.TabIndex = 77;
            this.sellerBox.SelectedIndexChanged += new System.EventHandler(this.sellerBox_SelectedIndexChanged);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(380, 243);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(88, 22);
            this.clear_button.TabIndex = 79;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // productCode
            // 
            this.productCode.Text = "Product Code";
            this.productCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productCode.Width = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(867, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Purchases with pending reviews:";
            // 
            // purchase2Box
            // 
            this.purchase2Box.FormattingEnabled = true;
            this.purchase2Box.Location = new System.Drawing.Point(870, 242);
            this.purchase2Box.Name = "purchase2Box";
            this.purchase2Box.Size = new System.Drawing.Size(186, 21);
            this.purchase2Box.TabIndex = 80;
            this.purchase2Box.SelectedIndexChanged += new System.EventHandler(this.purchase2_SelectedIndexChanged);
            // 
            // Reviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 279);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.purchase2Box);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sellerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.purchaseBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyerBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.reviewsLV);
            this.Name = "Reviews";
            this.Text = "Reviews";
            this.Load += new System.EventHandler(this.Reviews_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView reviewsLV;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox buyerBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox purchaseBox;
        private System.Windows.Forms.ColumnHeader review;
        private System.Windows.Forms.ColumnHeader purchase;
        private System.Windows.Forms.ColumnHeader rating;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader comment;
        private System.Windows.Forms.ColumnHeader buyer;
        private System.Windows.Forms.ColumnHeader seller;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sellerBox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.ColumnHeader productCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox purchase2Box;
    }
}