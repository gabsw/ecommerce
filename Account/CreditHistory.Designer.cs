namespace ecommerce
{
    partial class CreditHistory
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
            this.CreditlistView = new System.Windows.Forms.ListView();
            this.creditID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.credAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.payCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datecred = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accID_label = new System.Windows.Forms.Label();
            this.totalcred = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreditlistView
            // 
            this.CreditlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.creditID,
            this.credAmount,
            this.payCode,
            this.datecred});
            this.CreditlistView.GridLines = true;
            this.CreditlistView.Location = new System.Drawing.Point(26, 85);
            this.CreditlistView.Name = "CreditlistView";
            this.CreditlistView.Size = new System.Drawing.Size(356, 271);
            this.CreditlistView.TabIndex = 0;
            this.CreditlistView.UseCompatibleStateImageBehavior = false;
            this.CreditlistView.View = System.Windows.Forms.View.Details;
            // 
            // creditID
            // 
            this.creditID.Text = "Credit ID";
            // 
            // credAmount
            // 
            this.credAmount.Text = "Amount (€)";
            this.credAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.credAmount.Width = 81;
            // 
            // payCode
            // 
            this.payCode.Text = "Payment Code";
            this.payCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.payCode.Width = 85;
            // 
            // datecred
            // 
            this.datecred.Text = "Operation Date";
            this.datecred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datecred.Width = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Credits:";
            // 
            // accID_label
            // 
            this.accID_label.AutoSize = true;
            this.accID_label.Location = new System.Drawing.Point(130, 17);
            this.accID_label.Name = "accID_label";
            this.accID_label.Size = new System.Drawing.Size(35, 13);
            this.accID_label.TabIndex = 3;
            this.accID_label.Text = "label3";
            // 
            // totalcred
            // 
            this.totalcred.AutoSize = true;
            this.totalcred.Location = new System.Drawing.Point(130, 39);
            this.totalcred.Name = "totalcred";
            this.totalcred.Size = new System.Drawing.Size(0, 13);
            this.totalcred.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "€";
            // 
            // CreditHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 399);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalcred);
            this.Controls.Add(this.accID_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreditlistView);
            this.Name = "CreditHistory";
            this.Text = "Credit History";
            this.Load += new System.EventHandler(this.CreditHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CreditlistView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accID_label;
        private System.Windows.Forms.Label totalcred;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader creditID;
        private System.Windows.Forms.ColumnHeader credAmount;
        private System.Windows.Forms.ColumnHeader payCode;
        private System.Windows.Forms.ColumnHeader datecred;
    }
}