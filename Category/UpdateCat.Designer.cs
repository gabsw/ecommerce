namespace ecommerce
{
    partial class UpdateCat
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.VATBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(304, 157);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(66, 25);
            this.cancelButton.TabIndex = 55;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(195, 157);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 25);
            this.clearButton.TabIndex = 54;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(79, 157);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(66, 25);
            this.submitButton.TabIndex = 53;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "VAT (%)";
            // 
            // VATBox
            // 
            this.VATBox.Location = new System.Drawing.Point(165, 101);
            this.VATBox.Name = "VATBox";
            this.VATBox.Size = new System.Drawing.Size(205, 20);
            this.VATBox.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Fill all the information below:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(162, 67);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 56;
            this.name_label.Text = "label1";
            // 
            // UpdateCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 218);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VATBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UpdateCat";
            this.Text = "Update Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VATBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name_label;
    }
}