namespace ecommerce
{
    partial class NewDebit
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
            this.label1 = new System.Windows.Forms.Label();
            this.debitBox = new System.Windows.Forms.TextBox();
            this.currentBalancelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ibanBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.accIDlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Balance:";
            // 
            // debitBox
            // 
            this.debitBox.Location = new System.Drawing.Point(119, 82);
            this.debitBox.Name = "debitBox";
            this.debitBox.Size = new System.Drawing.Size(60, 20);
            this.debitBox.TabIndex = 1;
            // 
            // currentBalancelbl
            // 
            this.currentBalancelbl.AutoSize = true;
            this.currentBalancelbl.Location = new System.Drawing.Point(134, 43);
            this.currentBalancelbl.Name = "currentBalancelbl";
            this.currentBalancelbl.Size = new System.Drawing.Size(45, 13);
            this.currentBalancelbl.TabIndex = 2;
            this.currentBalancelbl.Text = "balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Debit Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IBAN:";
            // 
            // ibanBox
            // 
            this.ibanBox.Location = new System.Drawing.Point(119, 126);
            this.ibanBox.Name = "ibanBox";
            this.ibanBox.Size = new System.Drawing.Size(185, 20);
            this.ibanBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "€";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(33, 182);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(74, 24);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(133, 182);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(74, 24);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(230, 182);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 24);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // accIDlabel
            // 
            this.accIDlabel.AutoSize = true;
            this.accIDlabel.Location = new System.Drawing.Point(160, 9);
            this.accIDlabel.Name = "accIDlabel";
            this.accIDlabel.Size = new System.Drawing.Size(0, 13);
            this.accIDlabel.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Account ID:";
            // 
            // NewDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 246);
            this.Controls.Add(this.accIDlabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ibanBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentBalancelbl);
            this.Controls.Add(this.debitBox);
            this.Controls.Add(this.label1);
            this.Name = "NewDebit";
            this.Text = "New Debit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox debitBox;
        private System.Windows.Forms.Label currentBalancelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ibanBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label accIDlabel;
        private System.Windows.Forms.Label label7;
    }
}