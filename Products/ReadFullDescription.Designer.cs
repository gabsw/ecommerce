namespace ecommerce
{
    partial class ReadFullDescription
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
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.productCode_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productName_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(22, 98);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(362, 247);
            this.descriptionBox.TabIndex = 15;
            // 
            // productCode_lbl
            // 
            this.productCode_lbl.AutoSize = true;
            this.productCode_lbl.Location = new System.Drawing.Point(117, 19);
            this.productCode_lbl.Name = "productCode_lbl";
            this.productCode_lbl.Size = new System.Drawing.Size(35, 13);
            this.productCode_lbl.TabIndex = 14;
            this.productCode_lbl.Text = "label6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Product Code:";
            // 
            // productName_lbl
            // 
            this.productName_lbl.AutoSize = true;
            this.productName_lbl.Location = new System.Drawing.Point(117, 47);
            this.productName_lbl.Name = "productName_lbl";
            this.productName_lbl.Size = new System.Drawing.Size(35, 13);
            this.productName_lbl.TabIndex = 17;
            this.productName_lbl.Text = "label6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product Name:";
            // 
            // ReadFullDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.productName_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.productCode_lbl);
            this.Controls.Add(this.label3);
            this.Name = "ReadFullDescription";
            this.Text = "Full Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label productCode_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label productName_lbl;
        private System.Windows.Forms.Label label2;
    }
}