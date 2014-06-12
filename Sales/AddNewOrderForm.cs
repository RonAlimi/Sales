using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales
{
    public partial class AddNewOrderForm : Form
    {
        //consume invetory web service:
        private InventoryService.Grupi_Algent_ServiceSoapClient proxy = new InventoryService.Grupi_Algent_ServiceSoapClient();
        public WS_Sales.WS_SalesSoapClient c1 = new WS_Sales.WS_SalesSoapClient();
        private Costumers c = new Costumers();
        private Orders o = new Orders();

        private string[] GETCUSTOMER = new string[2];
        private string PRODNAME;
        private int ID;

        public AddNewOrderForm()
        {
            InitializeComponent();

            
        }

        private void AddNewOrderForm_Load(object sender, EventArgs e)
        {
            //combo: Category
            cbCategory.DataSource = c1.GetCustomersList();
            cbCategory.DataSource = c1.GetCat();
            cbCategory.DisplayMember = "catName";
            int id = Convert.ToInt32(c1.GetCategoryID(cbCategory.SelectedItem.ToString()));
            //combo: Customer
            cbCustomer.DataSource = c1.GetCustomersList();

            //combo: Product
            //cbProducts.DataSource = proxy.GetProductsByCatId(id);
            cbProducts.DataSource = c1.GetProducts(id);
            cbProducts.DisplayMember = "name";
            PRODNAME = cbProducts.SelectedItem.ToString();
            //textbox ORDER#
            
            txtStatus.Text = "Open";

            lblX.Visible = true;

            var customers = cbCustomer.SelectedItem.ToString().Split(',');
            GETCUSTOMER[0] = customers[0].ToString();
            GETCUSTOMER[1] = customers[1].ToString();          

            int cId = Convert.ToInt32(c1.GetCustomerIdByFullName(GETCUSTOMER[1].ToString(),GETCUSTOMER[0].ToString()));
            
            txtOrderNum.Text = c1.CreateNewBill(cId, 1).ToString();
            ID = Convert.ToInt32(txtOrderNum.Text);
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            var price = statusLbl.Text.Split(':');
            lblPrice.Text = c1.GetProductPrice("kos");
            PRODNAME = cbProducts.SelectedItem.ToString();
             * */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtQty.Text != null)
            {
                txtTotal.Text = "";

                try
                {
                    statusLbl.Text = c1.AddNewOrder(ID, PRODNAME, Convert.ToInt32(txtQty.Text), "default");
                    //double total = Convert.ToDouble(lblPrice.Text) * Convert.ToInt32(lblQty.Text);
                    //txtTotal.Text = total.ToString();

                    statusLbl.Text = "Order completed!";

                    txtQty.Text = null;
                    lblPrice.Text = "";
                    lblQty.Text = "";

                }
                catch (FormatException)
                {
                    MessageBox.Show("make sure you provide all the required info");
                }
            }
            else
                MessageBox.Show("Quantity is a required field!");
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(c1.GetCategoryID(cbCategory.SelectedItem.ToString()));
                cbProducts.DataSource = c1.GetProducts(id);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
         
            statusLbl.Text = "Category: " + cbCategory.SelectedItem.ToString();
        }

        private string ShowPrice()
        {
            return String.Format("{0:C} ",c1.GetProductPrice(cbProducts.SelectedItem.ToString()));
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            lblQty.Text = txtQty.Text;
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customers = cbCustomer.SelectedItem.ToString().Split(',');
            GETCUSTOMER[0] = customers[0].ToString();
            GETCUSTOMER[1] = customers[1].ToString();
        }

        
        
    }
}
