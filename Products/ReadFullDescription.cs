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
    public partial class ReadFullDescription : Form
    {
        public ReadFullDescription(String code, String name, String description)
        {
            InitializeComponent();
            productCode_lbl.Text = code;
            productName_lbl.Text = name;
            descriptionBox.Text = description;
        }
    }
}
