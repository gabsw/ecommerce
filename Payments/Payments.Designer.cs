namespace ecommerce
{
    partial class Payments
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPending = new System.Windows.Forms.TabPage();
            this.pendingPaymentsLV = new System.Windows.Forms.ListView();
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPurchaseID1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabProcessed = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.processedPaymentsLV = new System.Windows.Forms.ListView();
            this.colCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsername2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPurchaseID2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCreditCardNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCreditCardCVC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpiryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBillingAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.labelTotalPayments = new System.Windows.Forms.Label();
            this.labelPayments = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelComissionCharges = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPending.SuspendLayout();
            this.tabProcessed.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPending);
            this.tabControl1.Controls.Add(this.tabProcessed);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPending
            // 
            this.tabPending.Controls.Add(this.pendingPaymentsLV);
            this.tabPending.Location = new System.Drawing.Point(4, 25);
            this.tabPending.Name = "tabPending";
            this.tabPending.Padding = new System.Windows.Forms.Padding(3);
            this.tabPending.Size = new System.Drawing.Size(977, 376);
            this.tabPending.TabIndex = 0;
            this.tabPending.Text = "Pending";
            this.tabPending.UseVisualStyleBackColor = true;
            // 
            // pendingPaymentsLV
            // 
            this.pendingPaymentsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsername,
            this.colPurchaseID1,
            this.colAmount1});
            this.pendingPaymentsLV.FullRowSelect = true;
            this.pendingPaymentsLV.GridLines = true;
            this.pendingPaymentsLV.Location = new System.Drawing.Point(-4, 0);
            this.pendingPaymentsLV.Margin = new System.Windows.Forms.Padding(4);
            this.pendingPaymentsLV.MultiSelect = false;
            this.pendingPaymentsLV.Name = "pendingPaymentsLV";
            this.pendingPaymentsLV.Size = new System.Drawing.Size(981, 424);
            this.pendingPaymentsLV.TabIndex = 1;
            this.pendingPaymentsLV.UseCompatibleStateImageBehavior = false;
            this.pendingPaymentsLV.View = System.Windows.Forms.View.Details;
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            this.colUsername.Width = 182;
            // 
            // colPurchaseID1
            // 
            this.colPurchaseID1.Text = "Purchase ID";
            this.colPurchaseID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPurchaseID1.Width = 419;
            // 
            // colAmount1
            // 
            this.colAmount1.Text = "Amount (€)";
            this.colAmount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAmount1.Width = 246;
            // 
            // tabProcessed
            // 
            this.tabProcessed.Controls.Add(this.tabControl2);
            this.tabProcessed.Controls.Add(this.processedPaymentsLV);
            this.tabProcessed.Location = new System.Drawing.Point(4, 25);
            this.tabProcessed.Name = "tabProcessed";
            this.tabProcessed.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcessed.Size = new System.Drawing.Size(977, 376);
            this.tabProcessed.TabIndex = 1;
            this.tabProcessed.Text = "Processed";
            this.tabProcessed.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(-44, -94);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(200, 100);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(192, 71);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 71);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // processedPaymentsLV
            // 
            this.processedPaymentsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCode,
            this.colUsername2,
            this.colPurchaseID2,
            this.colCreditCardNo,
            this.colCreditCardCVC,
            this.colExpiryDate,
            this.colAmount2,
            this.colBillingAddress,
            this.colDate});
            this.processedPaymentsLV.FullRowSelect = true;
            this.processedPaymentsLV.GridLines = true;
            this.processedPaymentsLV.Location = new System.Drawing.Point(-4, 0);
            this.processedPaymentsLV.Margin = new System.Windows.Forms.Padding(4);
            this.processedPaymentsLV.MultiSelect = false;
            this.processedPaymentsLV.Name = "processedPaymentsLV";
            this.processedPaymentsLV.Size = new System.Drawing.Size(984, 380);
            this.processedPaymentsLV.TabIndex = 1;
            this.processedPaymentsLV.UseCompatibleStateImageBehavior = false;
            this.processedPaymentsLV.View = System.Windows.Forms.View.Details;
            // 
            // colCode
            // 
            this.colCode.Text = "Code";
            this.colCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCode.Width = 72;
            // 
            // colUsername2
            // 
            this.colUsername2.Text = "Username";
            this.colUsername2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colUsername2.Width = 101;
            // 
            // colPurchaseID2
            // 
            this.colPurchaseID2.Text = "Purchase ID";
            this.colPurchaseID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPurchaseID2.Width = 115;
            // 
            // colCreditCardNo
            // 
            this.colCreditCardNo.Text = "Credit Card Number";
            this.colCreditCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCreditCardNo.Width = 183;
            // 
            // colCreditCardCVC
            // 
            this.colCreditCardCVC.Text = "CVC";
            this.colCreditCardCVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCreditCardCVC.Width = 67;
            // 
            // colExpiryDate
            // 
            this.colExpiryDate.Text = "Expiry Date";
            this.colExpiryDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colExpiryDate.Width = 111;
            // 
            // colAmount2
            // 
            this.colAmount2.Text = "Amount (€)";
            this.colAmount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAmount2.Width = 82;
            // 
            // colBillingAddress
            // 
            this.colBillingAddress.Text = "Billing Address";
            this.colBillingAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBillingAddress.Width = 119;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDate.Width = 145;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(770, 469);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(128, 37);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(141, 469);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(128, 37);
            this.payButton.TabIndex = 1;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            // 
            // labelTotalPayments
            // 
            this.labelTotalPayments.AutoSize = true;
            this.labelTotalPayments.Location = new System.Drawing.Point(616, 457);
            this.labelTotalPayments.Name = "labelTotalPayments";
            this.labelTotalPayments.Size = new System.Drawing.Size(35, 17);
            this.labelTotalPayments.TabIndex = 12;
            this.labelTotalPayments.Text = "total";
            // 
            // labelPayments
            // 
            this.labelPayments.AutoSize = true;
            this.labelPayments.Location = new System.Drawing.Point(319, 462);
            this.labelPayments.Name = "labelPayments";
            this.labelPayments.Size = new System.Drawing.Size(181, 17);
            this.labelPayments.TabIndex = 11;
            this.labelPayments.Text = "Total Payments Processed:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(616, 479);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(35, 17);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total Amount Spent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Comission Charges:";
            // 
            // labelComissionCharges
            // 
            this.labelComissionCharges.AutoSize = true;
            this.labelComissionCharges.Location = new System.Drawing.Point(616, 496);
            this.labelComissionCharges.Name = "labelComissionCharges";
            this.labelComissionCharges.Size = new System.Drawing.Size(35, 17);
            this.labelComissionCharges.TabIndex = 14;
            this.labelComissionCharges.Text = "total";
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 553);
            this.Controls.Add(this.labelComissionCharges);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTotalPayments);
            this.Controls.Add(this.labelPayments);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Payments";
            this.Text = "Payments";
            this.tabControl1.ResumeLayout(false);
            this.tabPending.ResumeLayout(false);
            this.tabProcessed.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPending;
        private System.Windows.Forms.TabPage tabProcessed;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListView pendingPaymentsLV;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colPurchaseID1;
        private System.Windows.Forms.ColumnHeader colAmount1;
        private System.Windows.Forms.ListView processedPaymentsLV;
        private System.Windows.Forms.ColumnHeader colUsername2;
        private System.Windows.Forms.ColumnHeader colPurchaseID2;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colCreditCardNo;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.ColumnHeader colCreditCardCVC;
        private System.Windows.Forms.ColumnHeader colExpiryDate;
        private System.Windows.Forms.ColumnHeader colAmount2;
        private System.Windows.Forms.ColumnHeader colBillingAddress;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labelTotalPayments;
        private System.Windows.Forms.Label labelPayments;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelComissionCharges;
    }
}