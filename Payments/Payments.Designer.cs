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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPending = new System.Windows.Forms.TabPage();
            this.DeliveryCompLV = new System.Windows.Forms.ListView();
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPurchaseID1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabProcessed = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.tabControl.SuspendLayout();
            this.tabPending.SuspendLayout();
            this.tabProcessed.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPending);
            this.tabControl.Controls.Add(this.tabProcessed);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(985, 405);
            this.tabControl.TabIndex = 0;
            // 
            // tabPending
            // 
            this.tabPending.Controls.Add(this.DeliveryCompLV);
            this.tabPending.Location = new System.Drawing.Point(4, 25);
            this.tabPending.Name = "tabPending";
            this.tabPending.Padding = new System.Windows.Forms.Padding(3);
            this.tabPending.Size = new System.Drawing.Size(977, 376);
            this.tabPending.TabIndex = 0;
            this.tabPending.Text = "Pending";
            this.tabPending.UseVisualStyleBackColor = true;
            // 
            // DeliveryCompLV
            // 
            this.DeliveryCompLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsername,
            this.colPurchaseID1,
            this.colAmount1});
            this.DeliveryCompLV.FullRowSelect = true;
            this.DeliveryCompLV.GridLines = true;
            this.DeliveryCompLV.Location = new System.Drawing.Point(-4, 0);
            this.DeliveryCompLV.Margin = new System.Windows.Forms.Padding(4);
            this.DeliveryCompLV.MultiSelect = false;
            this.DeliveryCompLV.Name = "DeliveryCompLV";
            this.DeliveryCompLV.Size = new System.Drawing.Size(981, 380);
            this.DeliveryCompLV.TabIndex = 1;
            this.DeliveryCompLV.UseCompatibleStateImageBehavior = false;
            this.DeliveryCompLV.View = System.Windows.Forms.View.Details;
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
            this.colAmount1.Text = "Amount";
            this.colAmount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAmount1.Width = 246;
            // 
            // tabProcessed
            // 
            this.tabProcessed.Controls.Add(this.listView1);
            this.tabProcessed.Location = new System.Drawing.Point(4, 25);
            this.tabProcessed.Name = "tabProcessed";
            this.tabProcessed.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcessed.Size = new System.Drawing.Size(977, 376);
            this.tabProcessed.TabIndex = 1;
            this.tabProcessed.Text = "Processed";
            this.tabProcessed.UseVisualStyleBackColor = true;
            this.tabProcessed.Click += new System.EventHandler(this.TabProcessed_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCode,
            this.colUsername2,
            this.colPurchaseID2,
            this.colCreditCardNo,
            this.colCreditCardCVC,
            this.colExpiryDate,
            this.colAmount2,
            this.colBillingAddress,
            this.colDate});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(-4, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(984, 380);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
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
            this.colCreditCardNo.Width = 188;
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
            this.colAmount2.Text = "Amount";
            this.colAmount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.closeButton.Location = new System.Drawing.Point(792, 440);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(128, 37);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(269, 440);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(128, 37);
            this.payButton.TabIndex = 1;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 517);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.tabControl);
            this.Name = "Payments";
            this.Text = "Payments";
            this.tabControl.ResumeLayout(false);
            this.tabPending.ResumeLayout(false);
            this.tabProcessed.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPending;
        private System.Windows.Forms.TabPage tabProcessed;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListView DeliveryCompLV;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colPurchaseID1;
        private System.Windows.Forms.ColumnHeader colAmount1;
        private System.Windows.Forms.ListView listView1;
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
    }
}