namespace ecommerce
{
    partial class Open_Auctions
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
            this.OpenAuctionLV = new System.Windows.Forms.ListView();
            this.auctionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currentWinner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.validBid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.finishDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bidButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buyerBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.finishDate_bttn = new System.Windows.Forms.RadioButton();
            this.high_bid_bttn = new System.Windows.Forms.RadioButton();
            this.auctionID_bttn = new System.Windows.Forms.RadioButton();
            this.product_info_bttn = new System.Windows.Forms.Button();
            this.low_bid_bttn = new System.Windows.Forms.RadioButton();
            this.product_code_bttn = new System.Windows.Forms.RadioButton();
            this.refresh_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenAuctionLV
            // 
            this.OpenAuctionLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.auctionID,
            this.productCode,
            this.productName,
            this.currentWinner,
            this.validBid,
            this.finishDate,
            this.Seller});
            this.OpenAuctionLV.FullRowSelect = true;
            this.OpenAuctionLV.GridLines = true;
            this.OpenAuctionLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.OpenAuctionLV.Location = new System.Drawing.Point(58, 61);
            this.OpenAuctionLV.MultiSelect = false;
            this.OpenAuctionLV.Name = "OpenAuctionLV";
            this.OpenAuctionLV.Size = new System.Drawing.Size(779, 169);
            this.OpenAuctionLV.TabIndex = 0;
            this.OpenAuctionLV.UseCompatibleStateImageBehavior = false;
            this.OpenAuctionLV.View = System.Windows.Forms.View.Details;
            // 
            // auctionID
            // 
            this.auctionID.Text = "Auction ID";
            this.auctionID.Width = 66;
            // 
            // productCode
            // 
            this.productCode.Text = "Product Code";
            this.productCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productCode.Width = 81;
            // 
            // productName
            // 
            this.productName.Text = "Product Name";
            this.productName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productName.Width = 151;
            // 
            // currentWinner
            // 
            this.currentWinner.Text = "Current Winner";
            this.currentWinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentWinner.Width = 99;
            // 
            // validBid
            // 
            this.validBid.Text = "Minimum Valid Bid (€)";
            this.validBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.validBid.Width = 117;
            // 
            // finishDate
            // 
            this.finishDate.Text = "Finish Date";
            this.finishDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finishDate.Width = 130;
            // 
            // Seller
            // 
            this.Seller.Text = "Seller";
            this.Seller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Seller.Width = 125;
            // 
            // bidButton
            // 
            this.bidButton.Location = new System.Drawing.Point(674, 288);
            this.bidButton.Name = "bidButton";
            this.bidButton.Size = new System.Drawing.Size(115, 22);
            this.bidButton.TabIndex = 73;
            this.bidButton.Text = "Bid";
            this.bidButton.UseVisualStyleBackColor = true;
            this.bidButton.Click += new System.EventHandler(this.bidButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Select Buyer\'s username:";
            // 
            // buyerBox
            // 
            this.buyerBox.FormattingEnabled = true;
            this.buyerBox.Location = new System.Drawing.Point(329, 306);
            this.buyerBox.Name = "buyerBox";
            this.buyerBox.Size = new System.Drawing.Size(186, 21);
            this.buyerBox.TabIndex = 71;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(55, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 80;
            this.label17.Text = "Display results by:";
            // 
            // finishDate_bttn
            // 
            this.finishDate_bttn.AutoSize = true;
            this.finishDate_bttn.Location = new System.Drawing.Point(58, 428);
            this.finishDate_bttn.Name = "finishDate_bttn";
            this.finishDate_bttn.Size = new System.Drawing.Size(115, 17);
            this.finishDate_bttn.TabIndex = 79;
            this.finishDate_bttn.TabStop = true;
            this.finishDate_bttn.Text = "Earliest Finish Date";
            this.finishDate_bttn.UseVisualStyleBackColor = true;
            this.finishDate_bttn.CheckedChanged += new System.EventHandler(this.finishDate_bttn_CheckedChanged);
            // 
            // high_bid_bttn
            // 
            this.high_bid_bttn.AutoSize = true;
            this.high_bid_bttn.Location = new System.Drawing.Point(58, 360);
            this.high_bid_bttn.Name = "high_bid_bttn";
            this.high_bid_bttn.Size = new System.Drawing.Size(120, 17);
            this.high_bid_bttn.TabIndex = 78;
            this.high_bid_bttn.TabStop = true;
            this.high_bid_bttn.Text = "Highest Valid Bid (€)";
            this.high_bid_bttn.UseVisualStyleBackColor = true;
            this.high_bid_bttn.CheckedChanged += new System.EventHandler(this.high_bid_bttn_CheckedChanged);
            // 
            // auctionID_bttn
            // 
            this.auctionID_bttn.AutoSize = true;
            this.auctionID_bttn.Location = new System.Drawing.Point(58, 292);
            this.auctionID_bttn.Name = "auctionID_bttn";
            this.auctionID_bttn.Size = new System.Drawing.Size(75, 17);
            this.auctionID_bttn.TabIndex = 77;
            this.auctionID_bttn.TabStop = true;
            this.auctionID_bttn.Text = "Auction ID";
            this.auctionID_bttn.UseVisualStyleBackColor = true;
            this.auctionID_bttn.CheckedChanged += new System.EventHandler(this.auctionID_bttn_CheckedChanged);
            // 
            // product_info_bttn
            // 
            this.product_info_bttn.Location = new System.Drawing.Point(674, 339);
            this.product_info_bttn.Name = "product_info_bttn";
            this.product_info_bttn.Size = new System.Drawing.Size(115, 22);
            this.product_info_bttn.TabIndex = 81;
            this.product_info_bttn.Text = "Go to Product Info";
            this.product_info_bttn.UseVisualStyleBackColor = true;
            this.product_info_bttn.Click += new System.EventHandler(this.product_info_bttn_Click);
            // 
            // low_bid_bttn
            // 
            this.low_bid_bttn.AutoSize = true;
            this.low_bid_bttn.Location = new System.Drawing.Point(58, 396);
            this.low_bid_bttn.Name = "low_bid_bttn";
            this.low_bid_bttn.Size = new System.Drawing.Size(118, 17);
            this.low_bid_bttn.TabIndex = 83;
            this.low_bid_bttn.TabStop = true;
            this.low_bid_bttn.Text = "Lowest Valid Bid (€)";
            this.low_bid_bttn.UseVisualStyleBackColor = true;
            this.low_bid_bttn.CheckedChanged += new System.EventHandler(this.low_bid_bttn_CheckedChanged);
            // 
            // product_code_bttn
            // 
            this.product_code_bttn.AutoSize = true;
            this.product_code_bttn.Location = new System.Drawing.Point(58, 323);
            this.product_code_bttn.Name = "product_code_bttn";
            this.product_code_bttn.Size = new System.Drawing.Size(90, 17);
            this.product_code_bttn.TabIndex = 82;
            this.product_code_bttn.TabStop = true;
            this.product_code_bttn.Text = "Product Code";
            this.product_code_bttn.UseVisualStyleBackColor = true;
            this.product_code_bttn.CheckedChanged += new System.EventHandler(this.product_code_bttn_CheckedChanged);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(674, 391);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(115, 22);
            this.refresh_button.TabIndex = 84;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // Open_Auctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 467);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.low_bid_bttn);
            this.Controls.Add(this.product_code_bttn);
            this.Controls.Add(this.product_info_bttn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.finishDate_bttn);
            this.Controls.Add(this.high_bid_bttn);
            this.Controls.Add(this.auctionID_bttn);
            this.Controls.Add(this.bidButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyerBox);
            this.Controls.Add(this.OpenAuctionLV);
            this.Name = "Open_Auctions";
            this.Text = "Open Auctions";
            this.Load += new System.EventHandler(this.Open_Auctions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView OpenAuctionLV;
        private System.Windows.Forms.ColumnHeader auctionID;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader currentWinner;
        private System.Windows.Forms.ColumnHeader validBid;
        private System.Windows.Forms.ColumnHeader finishDate;
        private System.Windows.Forms.Button bidButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox buyerBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton finishDate_bttn;
        private System.Windows.Forms.RadioButton high_bid_bttn;
        private System.Windows.Forms.RadioButton auctionID_bttn;
        private System.Windows.Forms.ColumnHeader productCode;
        private System.Windows.Forms.Button product_info_bttn;
        private System.Windows.Forms.RadioButton low_bid_bttn;
        private System.Windows.Forms.RadioButton product_code_bttn;
        private System.Windows.Forms.ColumnHeader Seller;
        private System.Windows.Forms.Button refresh_button;
    }
}