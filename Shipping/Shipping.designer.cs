namespace ecommerce
{
    partial class Shipping
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
            this.ShippingLV = new System.Windows.Forms.ListView();
            this.colCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDeliveryCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDispatchDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstimatedArrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOfficialArrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPurchaseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDispatchAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDeliveryAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShippingLV
            // 
            this.ShippingLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCode,
            this.colDeliveryCompany,
            this.colDispatchDate,
            this.colEstimatedArrival,
            this.colOfficialArrival,
            this.colPurchaseID,
            this.colReference,
            this.colDispatchAddress,
            this.colDeliveryAdress});
            this.ShippingLV.FullRowSelect = true;
            this.ShippingLV.GridLines = true;
            this.ShippingLV.Location = new System.Drawing.Point(31, 78);
            this.ShippingLV.Margin = new System.Windows.Forms.Padding(4);
            this.ShippingLV.MultiSelect = false;
            this.ShippingLV.Name = "ShippingLV";
            this.ShippingLV.Size = new System.Drawing.Size(727, 278);
            this.ShippingLV.TabIndex = 2;
            this.ShippingLV.UseCompatibleStateImageBehavior = false;
            this.ShippingLV.View = System.Windows.Forms.View.Details;
            // 
            // colCode
            // 
            this.colCode.Text = "Code";
            this.colCode.Width = 73;
            // 
            // colDeliveryCompany
            // 
            this.colDeliveryCompany.Text = "Delivery Company";
            this.colDeliveryCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDeliveryCompany.Width = 137;
            // 
            // colDispatchDate
            // 
            this.colDispatchDate.Text = "Dispatch Date";
            this.colDispatchDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDispatchDate.Width = 109;
            // 
            // colEstimatedArrival
            // 
            this.colEstimatedArrival.Text = "EstimatedArrival";
            this.colEstimatedArrival.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEstimatedArrival.Width = 159;
            // 
            // colOfficialArrival
            // 
            this.colOfficialArrival.Text = "Official Arrival";
            this.colOfficialArrival.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colOfficialArrival.Width = 99;
            // 
            // colPurchaseID
            // 
            this.colPurchaseID.Text = "Purchase ID";
            this.colPurchaseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colReference
            // 
            this.colReference.Text = "Reference";
            this.colReference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colDispatchAddress
            // 
            this.colDispatchAddress.Text = "Dispatch Address";
            this.colDispatchAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colDeliveryAdress
            // 
            this.colDeliveryAdress.Text = "Delivery Address";
            this.colDeliveryAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(302, 385);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // Shipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.ShippingLV);
            this.Name = "Shipping";
            this.Text = "Shipping";
            this.Load += new System.EventHandler(this.Shipping_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ShippingLV;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colDeliveryCompany;
        private System.Windows.Forms.ColumnHeader colDispatchDate;
        private System.Windows.Forms.ColumnHeader colEstimatedArrival;
        private System.Windows.Forms.ColumnHeader colOfficialArrival;
        private System.Windows.Forms.ColumnHeader colPurchaseID;
        private System.Windows.Forms.ColumnHeader colReference;
        private System.Windows.Forms.ColumnHeader colDispatchAddress;
        private System.Windows.Forms.ColumnHeader colDeliveryAdress;
        private System.Windows.Forms.Button closeButton;
    }
}