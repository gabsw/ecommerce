using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class ReadReview : Form
    {
        private String buyer;
        private String seller;
        private String purchaseID;
        private String productCode;
        private String rating;
        private String comment;
        private String date;
        private String reviewID;

        public ReadReview(String reviewID, String purchaseID, String buyer, String seller,
                    String productCode, String rating, String comment, String date)
        {
            InitializeComponent();
            this.buyer = buyer;
            this.purchaseID = purchaseID;
            this.seller = seller;
            this.productCode = productCode;
            this.rating = rating;
            this.comment = comment;
            this.date = date;
            this.reviewID = reviewID;
            }
        private void ReadReview_Load(object sender, EventArgs e)
        {
            commentBox.Text = comment;
            reviewID_lbl.Text = reviewID;
            purchaseID_lbl.Text = purchaseID;
            productCode_lbl.Text = productCode;
            buyer_lbl.Text = buyer;
            seller_lbl.Text = seller;
            rating_lbl.Text = rating;
            date_lbl.Text = date;
        }
    }
    
}
