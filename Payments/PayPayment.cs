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
    public partial class PayPayment : Form
    {
        public PayPayment()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
         /*   if (this.validatePayment()){
                this.submitPayment();
                this.Close();
            } */
        }
    }
}
