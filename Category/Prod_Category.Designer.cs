namespace ecommerce
{
    partial class Prod_Category
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
            this.Cat_ListView = new System.Windows.Forms.ListView();
            this.catCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.catName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.catVAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddNewButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cat_ListView
            // 
            this.Cat_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.catCode,
            this.catName,
            this.catVAT});
            this.Cat_ListView.FullRowSelect = true;
            this.Cat_ListView.GridLines = true;
            this.Cat_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Cat_ListView.Location = new System.Drawing.Point(123, 41);
            this.Cat_ListView.MultiSelect = false;
            this.Cat_ListView.Name = "Cat_ListView";
            this.Cat_ListView.Size = new System.Drawing.Size(267, 262);
            this.Cat_ListView.TabIndex = 0;
            this.Cat_ListView.UseCompatibleStateImageBehavior = false;
            this.Cat_ListView.View = System.Windows.Forms.View.Details;
            // 
            // catCode
            // 
            this.catCode.Text = "Code";
            // 
            // catName
            // 
            this.catName.Text = "Name";
            this.catName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.catName.Width = 123;
            // 
            // catVAT
            // 
            this.catVAT.Text = "VAT (%)";
            this.catVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.catVAT.Width = 73;
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(145, 349);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(67, 20);
            this.AddNewButton.TabIndex = 1;
            this.AddNewButton.Text = "Add New";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(323, 349);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(67, 20);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(236, 349);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(68, 20);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Prod_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 440);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.Cat_ListView);
            this.Name = "Prod_Category";
            this.Text = "Product Categories";
            this.Load += new System.EventHandler(this.Prod_Category_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Cat_ListView;
        private System.Windows.Forms.ColumnHeader catCode;
        private System.Windows.Forms.ColumnHeader catName;
        private System.Windows.Forms.ColumnHeader catVAT;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button updateButton;
    }
}