namespace ecommerce
{
    partial class Admin_Profiles
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
            this.AdminListView = new System.Windows.Forms.ListView();
            this.admin_username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.admin_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.admin_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminListView
            // 
            this.AdminListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.admin_username,
            this.admin_name,
            this.admin_email});
            this.AdminListView.FullRowSelect = true;
            this.AdminListView.GridLines = true;
            this.AdminListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AdminListView.Location = new System.Drawing.Point(53, 80);
            this.AdminListView.MultiSelect = false;
            this.AdminListView.Name = "AdminListView";
            this.AdminListView.Size = new System.Drawing.Size(509, 215);
            this.AdminListView.TabIndex = 1;
            this.AdminListView.UseCompatibleStateImageBehavior = false;
            this.AdminListView.View = System.Windows.Forms.View.Details;
            // 
            // admin_username
            // 
            this.admin_username.Text = "User Name";
            this.admin_username.Width = 106;
            // 
            // admin_name
            // 
            this.admin_name.Text = "Name";
            this.admin_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.admin_name.Width = 151;
            // 
            // admin_email
            // 
            this.admin_email.Text = "E-mail";
            this.admin_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.admin_email.Width = 242;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(140, 321);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 25);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add New";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(262, 321);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(72, 25);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(392, 321);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(72, 25);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Admin_Profiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.AdminListView);
            this.Name = "Admin_Profiles";
            this.Text = "Admin_Profiles";
            this.Load += new System.EventHandler(this.Admin_Profiles_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView AdminListView;
        private System.Windows.Forms.ColumnHeader admin_username;
        private System.Windows.Forms.ColumnHeader admin_name;
        private System.Windows.Forms.ColumnHeader admin_email;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button refreshButton;
    }
}