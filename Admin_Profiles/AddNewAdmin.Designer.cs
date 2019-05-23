namespace ecommerce
{
    partial class AddNewAdmin
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
            this.label7 = new System.Windows.Forms.Label();
            this.confPWBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Confirm Password";
            // 
            // confPWBox
            // 
            this.confPWBox.Location = new System.Drawing.Point(154, 211);
            this.confPWBox.Name = "confPWBox";
            this.confPWBox.PasswordChar = '*';
            this.confPWBox.Size = new System.Drawing.Size(205, 20);
            this.confPWBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(154, 174);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(205, 20);
            this.passwordBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(154, 134);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(205, 20);
            this.emailBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Full Name";
            // 
            // fullNameBox
            // 
            this.fullNameBox.Location = new System.Drawing.Point(154, 96);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(205, 20);
            this.fullNameBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fill all the information below:";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(154, 59);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(205, 20);
            this.userNameBox.TabIndex = 12;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(292, 271);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(66, 25);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(183, 271);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 25);
            this.clearButton.TabIndex = 32;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(67, 271);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(66, 25);
            this.submitButton.TabIndex = 31;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AddNewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 351);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.confPWBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameBox);
            this.Name = "AddNewAdmin";
            this.Text = "Add New Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox confPWBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
    }
}