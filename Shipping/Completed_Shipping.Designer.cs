namespace ecommerce
{
    partial class Completed_Shipping
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sellerBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.purchaseBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buyerBox = new System.Windows.Forms.ComboBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.shipCompLV = new System.Windows.Forms.ListView();
            this.purchase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buyer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deliveryComp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.deliveryBox = new System.Windows.Forms.ComboBox();
            this.shipping = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officialdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(819, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 121;
            this.label4.Text = "Search Filters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(766, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 120;
            this.label3.Text = "Seller\'s username:";
            // 
            // sellerBox
            // 
            this.sellerBox.FormattingEnabled = true;
            this.sellerBox.Location = new System.Drawing.Point(768, 64);
            this.sellerBox.Name = "sellerBox";
            this.sellerBox.Size = new System.Drawing.Size(186, 21);
            this.sellerBox.TabIndex = 119;
            this.sellerBox.SelectedIndexChanged += new System.EventHandler(this.sellerBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Purchases:";
            // 
            // purchaseBox
            // 
            this.purchaseBox.FormattingEnabled = true;
            this.purchaseBox.Location = new System.Drawing.Point(769, 189);
            this.purchaseBox.Name = "purchaseBox";
            this.purchaseBox.Size = new System.Drawing.Size(186, 21);
            this.purchaseBox.TabIndex = 117;
            this.purchaseBox.SelectedIndexChanged += new System.EventHandler(this.purchaseBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(765, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Buyer\'s username:";
            // 
            // buyerBox
            // 
            this.buyerBox.FormattingEnabled = true;
            this.buyerBox.Location = new System.Drawing.Point(768, 123);
            this.buyerBox.Name = "buyerBox";
            this.buyerBox.Size = new System.Drawing.Size(186, 21);
            this.buyerBox.TabIndex = 115;
            this.buyerBox.SelectedIndexChanged += new System.EventHandler(this.buyerBox_SelectedIndexChanged);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(346, 274);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(88, 22);
            this.clear_button.TabIndex = 114;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(513, 274);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(72, 25);
            this.refreshButton.TabIndex = 113;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(115, 271);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(158, 25);
            this.readButton.TabIndex = 112;
            this.readButton.Text = "Read Full Shipping Details";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // shipCompLV
            // 
            this.shipCompLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.shipping,
            this.purchase,
            this.buyer,
            this.seller,
            this.deliveryComp,
            this.officialdate});
            this.shipCompLV.FullRowSelect = true;
            this.shipCompLV.GridLines = true;
            this.shipCompLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.shipCompLV.Location = new System.Drawing.Point(23, 29);
            this.shipCompLV.MultiSelect = false;
            this.shipCompLV.Name = "shipCompLV";
            this.shipCompLV.Size = new System.Drawing.Size(688, 204);
            this.shipCompLV.TabIndex = 111;
            this.shipCompLV.UseCompatibleStateImageBehavior = false;
            this.shipCompLV.View = System.Windows.Forms.View.Details;
            // 
            // purchase
            // 
            this.purchase.Text = "Purchase ID";
            this.purchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.purchase.Width = 72;
            // 
            // buyer
            // 
            this.buyer.Text = "Buyer";
            this.buyer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buyer.Width = 107;
            // 
            // seller
            // 
            this.seller.Text = "Seller";
            this.seller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seller.Width = 117;
            // 
            // deliveryComp
            // 
            this.deliveryComp.Text = "Delivery Company";
            this.deliveryComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deliveryComp.Width = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(766, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 123;
            this.label5.Text = "Delivery Companies:";
            // 
            // deliveryBox
            // 
            this.deliveryBox.FormattingEnabled = true;
            this.deliveryBox.Location = new System.Drawing.Point(769, 256);
            this.deliveryBox.Name = "deliveryBox";
            this.deliveryBox.Size = new System.Drawing.Size(186, 21);
            this.deliveryBox.TabIndex = 122;
            this.deliveryBox.SelectedIndexChanged += new System.EventHandler(this.deliveryBox_SelectedIndexChanged);
            // 
            // shipping
            // 
            this.shipping.Text = "Shipping Code";
            this.shipping.Width = 89;
            // 
            // officialdate
            // 
            this.officialdate.Text = "Official Arrival Date";
            this.officialdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.officialdate.Width = 189;
            // 
            // Completed_Shipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 341);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deliveryBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sellerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.purchaseBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyerBox);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.shipCompLV);
            this.Name = "Completed_Shipping";
            this.Text = "Completed Shipping";
            this.Load += new System.EventHandler(this.Completed_Shipping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sellerBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox purchaseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox buyerBox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.ListView shipCompLV;
        private System.Windows.Forms.ColumnHeader shipping;
        private System.Windows.Forms.ColumnHeader purchase;
        private System.Windows.Forms.ColumnHeader buyer;
        private System.Windows.Forms.ColumnHeader seller;
        private System.Windows.Forms.ColumnHeader deliveryComp;
        private System.Windows.Forms.ColumnHeader officialdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox deliveryBox;
    }
}