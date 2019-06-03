namespace ecommerce
{
    partial class Pending_Payment
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.purchaseBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buyerBox = new System.Windows.Forms.ComboBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.payPendLV = new System.Windows.Forms.ListView();
            this.purchase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buyer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 130;
            this.label4.Text = "Search Filters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 129;
            this.label2.Text = "Purchases:";
            // 
            // purchaseBox
            // 
            this.purchaseBox.FormattingEnabled = true;
            this.purchaseBox.Location = new System.Drawing.Point(578, 171);
            this.purchaseBox.Name = "purchaseBox";
            this.purchaseBox.Size = new System.Drawing.Size(186, 21);
            this.purchaseBox.TabIndex = 128;
            this.purchaseBox.SelectedIndexChanged += new System.EventHandler(this.purchaseBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 127;
            this.label1.Text = "Buyer\'s username:";
            // 
            // buyerBox
            // 
            this.buyerBox.FormattingEnabled = true;
            this.buyerBox.Location = new System.Drawing.Point(577, 105);
            this.buyerBox.Name = "buyerBox";
            this.buyerBox.Size = new System.Drawing.Size(186, 21);
            this.buyerBox.TabIndex = 126;
            this.buyerBox.SelectedIndexChanged += new System.EventHandler(this.buyerBox_SelectedIndexChanged);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(254, 274);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(88, 22);
            this.clear_button.TabIndex = 125;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(421, 274);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(72, 25);
            this.refreshButton.TabIndex = 124;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(90, 271);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(82, 25);
            this.payButton.TabIndex = 123;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // payPendLV
            // 
            this.payPendLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.purchase,
            this.buyer,
            this.amount,
            this.date});
            this.payPendLV.FullRowSelect = true;
            this.payPendLV.GridLines = true;
            this.payPendLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.payPendLV.Location = new System.Drawing.Point(51, 33);
            this.payPendLV.MultiSelect = false;
            this.payPendLV.Name = "payPendLV";
            this.payPendLV.Size = new System.Drawing.Size(489, 204);
            this.payPendLV.TabIndex = 122;
            this.payPendLV.UseCompatibleStateImageBehavior = false;
            this.payPendLV.View = System.Windows.Forms.View.Details;
            // 
            // purchase
            // 
            this.purchase.Text = "Purchase ID";
            this.purchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.purchase.Width = 72;
            // 
            // buyer
            // 
            this.buyer.Text = "Buyer";
            this.buyer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buyer.Width = 107;
            // 
            // amount
            // 
            this.amount.Text = "Amount (€)";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount.Width = 78;
            // 
            // date
            // 
            this.date.Text = "Purchase Date";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Width = 225;
            // 
            // Pending_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.purchaseBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyerBox);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.payPendLV);
            this.Name = "Pending_Payment";
            this.Text = "Pending Payments";
            this.Load += new System.EventHandler(this.Pending_Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox purchaseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox buyerBox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.ListView payPendLV;
        private System.Windows.Forms.ColumnHeader purchase;
        private System.Windows.Forms.ColumnHeader buyer;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader date;
    }
}