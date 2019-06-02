namespace ecommerce
{
    partial class Closed_Auctions
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
            this.product_info_bttn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.high_bid_bttn = new System.Windows.Forms.RadioButton();
            this.auctionID_bttn = new System.Windows.Forms.RadioButton();
            this.ClosedAuctionLV = new System.Windows.Forms.ListView();
            this.auctionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currentWinner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winningBid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.beginningDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.finishDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bidHistory = new System.Windows.Forms.Button();
            this.low_bid_bttn = new System.Windows.Forms.RadioButton();
            this.refresh_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // product_info_bttn
            // 
            this.product_info_bttn.Location = new System.Drawing.Point(447, 274);
            this.product_info_bttn.Name = "product_info_bttn";
            this.product_info_bttn.Size = new System.Drawing.Size(115, 22);
            this.product_info_bttn.TabIndex = 91;
            this.product_info_bttn.Text = "Go to Product Info";
            this.product_info_bttn.UseVisualStyleBackColor = true;
            this.product_info_bttn.Click += new System.EventHandler(this.product_info_bttn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(57, 247);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 90;
            this.label17.Text = "Display results by:";
            // 
            // high_bid_bttn
            // 
            this.high_bid_bttn.AutoSize = true;
            this.high_bid_bttn.Location = new System.Drawing.Point(60, 312);
            this.high_bid_bttn.Name = "high_bid_bttn";
            this.high_bid_bttn.Size = new System.Drawing.Size(136, 17);
            this.high_bid_bttn.TabIndex = 88;
            this.high_bid_bttn.TabStop = true;
            this.high_bid_bttn.Text = "Highest Winning Bid (€)";
            this.high_bid_bttn.UseVisualStyleBackColor = true;
            this.high_bid_bttn.CheckedChanged += new System.EventHandler(this.high_bid_bttn_CheckedChanged);
            // 
            // auctionID_bttn
            // 
            this.auctionID_bttn.AutoSize = true;
            this.auctionID_bttn.Location = new System.Drawing.Point(60, 279);
            this.auctionID_bttn.Name = "auctionID_bttn";
            this.auctionID_bttn.Size = new System.Drawing.Size(75, 17);
            this.auctionID_bttn.TabIndex = 87;
            this.auctionID_bttn.TabStop = true;
            this.auctionID_bttn.Text = "Auction ID";
            this.auctionID_bttn.UseVisualStyleBackColor = true;
            this.auctionID_bttn.CheckedChanged += new System.EventHandler(this.auctionID_bttn_CheckedChanged);
            // 
            // ClosedAuctionLV
            // 
            this.ClosedAuctionLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.auctionID,
            this.productCode,
            this.currentWinner,
            this.winningBid,
            this.beginningDate,
            this.finishDate});
            this.ClosedAuctionLV.FullRowSelect = true;
            this.ClosedAuctionLV.GridLines = true;
            this.ClosedAuctionLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ClosedAuctionLV.Location = new System.Drawing.Point(60, 36);
            this.ClosedAuctionLV.MultiSelect = false;
            this.ClosedAuctionLV.Name = "ClosedAuctionLV";
            this.ClosedAuctionLV.Size = new System.Drawing.Size(721, 169);
            this.ClosedAuctionLV.TabIndex = 83;
            this.ClosedAuctionLV.UseCompatibleStateImageBehavior = false;
            this.ClosedAuctionLV.View = System.Windows.Forms.View.Details;
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
            // currentWinner
            // 
            this.currentWinner.Text = "Winner";
            this.currentWinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentWinner.Width = 99;
            // 
            // winningBid
            // 
            this.winningBid.Text = "Winning Bid (€)";
            this.winningBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.winningBid.Width = 117;
            // 
            // beginningDate
            // 
            this.beginningDate.Text = "Beginning Date";
            this.beginningDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.beginningDate.Width = 158;
            // 
            // finishDate
            // 
            this.finishDate.Text = "Finish Date";
            this.finishDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finishDate.Width = 180;
            // 
            // bidHistory
            // 
            this.bidHistory.Location = new System.Drawing.Point(265, 274);
            this.bidHistory.Name = "bidHistory";
            this.bidHistory.Size = new System.Drawing.Size(115, 22);
            this.bidHistory.TabIndex = 93;
            this.bidHistory.Text = "Bid History";
            this.bidHistory.UseVisualStyleBackColor = true;
            this.bidHistory.Click += new System.EventHandler(this.bidHistory_Click);
            // 
            // low_bid_bttn
            // 
            this.low_bid_bttn.AutoSize = true;
            this.low_bid_bttn.Location = new System.Drawing.Point(60, 347);
            this.low_bid_bttn.Name = "low_bid_bttn";
            this.low_bid_bttn.Size = new System.Drawing.Size(134, 17);
            this.low_bid_bttn.TabIndex = 94;
            this.low_bid_bttn.TabStop = true;
            this.low_bid_bttn.Text = "Lowest Winning Bid (€)";
            this.low_bid_bttn.UseVisualStyleBackColor = true;
            this.low_bid_bttn.CheckedChanged += new System.EventHandler(this.low_bid_bttn_CheckedChanged);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(605, 274);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(115, 22);
            this.refresh_button.TabIndex = 95;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // Closed_Auctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 388);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.low_bid_bttn);
            this.Controls.Add(this.bidHistory);
            this.Controls.Add(this.product_info_bttn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.high_bid_bttn);
            this.Controls.Add(this.auctionID_bttn);
            this.Controls.Add(this.ClosedAuctionLV);
            this.Name = "Closed_Auctions";
            this.Text = "Closed Auctions";
            this.Load += new System.EventHandler(this.Closed_Auctions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button product_info_bttn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton high_bid_bttn;
        private System.Windows.Forms.RadioButton auctionID_bttn;
        private System.Windows.Forms.ListView ClosedAuctionLV;
        private System.Windows.Forms.ColumnHeader auctionID;
        private System.Windows.Forms.ColumnHeader currentWinner;
        private System.Windows.Forms.ColumnHeader winningBid;
        private System.Windows.Forms.ColumnHeader finishDate;
        private System.Windows.Forms.ColumnHeader productCode;
        private System.Windows.Forms.ColumnHeader beginningDate;
        private System.Windows.Forms.Button bidHistory;
        private System.Windows.Forms.RadioButton low_bid_bttn;
        private System.Windows.Forms.Button refresh_button;
    }
}