namespace ecommerce
{
    partial class BidHistory
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
            this.auctionID_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BidLV = new System.Windows.Forms.ListView();
            this.bidID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.credAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datebid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalbids_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // auctionID_label
            // 
            this.auctionID_label.AutoSize = true;
            this.auctionID_label.Location = new System.Drawing.Point(116, 20);
            this.auctionID_label.Name = "auctionID_label";
            this.auctionID_label.Size = new System.Drawing.Size(35, 13);
            this.auctionID_label.TabIndex = 9;
            this.auctionID_label.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Bids:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Auction ID:";
            // 
            // BidLV
            // 
            this.BidLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bidID,
            this.credAmount,
            this.user,
            this.datebid});
            this.BidLV.GridLines = true;
            this.BidLV.Location = new System.Drawing.Point(24, 88);
            this.BidLV.Name = "BidLV";
            this.BidLV.Size = new System.Drawing.Size(356, 271);
            this.BidLV.TabIndex = 6;
            this.BidLV.UseCompatibleStateImageBehavior = false;
            this.BidLV.View = System.Windows.Forms.View.Details;
            // 
            // bidID
            // 
            this.bidID.Text = "Bid ID";
            // 
            // credAmount
            // 
            this.credAmount.Text = "Amount (€)";
            this.credAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.credAmount.Width = 81;
            // 
            // user
            // 
            this.user.Text = "Username ";
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user.Width = 85;
            // 
            // datebid
            // 
            this.datebid.Text = "Date";
            this.datebid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datebid.Width = 127;
            // 
            // totalbids_label
            // 
            this.totalbids_label.AutoSize = true;
            this.totalbids_label.Location = new System.Drawing.Point(116, 42);
            this.totalbids_label.Name = "totalbids_label";
            this.totalbids_label.Size = new System.Drawing.Size(35, 13);
            this.totalbids_label.TabIndex = 10;
            this.totalbids_label.Text = "label3";
            // 
            // BidHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.totalbids_label);
            this.Controls.Add(this.auctionID_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BidLV);
            this.Name = "BidHistory";
            this.Text = "Bid History";
            this.Load += new System.EventHandler(this.BidHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label auctionID_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView BidLV;
        private System.Windows.Forms.ColumnHeader bidID;
        private System.Windows.Forms.ColumnHeader credAmount;
        private System.Windows.Forms.ColumnHeader user;
        private System.Windows.Forms.ColumnHeader datebid;
        private System.Windows.Forms.Label totalbids_label;
    }
}