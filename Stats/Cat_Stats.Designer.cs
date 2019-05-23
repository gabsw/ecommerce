namespace ecommerce
{
    partial class Cat_Stats
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
            this.label17 = new System.Windows.Forms.Label();
            this.totalBuys_bttn = new System.Windows.Forms.RadioButton();
            this.totalSells_bttn = new System.Windows.Forms.RadioButton();
            this.sellerRating_bttn = new System.Windows.Forms.RadioButton();
            this.avgBids = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.avgBuys = new System.Windows.Forms.Label();
            this.avgSells = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cat_stats_lv = new System.Windows.Forms.ListView();
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHighestSell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.perSells = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.perBids = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalSellsCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(105, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Display results by:";
            // 
            // totalBuys_bttn
            // 
            this.totalBuys_bttn.AutoSize = true;
            this.totalBuys_bttn.Location = new System.Drawing.Point(98, 274);
            this.totalBuys_bttn.Name = "totalBuys_bttn";
            this.totalBuys_bttn.Size = new System.Drawing.Size(56, 17);
            this.totalBuys_bttn.TabIndex = 47;
            this.totalBuys_bttn.TabStop = true;
            this.totalBuys_bttn.Text = "% Bids";
            this.totalBuys_bttn.UseVisualStyleBackColor = true;
            // 
            // totalSells_bttn
            // 
            this.totalSells_bttn.AutoSize = true;
            this.totalSells_bttn.Location = new System.Drawing.Point(98, 243);
            this.totalSells_bttn.Name = "totalSells_bttn";
            this.totalSells_bttn.Size = new System.Drawing.Size(58, 17);
            this.totalSells_bttn.TabIndex = 45;
            this.totalSells_bttn.TabStop = true;
            this.totalSells_bttn.Text = "% Sells";
            this.totalSells_bttn.UseVisualStyleBackColor = true;
            // 
            // sellerRating_bttn
            // 
            this.sellerRating_bttn.AutoSize = true;
            this.sellerRating_bttn.Location = new System.Drawing.Point(98, 181);
            this.sellerRating_bttn.Name = "sellerRating_bttn";
            this.sellerRating_bttn.Size = new System.Drawing.Size(81, 17);
            this.sellerRating_bttn.TabIndex = 44;
            this.sellerRating_bttn.TabStop = true;
            this.sellerRating_bttn.Text = "Highest Sell";
            this.sellerRating_bttn.UseVisualStyleBackColor = true;
            // 
            // avgBids
            // 
            this.avgBids.AutoSize = true;
            this.avgBids.Location = new System.Drawing.Point(523, 251);
            this.avgBids.Name = "avgBids";
            this.avgBids.Size = new System.Drawing.Size(25, 13);
            this.avgBids.TabIndex = 41;
            this.avgBids.Text = "avg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(329, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Average No Auctions Per Category:";
            // 
            // avgBuys
            // 
            this.avgBuys.AutoSize = true;
            this.avgBuys.Location = new System.Drawing.Point(523, 216);
            this.avgBuys.Name = "avgBuys";
            this.avgBuys.Size = new System.Drawing.Size(25, 13);
            this.avgBuys.TabIndex = 39;
            this.avgBuys.Text = "avg";
            // 
            // avgSells
            // 
            this.avgSells.AutoSize = true;
            this.avgSells.Location = new System.Drawing.Point(523, 184);
            this.avgSells.Name = "avgSells";
            this.avgSells.Size = new System.Drawing.Size(25, 13);
            this.avgSells.TabIndex = 38;
            this.avgSells.Text = "avg";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(328, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Average No Bids Per Category:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(328, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Average No Sells Per Category:";
            // 
            // cat_stats_lv
            // 
            this.cat_stats_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColName,
            this.ColHighestSell,
            this.perSells,
            this.perBids,
            this.CodeCol,
            this.totalSellsCol});
            this.cat_stats_lv.GridLines = true;
            this.cat_stats_lv.Location = new System.Drawing.Point(65, 24);
            this.cat_stats_lv.Name = "cat_stats_lv";
            this.cat_stats_lv.Size = new System.Drawing.Size(537, 106);
            this.cat_stats_lv.TabIndex = 35;
            this.cat_stats_lv.UseCompatibleStateImageBehavior = false;
            this.cat_stats_lv.View = System.Windows.Forms.View.Details;
            // 
            // ColName
            // 
            this.ColName.DisplayIndex = 1;
            this.ColName.Text = "Name";
            this.ColName.Width = 108;
            // 
            // ColHighestSell
            // 
            this.ColHighestSell.DisplayIndex = 2;
            this.ColHighestSell.Text = "Highest Sell (€)";
            this.ColHighestSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColHighestSell.Width = 100;
            // 
            // perSells
            // 
            this.perSells.DisplayIndex = 4;
            this.perSells.Text = "% Sells";
            this.perSells.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.perSells.Width = 74;
            // 
            // perBids
            // 
            this.perBids.DisplayIndex = 5;
            this.perBids.Text = "% Bids";
            this.perBids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.perBids.Width = 67;
            // 
            // CodeCol
            // 
            this.CodeCol.DisplayIndex = 0;
            this.CodeCol.Text = "Code";
            this.CodeCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalSellsCol
            // 
            this.totalSellsCol.DisplayIndex = 3;
            this.totalSellsCol.Text = "Total Sells (€)";
            this.totalSellsCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalSellsCol.Width = 122;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(98, 212);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 50;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Total Sells";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Cat_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 347);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.totalBuys_bttn);
            this.Controls.Add(this.totalSells_bttn);
            this.Controls.Add(this.sellerRating_bttn);
            this.Controls.Add(this.avgBids);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.avgBuys);
            this.Controls.Add(this.avgSells);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cat_stats_lv);
            this.Name = "Cat_Stats";
            this.Text = "Product Categories Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton totalBuys_bttn;
        private System.Windows.Forms.RadioButton totalSells_bttn;
        private System.Windows.Forms.RadioButton sellerRating_bttn;
        private System.Windows.Forms.Label avgBids;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label avgBuys;
        private System.Windows.Forms.Label avgSells;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListView cat_stats_lv;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ColumnHeader ColHighestSell;
        private System.Windows.Forms.ColumnHeader perSells;
        private System.Windows.Forms.ColumnHeader perBids;
        private System.Windows.Forms.ColumnHeader CodeCol;
        private System.Windows.Forms.ColumnHeader totalSellsCol;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}