﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PovelliProductUpdate
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PovelliAPIHelper apiHelper = new PovelliAPIHelper();

            PovelliProduct[] products = new PovelliProduct[1];
            products[0] = new PovelliProduct();
            products[0].store_id = int.Parse(storeID.Text);
            products[0].code = UPC.Text;
            products[0].name = productTitle.Text;
            products[0].size = "1ct";
            products[0].family = "";
            products[0].manufacturer = "";
            
            try {
                products[0].price = Double.Parse(productPrice.Text);
            }
            catch
            {
                products[0].price = 0.0;
            }

            try
            {
                if (apiHelper.sendProductUpdates(publicKey.Text, privateKey.Text, products).success)
                {
                    apiResponse.Text = "Updated.";
                }
                else
                {
                    apiResponse.Text = "Failed!";
                }
            }catch (Exception exc)
            {
                apiResponse.Text = exc.ToString();
            }
        }
    }
}