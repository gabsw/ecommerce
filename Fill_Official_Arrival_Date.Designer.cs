namespace ecommerce
{
    partial class Fill_Official_Arrival_Date
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
            this.label2 = new System.Windows.Forms.Label();
            this.arrival_date_dtp = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.shippingCode_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Buyer must enter all the date below after receiving its order:";
            // 
            // arrival_date_dtp
            // 
            this.arrival_date_dtp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.arrival_date_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrival_date_dtp.Location = new System.Drawing.Point(173, 128);
            this.arrival_date_dtp.Name = "arrival_date_dtp";
            this.arrival_date_dtp.Size = new System.Drawing.Size(142, 20);
            this.arrival_date_dtp.TabIndex = 150;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 13);
            this.label16.TabIndex = 149;
            this.label16.Text = "Official Arrival Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 151;
            this.label1.Text = "Shipping Code:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(216, 183);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 25);
            this.clearButton.TabIndex = 153;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(100, 183);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(66, 25);
            this.submitButton.TabIndex = 152;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // shippingCode_lbl
            // 
            this.shippingCode_lbl.AutoSize = true;
            this.shippingCode_lbl.Location = new System.Drawing.Point(170, 71);
            this.shippingCode_lbl.Name = "shippingCode_lbl";
            this.shippingCode_lbl.Size = new System.Drawing.Size(35, 13);
            this.shippingCode_lbl.TabIndex = 154;
            this.shippingCode_lbl.Text = "label3";
            // 
            // Fill_Official_Arrival_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 234);
            this.Controls.Add(this.shippingCode_lbl);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrival_date_dtp);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Name = "Fill_Official_Arrival_Date";
            this.Text = "Fill Official Arrival Date";
            this.Load += new System.EventHandler(this.Fill_Official_Arrival_Date_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker arrival_date_dtp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label shippingCode_lbl;
    }
}