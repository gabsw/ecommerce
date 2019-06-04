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
            this.ioPaymentCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ioDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalVAT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.commission_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InternalOperationLV
            // 
            this.InternalOperationLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ioID,
            this.ioCommission,
            this.ioVATCollected,
            this.ioPaymentCode,
            this.ioDate});
            this.InternalOperationLV.FullRowSelect = true;
            this.InternalOperationLV.GridLines = true;
            this.InternalOperationLV.Location = new System.Drawing.Point(21, 54);
            this.InternalOperationLV.MultiSelect = false;
            this.InternalOperationLV.Name = "InternalOperationLV";
            this.InternalOperationLV.Size = new System.Drawing.Size(628, 234);
            this.InternalOperationLV.TabIndex = 2;
            this.InternalOperationLV.UseCompatibleStateImageBehavior = false;
            this.InternalOperationLV.View = System.Windows.Forms.View.Details;
            // 
            // ioID
            // 
            this.ioID.Text = "operation ID";
            this.ioID.Width = 78;
            // 
            // ioCommission
            // 
            this.ioCommission.Text = "Commission (€)";
            this.ioCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ioCommission.Width = 99;
            // 
            // ioVATCollected
            // 
            this.ioVATCollected.Text = "Collected VAT ( € )";
            this.ioVATCollected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ioVATCollected.Width = 115;
            // 
            // ioPaymentCode
            // 
            this.ioPaymentCode.Text = "Payment Code";
            this.ioPaymentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ioPaymentCode.Width = 126;
            // 
            // ioDate
            // 
            this.ioDate.Text = "Date";
            this.ioDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ioDate.Width = 201;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(486, 350);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(94, 38);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(36, 344);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(94, 44);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 362);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Collected VAT (€):";
            // 
            // labelTotalVAT
            // 
            this.labelTotalVAT.AutoSize = true;
            this.labelTotalVAT.Location = new System.Drawing.Point(394, 362);
            this.labelTotalVAT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalVAT.Name = "labelTotalVAT";
            this.labelTotalVAT.Size = new System.Drawing.Size(27, 13);
            this.labelTotalVAT.TabIndex = 6;
            this.labelTotalVAT.Text = "total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 344);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Earned Commission (€):";
            // 
            // commission_lbl
            // 
            this.commission_lbl.AutoSize = true;
            this.commission_lbl.Location = new System.Drawing.Point(394, 344);
            this.commission_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.commission_lbl.Name = "commission_lbl";
            this.commission_lbl.Size = new System.Drawing.Size(27, 13);
            this.commission_lbl.TabIndex = 8;
            this.commission_lbl.Text = "total";
            // 
            // InternalOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 426);
            this.Controls.Add(this.commission_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotalVAT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.InternalOperationLV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InternalOperation";
            this.Text = "Internal Operations";
            this.Load += new System.EventHandler(this.InternalOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalVAT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label commission_lbl;
    }
}