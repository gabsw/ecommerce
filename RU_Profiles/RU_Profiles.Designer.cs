namespace ecommerce
{
    partial class RU_Profiles
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
            this.listViewRU = new System.Windows.Forms.ListView();
            this.userNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TINCOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewRU
            // 
            this.listViewRU.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userNameCol,
            this.nameCol,
            this.ColEmail,
            this.TINCOL,
            this.addressCol});
            this.listViewRU.FullRowSelect = true;
            this.listViewRU.GridLines = true;
            this.listViewRU.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRU.Location = new System.Drawing.Point(12, 65);
            this.listViewRU.MultiSelect = false;
            this.listViewRU.Name = "listViewRU";
            this.listViewRU.Size = new System.Drawing.Size(876, 175);
            this.listViewRU.TabIndex = 1;
            this.listViewRU.UseCompatibleStateImageBehavior = false;
            this.listViewRU.View = System.Windows.Forms.View.Details;
            // 
            // userNameCol
            // 
            this.userNameCol.Text = "User Name";
            this.userNameCol.Width = 106;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Name";
            this.nameCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameCol.Width = 162;
            // 
            // ColEmail
            // 
            this.ColEmail.Text = "E-mail";
            this.ColEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColEmail.Width = 147;
            // 
            // TINCOL
            // 
            this.TINCOL.Text = "TIN";
            this.TINCOL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TINCOL.Width = 93;
            // 
            // addressCol
            // 
            this.addressCol.Text = "Address";
            this.addressCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addressCol.Width = 350;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 22);
            this.button3.TabIndex = 9;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RU_Profiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 317);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewRU);
            this.Name = "RU_Profiles";
            this.Text = "User Profiles";
            this.Load += new System.EventHandler(this.RU_Profiles_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewRU;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader userNameCol;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader ColEmail;
        private System.Windows.Forms.ColumnHeader TINCOL;
        private System.Windows.Forms.ColumnHeader addressCol;
        private System.Windows.Forms.Button button3;
    }
}