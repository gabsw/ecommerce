namespace ecommerce
{
    partial class InternalOperation
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
            this.InternalOperationLV = new System.Windows.Forms.ListView();
            this.ioID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ioCommission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ioVATCollected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ioDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ioPaymentCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InternalOperationLV
            // 
            this.InternalOperationLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ioID,
            this.ioCommission,
            this.ioVATCollected,
            this.ioDate,
            this.ioPaymentCode});
            this.InternalOperationLV.FullRowSelect = true;
            this.InternalOperationLV.GridLines = true;
            this.InternalOperationLV.Location = new System.Drawing.Point(-3, 80);
            this.InternalOperationLV.Margin = new System.Windows.Forms.Padding(4);
            this.InternalOperationLV.MultiSelect = false;
            this.InternalOperationLV.Name = "InternalOperationLV";
            this.InternalOperationLV.Size = new System.Drawing.Size(804, 287);
            this.InternalOperationLV.TabIndex = 2;
            this.InternalOperationLV.UseCompatibleStateImageBehavior = false;
            this.InternalOperationLV.View = System.Windows.Forms.View.Details;
            this.Load += new System.EventHandler(this.InternalOperation_Load);

            // 
            // ioID
            // 
            this.ioID.Text = "ID";
            this.ioID.Width = 69;
            // 
            // ioCommission
            // 
            this.ioCommission.Text = "Commission";
            this.ioCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ioCommission.Width = 130;
            // 
            // ioVATCollected
            // 
            this.ioVATCollected.Text = "VAT Collected";
            this.ioVATCollected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ioVATCollected.Width = 144;
            // 
            // ioDate
            // 
            this.ioDate.Text = "Date";
            this.ioDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ioDate.Width = 156;
            // 
            // ioPaymentCode
            // 
            this.ioPaymentCode.Text = "Payment Code";
            this.ioPaymentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ioPaymentCode.Width = 126;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(231, 401);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(486, 401);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // InternalOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.InternalOperationLV);
            this.Name = "InternalOperation";
            this.Text = "InternalOperation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView InternalOperationLV;
        private System.Windows.Forms.ColumnHeader ioID;
        private System.Windows.Forms.ColumnHeader ioCommission;
        private System.Windows.Forms.ColumnHeader ioVATCollected;
        private System.Windows.Forms.ColumnHeader ioDate;
        private System.Windows.Forms.ColumnHeader ioPaymentCode;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button refreshButton;
    }
}