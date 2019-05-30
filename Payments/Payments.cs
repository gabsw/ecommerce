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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void TabProcessed_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       /* private void PayButton_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            PayPayment f = new PayPayment();

            f.MdiParent = this;
            f.Show();
        }*/
    }
}
