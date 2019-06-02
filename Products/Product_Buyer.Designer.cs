namespace ecommerce
{
    partial class Product_Buyer
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
            this.ProdBuyerLV = new System.Windows.Forms.ListView();
            this.colCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSeller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sellerRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buyerBox = new System.Windows.Forms.ComboBox();
            this.auctionButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.allCategories = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.descriptionBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProdBuyerLV
            // 
            this.ProdBuyerLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCode,
            this.colName,
            this.colCategory,
            this.colDescription,
            this.colSeller,
            this.sellerRating});
            this.ProdBuyerLV.FullRowSelect = true;
            this.ProdBuyerLV.GridLines = true;
            this.ProdBuyerLV.Location = new System.Drawing.Point(30, 36);
            this.ProdBuyerLV.MultiSelect = false;
            this.ProdBuyerLV.Name = "ProdBuyerLV";
            this.ProdBuyerLV.Size = new System.Drawing.Size(722, 234);
            this.ProdBuyerLV.TabIndex = 1;
            this.ProdBuyerLV.UseCompatibleStateImageBehavior = false;
            this.ProdBuyerLV.View = System.Windows.Forms.View.Details;
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
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCategory.Width = 90;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDescription.Width = 219;
            // 
            // colSeller
            // 
            this.colSeller.Text = "Seller";
            this.colSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSeller.Width = 126;
            // 
            // sellerRating
            // 
            this.sellerRating.Text = "Seller Rating";
            this.sellerRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sellerRating.Width = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(807, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Buyer\'s username:";
            // 
            // buyerBox
            // 
            this.buyerBox.FormattingEnabled = true;
            this.buyerBox.Location = new System.Drawing.Point(774, 85);
            this.buyerBox.Name = "buyerBox";
            this.buyerBox.Size = new System.Drawing.Size(186, 21);
            this.buyerBox.TabIndex = 15;
            this.buyerBox.SelectedIndexChanged += new System.EventHandler(this.buyerBox_SelectedIndexChanged);
            // 
            // auctionButton
            // 
            this.auctionButton.Location = new System.Drawing.Point(827, 234);
            this.auctionButton.Name = "auctionButton";
            this.auctionButton.Size = new System.Drawing.Size(98, 22);
            this.auctionButton.TabIndex = 17;
            this.auctionButton.Text = "Go to Auction";
            this.auctionButton.UseVisualStyleBackColor = true;
            this.auctionButton.Click += new System.EventHandler(this.auctionButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(190, 306);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(339, 20);
            this.searchBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(839, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Category:";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(774, 145);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(185, 21);
            this.categoryBox.TabIndex = 65;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // allCategories
            // 
            this.allCategories.AutoSize = true;
            this.allCategories.Location = new System.Drawing.Point(810, 194);
            this.allCategories.Name = "allCategories";
            this.allCategories.Size = new System.Drawing.Size(118, 17);
            this.allCategories.TabIndex = 67;
            this.allCategories.Text = "Show all categories";
            this.allCategories.UseVisualStyleBackColor = true;
            this.allCategories.CheckedChanged += new System.EventHandler(this.allCategories_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(30, 306);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 22);
            this.searchButton.TabIndex = 68;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(827, 328);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(98, 22);
            this.clear_button.TabIndex = 69;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // descriptionBttn
            // 
            this.descriptionBttn.Location = new System.Drawing.Point(827, 284);
            this.descriptionBttn.Name = "descriptionBttn";
            this.descriptionBttn.Size = new System.Drawing.Size(98, 22);
            this.descriptionBttn.TabIndex = 75;
            this.descriptionBttn.Text = "Read Description";
            this.descriptionBttn.UseVisualStyleBackColor = true;
            this.descriptionBttn.Click += new System.EventHandler(this.descriptionBttn_Click);
            // 
            // Product_Buyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 362);
            this.Controls.Add(this.descriptionBttn);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.allCategories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.auctionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyerBox);
            this.Controls.Add(this.ProdBuyerLV);
            this.Name = "Product_Buyer";
            this.Text = "Products - Buyer";
            this.Load += new System.EventHandler(this.Product_Buyer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProdBuyerLV;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox buyerBox;
        private System.Windows.Forms.Button auctionButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.CheckBox allCategories;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ColumnHeader colSeller;
        private System.Windows.Forms.ColumnHeader sellerRating;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button descriptionBttn;
    }
}