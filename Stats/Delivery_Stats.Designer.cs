namespace ecommerce
{
    partial class Delivery_Stats
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
            this.perDel = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.perlatedel_bttn = new System.Windows.Forms.RadioButton();
            this.late_del_bttn = new System.Windows.Forms.RadioButton();
            this.total_del_bttn = new System.Windows.Forms.RadioButton();
            this.avgBuys = new System.Windows.Forms.Label();
            this.avgSells = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.del_stats_lv = new System.Windows.Forms.ListView();
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalShip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalLate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.perShip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lateShip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // perDel
            // 
            this.perDel.AutoSize = true;
            this.perDel.Location = new System.Drawing.Point(127, 223);
            this.perDel.Name = "perDel";
            this.perDel.Size = new System.Drawing.Size(82, 17);
            this.perDel.TabIndex = 62;
            this.perDel.TabStop = true;
            this.perDel.Text = "% Deliveries";
            this.perDel.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(134, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 61;
            this.label17.Text = "Display results by:";
            // 
            // perlatedel_bttn
            // 
            this.perlatedel_bttn.AutoSize = true;
            this.perlatedel_bttn.Location = new System.Drawing.Point(127, 285);
            this.perlatedel_bttn.Name = "perlatedel_bttn";
            this.perlatedel_bttn.Size = new System.Drawing.Size(106, 17);
            this.perlatedel_bttn.TabIndex = 60;
            this.perlatedel_bttn.TabStop = true;
            this.perlatedel_bttn.Text = "% Late Deliveries";
            this.perlatedel_bttn.UseVisualStyleBackColor = true;
            // 
            // late_del_bttn
            // 
            this.late_del_bttn.AutoSize = true;
            this.late_del_bttn.Location = new System.Drawing.Point(127, 254);
            this.late_del_bttn.Name = "late_del_bttn";
            this.late_del_bttn.Size = new System.Drawing.Size(122, 17);
            this.late_del_bttn.TabIndex = 59;
            this.late_del_bttn.TabStop = true;
            this.late_del_bttn.Text = "Total Late Deliveries";
            this.late_del_bttn.UseVisualStyleBackColor = true;
            // 
            // total_del_bttn
            // 
            this.total_del_bttn.AutoSize = true;
            this.total_del_bttn.Location = new System.Drawing.Point(127, 192);
            this.total_del_bttn.Name = "total_del_bttn";
            this.total_del_bttn.Size = new System.Drawing.Size(98, 17);
            this.total_del_bttn.TabIndex = 58;
            this.total_del_bttn.TabStop = true;
            this.total_del_bttn.Text = "Total Deliveries";
            this.total_del_bttn.UseVisualStyleBackColor = true;
            // 
            // avgBuys
            // 
            this.avgBuys.AutoSize = true;
            this.avgBuys.Location = new System.Drawing.Point(630, 227);
            this.avgBuys.Name = "avgBuys";
            this.avgBuys.Size = new System.Drawing.Size(25, 13);
            this.avgBuys.TabIndex = 55;
            this.avgBuys.Text = "avg";
            // 
            // avgSells
            // 
            this.avgSells.AutoSize = true;
            this.avgSells.Location = new System.Drawing.Point(630, 196);
            this.avgSells.Name = "avgSells";
            this.avgSells.Size = new System.Drawing.Size(25, 13);
            this.avgSells.TabIndex = 54;
            this.avgSells.Text = "avg";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(357, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(248, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Average No Companies that offer Express Delivery:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(357, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(206, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Average No Late Deliveries Per Company:";
            // 
            // del_stats_lv
            // 
            this.del_stats_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColName,
            this.totalShip,
            this.totalLate,
            this.perShip,
            this.lateShip});
            this.del_stats_lv.GridLines = true;
            this.del_stats_lv.Location = new System.Drawing.Point(112, 28);
            this.del_stats_lv.Name = "del_stats_lv";
            this.del_stats_lv.Size = new System.Drawing.Size(543, 106);
            this.del_stats_lv.TabIndex = 51;
            this.del_stats_lv.UseCompatibleStateImageBehavior = false;
            this.del_stats_lv.View = System.Windows.Forms.View.Details;
            // 
            // ColName
            // 
            this.ColName.Text = "Name";
            this.ColName.Width = 108;
            // 
            // totalShip
            // 
            this.totalShip.Text = "Total Deliveries";
            this.totalShip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalShip.Width = 100;
            // 
            // totalLate
            // 
            this.totalLate.DisplayIndex = 3;
            this.totalLate.Text = "Total Late Deliveries";
            this.totalLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalLate.Width = 119;
            // 
            // perShip
            // 
            this.perShip.DisplayIndex = 2;
            this.perShip.Text = "% Deliveries";
            this.perShip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.perShip.Width = 89;
            // 
            // lateShip
            // 
            this.lateShip.Text = "% Late Deliveries";
            this.lateShip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lateShip.Width = 122;
            // 
            // Delivery_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.perDel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.perlatedel_bttn);
            this.Controls.Add(this.late_del_bttn);
            this.Controls.Add(this.total_del_bttn);
            this.Controls.Add(this.avgBuys);
            this.Controls.Add(this.avgSells);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.del_stats_lv);
            this.Name = "Delivery_Stats";
            this.Text = "Delivery_Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton perDel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton perlatedel_bttn;
        private System.Windows.Forms.RadioButton late_del_bttn;
        private System.Windows.Forms.RadioButton total_del_bttn;
        private System.Windows.Forms.Label avgBuys;
        private System.Windows.Forms.Label avgSells;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListView del_stats_lv;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ColumnHeader totalShip;
        private System.Windows.Forms.ColumnHeader totalLate;
        private System.Windows.Forms.ColumnHeader perShip;
        private System.Windows.Forms.ColumnHeader lateShip;
    }
}