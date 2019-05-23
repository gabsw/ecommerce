namespace ecommerce
{
    partial class DebitHistory
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
            this.DebitHistlistView = new System.Windows.Forms.ListView();
            this.debitid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountDebit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IBAN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.accIDlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totaldeb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DebitHistlistView
            // 
            this.DebitHistlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.debitid,
            this.AmountDebit,
            this.IBAN,
            this.Date});
            this.DebitHistlistView.GridLines = true;
            this.DebitHistlistView.Location = new System.Drawing.Point(25, 99);
            this.DebitHistlistView.Name = "DebitHistlistView";
            this.DebitHistlistView.Size = new System.Drawing.Size(477, 274);
            this.DebitHistlistView.TabIndex = 0;
            this.DebitHistlistView.UseCompatibleStateImageBehavior = false;
            this.DebitHistlistView.View = System.Windows.Forms.View.Details;
            // 
            // debitid
            // 
            this.debitid.Text = "Debit ID";
            // 
            // AmountDebit
            // 
            this.AmountDebit.Text = "Amount (€)";
            this.AmountDebit.Width = 67;
            // 
            // IBAN
            // 
            this.IBAN.Text = "IBAN";
            this.IBAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IBAN.Width = 187;
            // 
            // Date
            // 
            this.Date.Text = "Operation Date";
            this.Date.Width = 152;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account ID:";
            // 
            // accIDlabel
            // 
            this.accIDlabel.AutoSize = true;
            this.accIDlabel.Location = new System.Drawing.Point(95, 9);
            this.accIDlabel.Name = "accIDlabel";
            this.accIDlabel.Size = new System.Drawing.Size(35, 13);
            this.accIDlabel.TabIndex = 2;
            this.accIDlabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Debits:";
            // 
            // totaldeb
            // 
            this.totaldeb.AutoSize = true;
            this.totaldeb.Location = new System.Drawing.Point(95, 39);
            this.totaldeb.Name = "totaldeb";
            this.totaldeb.Size = new System.Drawing.Size(0, 13);
            this.totaldeb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "€";
            // 
            // DebitHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totaldeb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accIDlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DebitHistlistView);
            this.Name = "DebitHistory";
            this.Text = "Debit History";
            this.Load += new System.EventHandler(this.DebitHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DebitHistlistView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accIDlabel;
        private System.Windows.Forms.ColumnHeader AmountDebit;
        private System.Windows.Forms.ColumnHeader IBAN;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totaldeb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader debitid;
    }
}