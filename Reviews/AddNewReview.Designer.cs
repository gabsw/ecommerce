namespace ecommerce
{
    partial class AddNewReview
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
            this.buyer_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.seller_label = new System.Windows.Forms.Label();
            this.purchase_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buyer_label
            // 
            this.buyer_label.AutoSize = true;
            this.buyer_label.Location = new System.Drawing.Point(169, 58);
            this.buyer_label.Name = "buyer_label";
            this.buyer_label.Size = new System.Drawing.Size(35, 13);
            this.buyer_label.TabIndex = 20;
            this.buyer_label.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "User name Seller:";
            // 
            // seller_label
            // 
            this.seller_label.AutoSize = true;
            this.seller_label.Location = new System.Drawing.Point(169, 89);
            this.seller_label.Name = "seller_label";
            this.seller_label.Size = new System.Drawing.Size(35, 13);
            this.seller_label.TabIndex = 18;
            this.seller_label.Text = "label5";
            // 
            // purchase_label
            // 
            this.purchase_label.AutoSize = true;
            this.purchase_label.Location = new System.Drawing.Point(169, 26);
            this.purchase_label.Name = "purchase_label";
            this.purchase_label.Size = new System.Drawing.Size(35, 13);
            this.purchase_label.TabIndex = 17;
            this.purchase_label.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "User name Buyer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Purchase ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Comment:";
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(142, 151);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(205, 153);
            this.CommentBox.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "(Single digit from 1 to 5)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Rating";
            // 
            // ratingBox
            // 
            this.ratingBox.Location = new System.Drawing.Point(142, 341);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(27, 20);
            this.ratingBox.TabIndex = 45;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(281, 399);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(66, 25);
            this.cancelButton.TabIndex = 50;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(172, 399);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 25);
            this.clearButton.TabIndex = 49;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(56, 399);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(66, 25);
            this.submitButton.TabIndex = 48;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "(500 characters\' limit)";
            // 
            // AddNewReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.buyer_label);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.seller_label);
            this.Controls.Add(this.purchase_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewReview";
            this.Text = "Add New Review";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buyer_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label seller_label;
        private System.Windows.Forms.Label purchase_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label3;
    }
}