namespace ecommerce
{
    partial class Product_Seller
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
            this.ProdSellerLV = new System.Windows.Forms.ListView();
            this.colCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSeller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sellerBox = new System.Windows.Forms.ComboBox();
            this.auctionButton = new System.Windows.Forms.RadioButton();
            this.availableButton = new System.Windows.Forms.RadioButton();
            this.soldButton = new System.Windows.Forms.RadioButton();
            this.refreshButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.allButton = new System.Windows.Forms.RadioButton();
            this.clear_button = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.auctionbttn = new System.Windows.Forms.Button();
            this.colSellerRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProdSellerLV
            // 
            this.ProdSellerLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCode,
            this.colName,
            this.colSeller,
            this.colSellerRating,
            this.colStatus,
            this.colCategory,
            this.colDescription});
            this.ProdSellerLV.FullRowSelect = true;
            this.ProdSellerLV.GridLines = true;
            this.ProdSellerLV.Location = new System.Drawing.Point(68, 12);
            this.ProdSellerLV.MultiSelect = false;
            this.ProdSellerLV.Name = "ProdSellerLV";
            this.ProdSellerLV.Size = new System.Drawing.Size(713, 234);
            this.ProdSellerLV.TabIndex = 0;
            this.ProdSellerLV.UseCompatibleStateImageBehavior = false;
            this.ProdSellerLV.View = System.Windows.Forms.View.Details;
            // 
            // colCode
            // 
            this.colCode.Text = "Code";
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colName.Width = 130;
            // 
            // colSeller
            // 
            this.colSeller.Text = "Seller";
            this.colSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSeller.Width = 106;
            // 
            // colStatus
            // 
            this.colStatus.DisplayIndex = 4;
            this.colStatus.Text = "Status";
            this.colStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colCategory
            // 
            this.colCategory.DisplayIndex = 5;
            this.colCategory.Text = "Category";
            this.colCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCategory.Width = 90;
            // 
            // colDescription
            // 
            this.colDescription.DisplayIndex = 6;
            this.colDescription.Text = "Description";
            this.colDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDescription.Width = 179;
            // 
            // sellerBox
            // 
            this.sellerBox.FormattingEnabled = true;
            this.sellerBox.Location = new System.Drawing.Point(799, 280);
            this.sellerBox.Name = "sellerBox";
            this.sellerBox.Size = new System.Drawing.Size(186, 21);
            this.sellerBox.TabIndex = 1;
            this.sellerBox.SelectedIndexChanged += new System.EventHandler(this.sellerBox_SelectedIndexChanged);
            // 
            // auctionButton
            // 
            this.auctionButton.AutoSize = true;
            this.auctionButton.Location = new System.Drawing.Point(860, 127);
            this.auctionButton.Name = "auctionButton";
            this.auctionButton.Size = new System.Drawing.Size(61, 17);
            this.auctionButton.TabIndex = 2;
            this.auctionButton.TabStop = true;
            this.auctionButton.Text = "Auction";
            this.auctionButton.UseVisualStyleBackColor = true;
            this.auctionButton.CheckedChanged += new System.EventHandler(this.auctionButton_CheckedChanged);
            // 
            // availableButton
            // 
            this.availableButton.AutoSize = true;
            this.availableButton.Location = new System.Drawing.Point(860, 160);
            this.availableButton.Name = "availableButton";
            this.availableButton.Size = new System.Drawing.Size(68, 17);
            this.availableButton.TabIndex = 3;
            this.availableButton.TabStop = true;
            this.availableButton.Text = "Available";
            this.availableButton.UseVisualStyleBackColor = true;
            this.availableButton.CheckedChanged += new System.EventHandler(this.availableButton_CheckedChanged);
            // 
            // soldButton
            // 
            this.soldButton.AutoSize = true;
            this.soldButton.Location = new System.Drawing.Point(860, 196);
            this.soldButton.Name = "soldButton";
            this.soldButton.Size = new System.Drawing.Size(46, 17);
            this.soldButton.TabIndex = 4;
            this.soldButton.TabStop = true;
            this.soldButton.Text = "Sold";
            this.soldButton.UseVisualStyleBackColor = true;
            this.soldButton.CheckedChanged += new System.EventHandler(this.soldButton_CheckedChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(693, 278);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(88, 22);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(574, 278);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 22);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(450, 278);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(88, 22);
            this.addNewButton.TabIndex = 10;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(68, 278);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(88, 22);
            this.sellButton.TabIndex = 13;
            this.sellButton.Text = "Start Auction";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select Seller\'s username:";
            // 
            // allButton
            // 
            this.allButton.AutoSize = true;
            this.allButton.Location = new System.Drawing.Point(860, 95);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(81, 17);
            this.allButton.TabIndex = 16;
            this.allButton.TabStop = true;
            this.allButton.Text = "All Products";
            this.allButton.UseVisualStyleBackColor = true;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(840, 346);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(88, 22);
            this.clear_button.TabIndex = 72;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(92, 347);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 22);
            this.searchButton.TabIndex = 71;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(212, 347);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(346, 20);
            this.searchBox.TabIndex = 70;
            // 
            // auctionbttn
            // 
            this.auctionbttn.Location = new System.Drawing.Point(189, 278);
            this.auctionbttn.Name = "auctionbttn";
            this.auctionbttn.Size = new System.Drawing.Size(88, 22);
            this.auctionbttn.TabIndex = 73;
            this.auctionbttn.Text = "Go to Auction";
            this.auctionbttn.UseVisualStyleBackColor = true;
            this.auctionbttn.Click += new System.EventHandler(this.auctionbttn_Click);
            // 
            // colSellerRating
            // 
            this.colSellerRating.DisplayIndex = 3;
            this.colSellerRating.Text = "Seller Rating";
            this.colSellerRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSellerRating.Width = 82;
            // 
            // descriptionBttn
            // 
            this.descriptionBttn.Location = new System.Drawing.Point(316, 278);
            this.descriptionBttn.Name = "descriptionBttn";
            this.descriptionBttn.Size = new System.Drawing.Size(98, 22);
            this.descriptionBttn.TabIndex = 74;
            this.descriptionBttn.Text = "Read Description";
            this.descriptionBttn.UseVisualStyleBackColor = true;
            this.descriptionBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Product_Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 388);
            this.Controls.Add(this.descriptionBttn);
            this.Controls.Add(this.auctionbttn);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.soldButton);
            this.Controls.Add(this.availableButton);
            this.Controls.Add(this.auctionButton);
            this.Controls.Add(this.sellerBox);
            this.Controls.Add(this.ProdSellerLV);
            this.Name = "Product_Seller";
            this.Text = "Products - Seller";
            this.Load += new System.EventHandler(this.Product_Seller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProdSellerLV;
        private System.Windows.Forms.ComboBox sellerBox;
        private System.Windows.Forms.RadioButton auctionButton;
        private System.Windows.Forms.RadioButton availableButton;
        private System.Windows.Forms.RadioButton soldButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.RadioButton allButton;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ColumnHeader colSeller;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Button auctionbttn;
        private System.Windows.Forms.ColumnHeader colSellerRating;
        private System.Windows.Forms.Button descriptionBttn;
    }
}