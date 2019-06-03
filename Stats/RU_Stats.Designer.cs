namespace ecommerce
{
    partial class RU_Stats
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
            this.ru_stats_LV = new System.Windows.Forms.ListView();
            this.userColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sellerRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalSells = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalBuys = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.perAuctionsWon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalBids = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.avgRating = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.avgBids = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.avgSells = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.sellerRating_bttn = new System.Windows.Forms.RadioButton();
            this.totalSells_bttn = new System.Windows.Forms.RadioButton();
            this.totalBuys_bttn = new System.Windows.Forms.RadioButton();
            this.totalBids_bttn = new System.Windows.Forms.RadioButton();
            this.perAuction_bttn = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.per_bids_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ru_stats_LV
            // 
            this.ru_stats_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userColName,
            this.sellerRating,
            this.totalSells,
            this.totalBuys,
            this.totalBids,
            this.perAuctionsWon});
            this.ru_stats_LV.GridLines = true;
            this.ru_stats_LV.Location = new System.Drawing.Point(73, 12);
            this.ru_stats_LV.Name = "ru_stats_LV";
            this.ru_stats_LV.Size = new System.Drawing.Size(539, 266);
            this.ru_stats_LV.TabIndex = 12;
            this.ru_stats_LV.UseCompatibleStateImageBehavior = false;
            this.ru_stats_LV.View = System.Windows.Forms.View.Details;
            // 
            // userColName
            // 
            this.userColName.Text = "User Name";
            this.userColName.Width = 108;
            // 
            // sellerRating
            // 
            this.sellerRating.Text = "Seller Rating";
            this.sellerRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sellerRating.Width = 100;
            // 
            // totalSells
            // 
            this.totalSells.Text = "Total Sells";
            this.totalSells.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalSells.Width = 74;
            // 
            // totalBuys
            // 
            this.totalBuys.Text = "Total Buys";
            this.totalBuys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalBuys.Width = 67;
            // 
            // perAuctionsWon
            // 
            this.perAuctionsWon.DisplayIndex = 5;
            this.perAuctionsWon.Text = "% Auctions Won";
            this.perAuctionsWon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.perAuctionsWon.Width = 120;
            // 
            // totalBids
            // 
            this.totalBids.DisplayIndex = 4;
            this.totalBids.Text = "Total Bids";
            this.totalBids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // avgRating
            // 
            this.avgRating.AutoSize = true;
            this.avgRating.Location = new System.Drawing.Point(495, 427);
            this.avgRating.Name = "avgRating";
            this.avgRating.Size = new System.Drawing.Size(25, 13);
            this.avgRating.TabIndex = 28;
            this.avgRating.Text = "avg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Average Seller Rating:";
            // 
            // avgBids
            // 
            this.avgBids.AutoSize = true;
            this.avgBids.Location = new System.Drawing.Point(495, 366);
            this.avgBids.Name = "avgBids";
            this.avgBids.Size = new System.Drawing.Size(25, 13);
            this.avgBids.TabIndex = 26;
            this.avgBids.Text = "avg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(346, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Average No Bids per User:";
            // 
            // avgSells
            // 
            this.avgSells.AutoSize = true;
            this.avgSells.Location = new System.Drawing.Point(496, 331);
            this.avgSells.Name = "avgSells";
            this.avgSells.Size = new System.Drawing.Size(25, 13);
            this.avgSells.TabIndex = 23;
            this.avgSells.Text = "avg";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(346, 331);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Average No Sells per User:";
            // 
            // sellerRating_bttn
            // 
            this.sellerRating_bttn.AutoSize = true;
            this.sellerRating_bttn.Location = new System.Drawing.Point(116, 328);
            this.sellerRating_bttn.Name = "sellerRating_bttn";
            this.sellerRating_bttn.Size = new System.Drawing.Size(85, 17);
            this.sellerRating_bttn.TabIndex = 29;
            this.sellerRating_bttn.TabStop = true;
            this.sellerRating_bttn.Text = "Seller Rating";
            this.sellerRating_bttn.UseVisualStyleBackColor = true;
            this.sellerRating_bttn.CheckedChanged += new System.EventHandler(this.sellerRating_bttn_CheckedChanged);
            // 
            // totalSells_bttn
            // 
            this.totalSells_bttn.AutoSize = true;
            this.totalSells_bttn.Location = new System.Drawing.Point(116, 362);
            this.totalSells_bttn.Name = "totalSells_bttn";
            this.totalSells_bttn.Size = new System.Drawing.Size(74, 17);
            this.totalSells_bttn.TabIndex = 30;
            this.totalSells_bttn.TabStop = true;
            this.totalSells_bttn.Text = "Total Sells";
            this.totalSells_bttn.UseVisualStyleBackColor = true;
            this.totalSells_bttn.CheckedChanged += new System.EventHandler(this.totalSells_bttn_CheckedChanged);
            // 
            // totalBuys_bttn
            // 
            this.totalBuys_bttn.AutoSize = true;
            this.totalBuys_bttn.Location = new System.Drawing.Point(116, 393);
            this.totalBuys_bttn.Name = "totalBuys_bttn";
            this.totalBuys_bttn.Size = new System.Drawing.Size(75, 17);
            this.totalBuys_bttn.TabIndex = 32;
            this.totalBuys_bttn.TabStop = true;
            this.totalBuys_bttn.Text = "Total Buys";
            this.totalBuys_bttn.UseVisualStyleBackColor = true;
            this.totalBuys_bttn.CheckedChanged += new System.EventHandler(this.totalBuys_bttn_CheckedChanged);
            // 
            // totalBids_bttn
            // 
            this.totalBids_bttn.AutoSize = true;
            this.totalBids_bttn.Location = new System.Drawing.Point(116, 427);
            this.totalBids_bttn.Name = "totalBids_bttn";
            this.totalBids_bttn.Size = new System.Drawing.Size(72, 17);
            this.totalBids_bttn.TabIndex = 31;
            this.totalBids_bttn.TabStop = true;
            this.totalBids_bttn.Text = "Total Bids";
            this.totalBids_bttn.UseVisualStyleBackColor = true;
            this.totalBids_bttn.CheckedChanged += new System.EventHandler(this.totalBids_bttn_CheckedChanged);
            // 
            // perAuction_bttn
            // 
            this.perAuction_bttn.AutoSize = true;
            this.perAuction_bttn.Location = new System.Drawing.Point(116, 461);
            this.perAuction_bttn.Name = "perAuction_bttn";
            this.perAuction_bttn.Size = new System.Drawing.Size(103, 17);
            this.perAuction_bttn.TabIndex = 33;
            this.perAuction_bttn.TabStop = true;
            this.perAuction_bttn.Text = "% Auctions Won";
            this.perAuction_bttn.UseVisualStyleBackColor = true;
            this.perAuction_bttn.CheckedChanged += new System.EventHandler(this.perAuction_bttn_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(123, 295);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Display results by:";
            // 
            // per_bids_lbl
            // 
            this.per_bids_lbl.AutoSize = true;
            this.per_bids_lbl.Location = new System.Drawing.Point(495, 393);
            this.per_bids_lbl.Name = "per_bids_lbl";
            this.per_bids_lbl.Size = new System.Drawing.Size(22, 13);
            this.per_bids_lbl.TabIndex = 36;
            this.per_bids_lbl.Text = "per";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "% of Users that have bids:";
            // 
            // RU_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 490);
            this.Controls.Add(this.per_bids_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.perAuction_bttn);
            this.Controls.Add(this.totalBuys_bttn);
            this.Controls.Add(this.totalBids_bttn);
            this.Controls.Add(this.totalSells_bttn);
            this.Controls.Add(this.sellerRating_bttn);
            this.Controls.Add(this.avgRating);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.avgBids);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.avgSells);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ru_stats_LV);
            this.Name = "RU_Stats";
            this.Text = "Regular User Statistics";
            this.Load += new System.EventHandler(this.RU_Stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ru_stats_LV;
        private System.Windows.Forms.ColumnHeader userColName;
        private System.Windows.Forms.ColumnHeader sellerRating;
        private System.Windows.Forms.ColumnHeader totalSells;
        private System.Windows.Forms.ColumnHeader totalBuys;
        private System.Windows.Forms.ColumnHeader perAuctionsWon;
        private System.Windows.Forms.ColumnHeader totalBids;
        private System.Windows.Forms.Label avgRating;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label avgBids;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label avgSells;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton sellerRating_bttn;
        private System.Windows.Forms.RadioButton totalSells_bttn;
        private System.Windows.Forms.RadioButton totalBuys_bttn;
        private System.Windows.Forms.RadioButton totalBids_bttn;
        private System.Windows.Forms.RadioButton perAuction_bttn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label per_bids_lbl;
        private System.Windows.Forms.Label label2;
    }
}