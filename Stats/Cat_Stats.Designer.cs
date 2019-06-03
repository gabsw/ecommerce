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
            this.PerBids_bttn = new System.Windows.Forms.RadioButton();
            this.PerSells_bttn = new System.Windows.Forms.RadioButton();
            this.highestSell_bttn = new System.Windows.Forms.RadioButton();
            this.avgAuctions = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.avgBids = new System.Windows.Forms.Label();
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
            this.totalSells_bttn = new System.Windows.Forms.RadioButton();
            this.totalProdSold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code_bttn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(145, 322);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Display results by:";
            // 
            // PerBids_bttn
            // 
            this.PerBids_bttn.AutoSize = true;
            this.PerBids_bttn.Location = new System.Drawing.Point(148, 469);
            this.PerBids_bttn.Name = "PerBids_bttn";
            this.PerBids_bttn.Size = new System.Drawing.Size(56, 17);
            this.PerBids_bttn.TabIndex = 47;
            this.PerBids_bttn.TabStop = true;
            this.PerBids_bttn.Text = "% Bids";
            this.PerBids_bttn.UseVisualStyleBackColor = true;
            this.PerBids_bttn.CheckedChanged += new System.EventHandler(this.PerBids_bttn_CheckedChanged);
            // 
            // PerSells_bttn
            // 
            this.PerSells_bttn.AutoSize = true;
            this.PerSells_bttn.Location = new System.Drawing.Point(148, 438);
            this.PerSells_bttn.Name = "PerSells_bttn";
            this.PerSells_bttn.Size = new System.Drawing.Size(58, 17);
            this.PerSells_bttn.TabIndex = 45;
            this.PerSells_bttn.TabStop = true;
            this.PerSells_bttn.Text = "% Sells";
            this.PerSells_bttn.UseVisualStyleBackColor = true;
            this.PerSells_bttn.CheckedChanged += new System.EventHandler(this.PerSells_bttn_CheckedChanged);
            // 
            // highestSell_bttn
            // 
            this.highestSell_bttn.AutoSize = true;
            this.highestSell_bttn.Location = new System.Drawing.Point(148, 376);
            this.highestSell_bttn.Name = "highestSell_bttn";
            this.highestSell_bttn.Size = new System.Drawing.Size(81, 17);
            this.highestSell_bttn.TabIndex = 44;
            this.highestSell_bttn.TabStop = true;
            this.highestSell_bttn.Text = "Highest Sell";
            this.highestSell_bttn.UseVisualStyleBackColor = true;
            this.highestSell_bttn.CheckedChanged += new System.EventHandler(this.highestSell_bttn_CheckedChanged);
            // 
            // avgAuctions
            // 
            this.avgAuctions.AutoSize = true;
            this.avgAuctions.Location = new System.Drawing.Point(573, 432);
            this.avgAuctions.Name = "avgAuctions";
            this.avgAuctions.Size = new System.Drawing.Size(25, 13);
            this.avgAuctions.TabIndex = 41;
            this.avgAuctions.Text = "avg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(379, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Average No Auctions Per Category:";
            // 
            // avgBids
            // 
            this.avgBids.AutoSize = true;
            this.avgBids.Location = new System.Drawing.Point(573, 397);
            this.avgBids.Name = "avgBids";
            this.avgBids.Size = new System.Drawing.Size(25, 13);
            this.avgBids.TabIndex = 39;
            this.avgBids.Text = "avg";
            // 
            // avgSells
            // 
            this.avgSells.AutoSize = true;
            this.avgSells.Location = new System.Drawing.Point(573, 365);
            this.avgSells.Name = "avgSells";
            this.avgSells.Size = new System.Drawing.Size(25, 13);
            this.avgSells.TabIndex = 38;
            this.avgSells.Text = "avg";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(378, 397);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Average No Bids Per Category:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(378, 365);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Average No Sells Per Category:";
            // 
            // cat_stats_lv
            // 
            this.cat_stats_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodeCol,
            this.ColName,
            this.ColHighestSell,
            this.totalSellsCol,
            this.totalProdSold,
            this.perSells,
            this.perBids});
            this.cat_stats_lv.GridLines = true;
            this.cat_stats_lv.Location = new System.Drawing.Point(72, 10);
            this.cat_stats_lv.Name = "cat_stats_lv";
            this.cat_stats_lv.Size = new System.Drawing.Size(639, 297);
            this.cat_stats_lv.TabIndex = 35;
            this.cat_stats_lv.UseCompatibleStateImageBehavior = false;
            this.cat_stats_lv.View = System.Windows.Forms.View.Details;
            // 
            // ColName
            // 
            this.ColName.Text = "Name";
            this.ColName.Width = 108;
            // 
            // ColHighestSell
            // 
            this.ColHighestSell.Text = "Highest Sell (€)";
            this.ColHighestSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColHighestSell.Width = 100;
            // 
            // perSells
            // 
            this.perSells.Text = "% Sells";
            this.perSells.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.perSells.Width = 74;
            // 
            // perBids
            // 
            this.perBids.Text = "% Bids";
            this.perBids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.perBids.Width = 67;
            // 
            // CodeCol
            // 
            this.CodeCol.Text = "Code";
            this.CodeCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalSellsCol
            // 
            this.totalSellsCol.Text = "Total Sells (€)";
            this.totalSellsCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalSellsCol.Width = 122;
            // 
            // totalSells_bttn
            // 
            this.totalSells_bttn.AutoSize = true;
            this.totalSells_bttn.Location = new System.Drawing.Point(148, 407);
            this.totalSells_bttn.Name = "totalSells_bttn";
            this.totalSells_bttn.Size = new System.Drawing.Size(74, 17);
            this.totalSells_bttn.TabIndex = 50;
            this.totalSells_bttn.TabStop = true;
            this.totalSells_bttn.Text = "Total Sells";
            this.totalSells_bttn.UseVisualStyleBackColor = true;
            this.totalSells_bttn.CheckedChanged += new System.EventHandler(this.totalSells_bttn_CheckedChanged);
            // 
            // totalProdSold
            // 
            this.totalProdSold.Text = "No Products Sold";
            this.totalProdSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalProdSold.Width = 102;
            // 
            // code_bttn
            // 
            this.code_bttn.AutoSize = true;
            this.code_bttn.Location = new System.Drawing.Point(148, 353);
            this.code_bttn.Name = "code_bttn";
            this.code_bttn.Size = new System.Drawing.Size(50, 17);
            this.code_bttn.TabIndex = 51;
            this.code_bttn.TabStop = true;
            this.code_bttn.Text = "Code";
            this.code_bttn.UseVisualStyleBackColor = true;
            this.code_bttn.CheckedChanged += new System.EventHandler(this.code_bttn_CheckedChanged);
            // 
            // Cat_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 522);
            this.Controls.Add(this.code_bttn);
            this.Controls.Add(this.totalSells_bttn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.PerBids_bttn);
            this.Controls.Add(this.PerSells_bttn);
            this.Controls.Add(this.highestSell_bttn);
            this.Controls.Add(this.avgAuctions);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.avgBids);
            this.Controls.Add(this.avgSells);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cat_stats_lv);
            this.Name = "Cat_Stats";
            this.Text = "Product Categories Statistics";
            this.Load += new System.EventHandler(this.Cat_Stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton PerBids_bttn;
        private System.Windows.Forms.RadioButton PerSells_bttn;
        private System.Windows.Forms.RadioButton highestSell_bttn;
        private System.Windows.Forms.Label avgAuctions;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label avgBids;
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
        private System.Windows.Forms.RadioButton totalSells_bttn;
        private System.Windows.Forms.ColumnHeader totalProdSold;
        private System.Windows.Forms.RadioButton code_bttn;
    }
}