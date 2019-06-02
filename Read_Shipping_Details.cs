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
    public partial class Read_Shipping_Details : Form
    {
        private int shippingCode;

        public Read_Shipping_Details(int shippingCode)
        {
            InitializeComponent();
            this.shippingCode = shippingCode;
        }
    }
}
