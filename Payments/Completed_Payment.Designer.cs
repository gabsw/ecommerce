namespace ecommerce
{
    partial class Completed_Payment
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
            this.readButton = new System.Windows.Forms.Button();
            this.payCompLV = new System.Windows.Forms.ListView();
            this.paymentCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.purchase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buyer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.payBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(631, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 121;
            this.label4.Text = "Search Filters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Purchases:";
            // 
            // purchaseBox
            // 
            this.purchaseBox.FormattingEnabled = true;
            this.purchaseBox.Location = new System.Drawing.Point(583, 164);
            this.purchaseBox.Name = "purchaseBox";
            this.purchaseBox.Size = new System.Drawing.Size(186, 21);
            this.purchaseBox.TabIndex = 117;
            this.purchaseBox.SelectedIndexChanged += new System.EventHandler(this.purchaseBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Buyer\'s username:";
            // 
            // buyerBox
            // 
            this.buyerBox.FormattingEnabled = true;
            this.buyerBox.Location = new System.Drawing.Point(582, 98);
            this.buyerBox.Name = "buyerBox";
            this.buyerBox.Size = new System.Drawing.Size(186, 21);
            this.buyerBox.TabIndex = 115;
            this.buyerBox.SelectedIndexChanged += new System.EventHandler(this.buyerBox_SelectedIndexChanged);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(288, 271);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(88, 22);
            this.clear_button.TabIndex = 114;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(455, 271);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(72, 25);
            this.refreshButton.TabIndex = 113;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(57, 268);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(158, 25);
            this.readButton.TabIndex = 112;
            this.readButton.Text = "Read Full Payment Details";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // payCompLV
            // 
            this.payCompLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.paymentCode,
            this.purchase,
            this.buyer,
            this.amount,
            this.date});
            this.payCompLV.FullRowSelect = true;
            this.payCompLV.GridLines = true;
            this.payCompLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.payCompLV.Location = new System.Drawing.Point(28, 25);
            this.payCompLV.MultiSelect = false;
            this.payCompLV.Name = "payCompLV";
            this.payCompLV.Size = new System.Drawing.Size(524, 204);
            this.payCompLV.TabIndex = 111;
            this.payCompLV.UseCompatibleStateImageBehavior = false;
            this.payCompLV.View = System.Windows.Forms.View.Details;
            // 
            // paymentCode
            // 
            this.paymentCode.Text = "Payment Code";
            this.paymentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paymentCode.Width = 90;
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
            this.date.Text = "Payment Date";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Width = 170;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 123;
            this.label3.Text = "Payment Code:";
            // 
            // payBox
            // 
            this.payBox.FormattingEnabled = true;
            this.payBox.Location = new System.Drawing.Point(582, 236);
            this.payBox.Name = "payBox";
            this.payBox.Size = new System.Drawing.Size(186, 21);
            this.payBox.TabIndex = 122;
            this.payBox.SelectedIndexChanged += new System.EventHandler(this.payBox_SelectedIndexChanged);
            // 
            // Completed_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.payBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.purchaseBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyerBox);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.payCompLV);
            this.Name = "Completed_Payment";
            this.Text = "Completed Payments";
            this.Load += new System.EventHandler(this.Completed_Payment_Load);
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
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.ListView payCompLV;
        private System.Windows.Forms.ColumnHeader paymentCode;
        private System.Windows.Forms.ColumnHeader purchase;
        private System.Windows.Forms.ColumnHeader buyer;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox payBox;
    }
}