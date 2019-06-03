namespace ecommerce
{
    partial class Completed_Purchase
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sellerBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.auctionBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buyerBox = new System.Windows.Forms.ComboBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.purchCompLV = new System.Windows.Forms.ListView();
            this.purchase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.auction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buyer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.finalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(636, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 110;
            this.label4.Text = "Search Filters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "Seller\'s username:";
            // 
            // sellerBox
            // 
            this.sellerBox.FormattingEnabled = true;
            this.sellerBox.Location = new System.Drawing.Point(585, 85);
            this.sellerBox.Name = "sellerBox";
            this.sellerBox.Size = new System.Drawing.Size(186, 21);
            this.sellerBox.TabIndex = 108;
            this.sellerBox.SelectedIndexChanged += new System.EventHandler(this.sellerBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Auctions:";
            // 
            // auctionBox
            // 
            this.auctionBox.FormattingEnabled = true;
            this.auctionBox.Location = new System.Drawing.Point(586, 210);
            this.auctionBox.Name = "auctionBox";
            this.auctionBox.Size = new System.Drawing.Size(186, 21);
            this.auctionBox.TabIndex = 106;
            this.auctionBox.SelectedIndexChanged += new System.EventHandler(this.auctionBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Buyer\'s username:";
            // 
            // buyerBox
            // 
            this.buyerBox.FormattingEnabled = true;
            this.buyerBox.Location = new System.Drawing.Point(585, 144);
            this.buyerBox.Name = "buyerBox";
            this.buyerBox.Size = new System.Drawing.Size(186, 21);
            this.buyerBox.TabIndex = 104;
            this.buyerBox.SelectedIndexChanged += new System.EventHandler(this.buyerBox_SelectedIndexChanged);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(264, 280);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(88, 22);
            this.clear_button.TabIndex = 103;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(431, 280);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(72, 25);
            this.refreshButton.TabIndex = 102;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(33, 277);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(158, 25);
            this.addButton.TabIndex = 101;
            this.addButton.Text = "Read Full Purchase Details";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // purchCompLV
            // 
            this.purchCompLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.purchase,
            this.auction,
            this.buyer,
            this.seller,
            this.finalPrice});
            this.purchCompLV.FullRowSelect = true;
            this.purchCompLV.GridLines = true;
            this.purchCompLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.purchCompLV.Location = new System.Drawing.Point(33, 27);
            this.purchCompLV.MultiSelect = false;
            this.purchCompLV.Name = "purchCompLV";
            this.purchCompLV.Size = new System.Drawing.Size(470, 204);
            this.purchCompLV.TabIndex = 100;
            this.purchCompLV.UseCompatibleStateImageBehavior = false;
            this.purchCompLV.View = System.Windows.Forms.View.Details;
            // 
            // purchase
            // 
            this.purchase.Text = "Purchase ID";
            this.purchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.purchase.Width = 72;
            // 
            // auction
            // 
            this.auction.Text = "Auction ID";
            this.auction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.auction.Width = 90;
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
            // finalPrice
            // 
            this.finalPrice.Text = "Final Price (€)";
            this.finalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finalPrice.Width = 78;
            // 
            // Completed_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sellerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.auctionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyerBox);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.purchCompLV);
            this.Name = "Completed_Purchase";
            this.Text = "Completed Purchases";
            this.Load += new System.EventHandler(this.Completed_Purchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sellerBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox auctionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox buyerBox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView purchCompLV;
        private System.Windows.Forms.ColumnHeader purchase;
        private System.Windows.Forms.ColumnHeader auction;
        private System.Windows.Forms.ColumnHeader buyer;
        private System.Windows.Forms.ColumnHeader seller;
        private System.Windows.Forms.ColumnHeader finalPrice;
    }
}