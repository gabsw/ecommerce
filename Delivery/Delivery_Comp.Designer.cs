namespace ecommerce
{
    partial class Delivery_Comp
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
            this.DeliveryCompLV = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updateButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeliveryCompLV
            // 
            this.DeliveryCompLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colNumber,
            this.colAddress,
            this.colExpress});
            this.DeliveryCompLV.FullRowSelect = true;
            this.DeliveryCompLV.GridLines = true;
            this.DeliveryCompLV.Location = new System.Drawing.Point(51, 57);
            this.DeliveryCompLV.MultiSelect = false;
            this.DeliveryCompLV.Name = "DeliveryCompLV";
            this.DeliveryCompLV.Size = new System.Drawing.Size(655, 258);
            this.DeliveryCompLV.TabIndex = 0;
            this.DeliveryCompLV.UseCompatibleStateImageBehavior = false;
            this.DeliveryCompLV.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 101;
            // 
            // colNumber
            // 
            this.colNumber.Text = "Contact Number";
            this.colNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNumber.Width = 115;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAddress.Width = 334;
            // 
            // colExpress
            // 
            this.colExpress.Text = "Express Delivery";
            this.colExpress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colExpress.Width = 99;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(357, 347);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(68, 20);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(444, 347);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(67, 20);
            this.refreshButton.TabIndex = 8;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(266, 347);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(67, 20);
            this.AddNewButton.TabIndex = 7;
            this.AddNewButton.Text = "Add New";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // Delivery_Comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 431);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.DeliveryCompLV);
            this.Name = "Delivery_Comp";
            this.Text = "Delivery Companies";
            this.Load += new System.EventHandler(this.Delivery_Comp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DeliveryCompLV;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colNumber;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colExpress;
    }
}