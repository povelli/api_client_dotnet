using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Povelli;

namespace PovelliProductUpdate
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }


        private void logMessage(string msg)
        {
            apiResponse.Text = msg;
        }

        private PovelliAPI getPovelliApi()
        {
            PovelliAPI api = new PovelliAPI(publicKey.Text, privateKey.Text);
            return api;
        }

        private PovelliProductFilter [] getProductFilter()
        {
            PovelliProductFilter[] products = new PovelliProductFilter[1];
            products[0] = new PovelliProductFilter(storeUID.Text, UPCFilter.Text, sizeFilter.Text);
            return products;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (UPC.Text == "")
            {
                apiResponse.Text = "No UPC!";
                return;
            }

            logMessage("Sending Product Update API...");

            PovelliProduct[] products = new PovelliProduct[1];
            products[0] = new PovelliProduct(storeUID.Text, UPC.Text, size.Text);
            products[0].name = productTitle.Text;
            products[0].family = ""; // Category or Department
            products[0].manufacturer = "";
            try
            {
                products[0].price = Double.Parse(productPrice.Text);
            }
            catch
            {
                products[0].price = 0.0;
            }

            try
            {
                PovelliResponse res = getPovelliApi().updateProducts(products);

                if (res.success)
                {
                    logMessage("Product Added or Updated.");
                }
                else
                {
                    logMessage(res.ToString());
                }
            }
            catch (Exception exc)
            {
                logMessage(exc.ToString());
            }
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            logMessage("Sending Product Status API...");
            try
            {
                PovelliResponse res = null;
                PovelliProductFilter[] productFilters = getProductFilter();
                res = getPovelliApi().getProducts(productFilters);
                if (res.success)
                {
                    if (res.products.Length > 0) {
                        logMessage(res.products.Length + " Product found with " + res.products[0].labels.Length + " labels.");
                    }
                    else
                    {
                        logMessage("No product found with UPC: " + productFilters[0].upc + " and Size: " + productFilters[0].size);
                    }
                }
                else
                {
                    logMessage(res.ToString());
                }
            }catch(Exception exc)
            {
                logMessage(exc.ToString());
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            logMessage("Sending Product Delete API...");
            try
            {
                PovelliResponse res = null;
                PovelliProductFilter[] productFilters = getProductFilter();
                res = getPovelliApi().deleteProducts(productFilters);
                if (res.success && res.processed_items == 1)
                {
                    logMessage("Product deleted.");
                }
                else
                {
                    logMessage(res.ToString());
                }
            }
            catch (Exception exc)
            {
                logMessage(exc.ToString());
            }
        }

        private void assignPanelBtn_Click(object sender, EventArgs e)
        {
            labelAssign.Visible = false;
            labelCheck.Visible = true;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            while (templates.Items.Count > 0) templates.Items.RemoveAt(0);

            if (labelBarcode.Text == "")
            {
                logMessage("No Label Barcode Specified!");
                return;
            }

            try
            {
                PovelliTemplate[] templateRes = getPovelliApi().getLabelTemplates(storeUID.Text, labelBarcode.Text);

                for (int i = 0; i < templateRes.Length; i++)
                {
                    templates.Items.Add(templateRes[i]);
                }
            }
            catch (Exception exc)
            {
                logMessage(exc.ToString());
            }

            labelAssign.Visible = true;
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            if (labelBarcode.Text == "" || templates.SelectedIndex < 0)
            {
                logMessage("Both Label Barcode and a Template needs to be specified!");
                return;
            }

            PovelliLabelAssignment[] labelAssignments = new PovelliLabelAssignment[1];
            labelAssignments[0] = new PovelliLabelAssignment(storeUID.Text, labelBarcode.Text, 
                UPCFilter.Text, sizeFilter.Text, ((PovelliTemplate) templates.SelectedItem).uid);

            try
            {
                PovelliResponse res = getPovelliApi().assignLabels(labelAssignments);
                if (res.success)
                {
                    labelCheck.Visible = false;
                    labelAssign.Visible = false;
                    logMessage("Label assigned.");
                }
                else
                {
                    logMessage(res.ToString());
                }
            }catch(Exception exc)
            {
                logMessage(exc.ToString());
            }
        }

        private void unassignBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
