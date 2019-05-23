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
            this.avgBuys = new System.Windows.Forms.Label();
            this.avgSells = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.sellerRating_bttn = new System.Windows.Forms.RadioButton();
            this.totalSells_bttn = new System.Windows.Forms.RadioButton();
            this.totalBuys_bttn = new System.Windows.Forms.RadioButton();
            this.totalBids_bttn = new System.Windows.Forms.RadioButton();
            this.perAuction_bttn = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ru_stats_LV
            // 
            this.ru_stats_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userColName,
            this.sellerRating,
            this.totalSells,
            this.totalBuys,
            this.perAuctionsWon,
            this.totalBids});
            this.ru_stats_LV.GridLines = true;
            this.ru_stats_LV.Location = new System.Drawing.Point(73, 12);
            this.ru_stats_LV.Name = "ru_stats_LV";
            this.ru_stats_LV.Size = new System.Drawing.Size(539, 106);
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
            this.avgRating.Location = new System.Drawing.Point(486, 272);
            this.avgRating.Name = "avgRating";
            this.avgRating.Size = new System.Drawing.Size(25, 13);
            this.avgRating.TabIndex = 28;
            this.avgRating.Text = "avg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Average Seller Rating:";
            // 
            // avgBids
            // 
            this.avgBids.AutoSize = true;
            this.avgBids.Location = new System.Drawing.Point(486, 239);
            this.avgBids.Name = "avgBids";
            this.avgBids.Size = new System.Drawing.Size(25, 13);
            this.avgBids.TabIndex = 26;
            this.avgBids.Text = "avg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Average No Bids per User:";
            // 
            // avgBuys
            // 
            this.avgBuys.AutoSize = true;
            this.avgBuys.Location = new System.Drawing.Point(486, 204);
            this.avgBuys.Name = "avgBuys";
            this.avgBuys.Size = new System.Drawing.Size(25, 13);
            this.avgBuys.TabIndex = 24;
            this.avgBuys.Text = "avg";
            // 
            // avgSells
            // 
            this.avgSells.AutoSize = true;
            this.avgSells.Location = new System.Drawing.Point(486, 172);
            this.avgSells.Name = "avgSells";
            this.avgSells.Size = new System.Drawing.Size(25, 13);
            this.avgSells.TabIndex = 23;
            this.avgSells.Text = "avg";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(336, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Average No Buys per User:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(336, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Average No Sells per User:";
            // 
            // sellerRating_bttn
            // 
            this.sellerRating_bttn.AutoSize = true;
            this.sellerRating_bttn.Location = new System.Drawing.Point(106, 169);
            this.sellerRating_bttn.Name = "sellerRating_bttn";
            this.sellerRating_bttn.Size = new System.Drawing.Size(85, 17);
            this.sellerRating_bttn.TabIndex = 29;
            this.sellerRating_bttn.TabStop = true;
            this.sellerRating_bttn.Text = "Seller Rating";
            this.sellerRating_bttn.UseVisualStyleBackColor = true;
            // 
            // totalSells_bttn
            // 
            this.totalSells_bttn.AutoSize = true;
            this.totalSells_bttn.Location = new System.Drawing.Point(106, 203);
            this.totalSells_bttn.Name = "totalSells_bttn";
            this.totalSells_bttn.Size = new System.Drawing.Size(74, 17);
            this.totalSells_bttn.TabIndex = 30;
            this.totalSells_bttn.TabStop = true;
            this.totalSells_bttn.Text = "Total Sells";
            this.totalSells_bttn.UseVisualStyleBackColor = true;
            // 
            // totalBuys_bttn
            // 
            this.totalBuys_bttn.AutoSize = true;
            this.totalBuys_bttn.Location = new System.Drawing.Point(106, 234);
            this.totalBuys_bttn.Name = "totalBuys_bttn";
            this.totalBuys_bttn.Size = new System.Drawing.Size(75, 17);
            this.totalBuys_bttn.TabIndex = 32;
            this.totalBuys_bttn.TabStop = true;
            this.totalBuys_bttn.Text = "Total Buys";
            this.totalBuys_bttn.UseVisualStyleBackColor = true;
            // 
            // totalBids_bttn
            // 
            this.totalBids_bttn.AutoSize = true;
            this.totalBids_bttn.Location = new System.Drawing.Point(106, 268);
            this.totalBids_bttn.Name = "totalBids_bttn";
            this.totalBids_bttn.Size = new System.Drawing.Size(72, 17);
            this.totalBids_bttn.TabIndex = 31;
            this.totalBids_bttn.TabStop = true;
            this.totalBids_bttn.Text = "Total Bids";
            this.totalBids_bttn.UseVisualStyleBackColor = true;
            // 
            // perAuction_bttn
            // 
            this.perAuction_bttn.AutoSize = true;
            this.perAuction_bttn.Location = new System.Drawing.Point(106, 302);
            this.perAuction_bttn.Name = "perAuction_bttn";
            this.perAuction_bttn.Size = new System.Drawing.Size(103, 17);
            this.perAuction_bttn.TabIndex = 33;
            this.perAuction_bttn.TabStop = true;
            this.perAuction_bttn.Text = "% Auctions Won";
            this.perAuction_bttn.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(113, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Display results by:";
            // 
            // RU_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 331);
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
            this.Controls.Add(this.avgBuys);
            this.Controls.Add(this.avgSells);
            this.Controls.Add(this.label15);
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
        private System.Windows.Forms.Label avgBuys;
        private System.Windows.Forms.Label avgSells;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton sellerRating_bttn;
        private System.Windows.Forms.RadioButton totalSells_bttn;
        private System.Windows.Forms.RadioButton totalBuys_bttn;
        private System.Windows.Forms.RadioButton totalBids_bttn;
        private System.Windows.Forms.RadioButton perAuction_bttn;
        private System.Windows.Forms.Label label17;
    }
}