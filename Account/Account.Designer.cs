namespace ecommerce
{
    partial class Account
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
            this.AcclistView = new System.Windows.Forms.ListView();
            this.accID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userAcc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.credButton = new System.Windows.Forms.Button();
            this.debitButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.debButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AcclistView
            // 
            this.AcclistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.accID,
            this.userAcc,
            this.balance});
            this.AcclistView.FullRowSelect = true;
            this.AcclistView.GridLines = true;
            this.AcclistView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AcclistView.Location = new System.Drawing.Point(117, 73);
            this.AcclistView.MultiSelect = false;
            this.AcclistView.Name = "AcclistView";
            this.AcclistView.Size = new System.Drawing.Size(257, 226);
            this.AcclistView.TabIndex = 1;
            this.AcclistView.UseCompatibleStateImageBehavior = false;
            this.AcclistView.View = System.Windows.Forms.View.Details;
            // 
            // accID
            // 
            this.accID.Text = "ID";
            // 
            // userAcc
            // 
            this.userAcc.Text = "User Name";
            this.userAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userAcc.Width = 107;
            // 
            // balance
            // 
            this.balance.Text = "Balance";
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.balance.Width = 74;
            // 
            // credButton
            // 
            this.credButton.Location = new System.Drawing.Point(117, 363);
            this.credButton.Name = "credButton";
            this.credButton.Size = new System.Drawing.Size(103, 26);
            this.credButton.TabIndex = 2;
            this.credButton.Text = "Credit History";
            this.credButton.UseVisualStyleBackColor = true;
            this.credButton.Click += new System.EventHandler(this.credButton_Click);
            // 
            // debitButton
            // 
            this.debitButton.Location = new System.Drawing.Point(117, 317);
            this.debitButton.Name = "debitButton";
            this.debitButton.Size = new System.Drawing.Size(103, 26);
            this.debitButton.TabIndex = 3;
            this.debitButton.Text = "New Debit";
            this.debitButton.UseVisualStyleBackColor = true;
            this.debitButton.Click += new System.EventHandler(this.debitButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(271, 317);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(103, 26);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // debButton
            // 
            this.debButton.Location = new System.Drawing.Point(271, 363);
            this.debButton.Name = "debButton";
            this.debButton.Size = new System.Drawing.Size(103, 26);
            this.debButton.TabIndex = 5;
            this.debButton.Text = "Debit History";
            this.debButton.UseVisualStyleBackColor = true;
            this.debButton.Click += new System.EventHandler(this.debButton_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.debButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.debitButton);
            this.Controls.Add(this.credButton);
            this.Controls.Add(this.AcclistView);
            this.Name = "Account";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView AcclistView;
        private System.Windows.Forms.Button credButton;
        private System.Windows.Forms.Button debitButton;
        private System.Windows.Forms.ColumnHeader accID;
        private System.Windows.Forms.ColumnHeader userAcc;
        private System.Windows.Forms.ColumnHeader balance;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button debButton;
    }
}