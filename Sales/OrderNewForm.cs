using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace Sales
{
    public partial class OrderNewForm : Form
    {
        WS_Sales.WS_SalesSoapClient obj = new WS_Sales.WS_SalesSoapClient();


        private string[] GETCUSTOMER = new string[2];
        private string PRODNAME;
        private int ID;


        public OrderNewForm()
        {
            InitializeComponent();
        }

        private void OrderNewForm_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = obj.GetCat();
            cbCustomer.DataSource = obj.GetCustomersList();
            cbCustomer.DisplayMember = "name";
            int id = Convert.ToInt32(obj.GetCategoryID(cbCategory.SelectedItem.ToString()));
            cbProducts.DataSource = obj.GetProducts(id);

            txtStatus.Text = "Open";

            lblX.Visible = true;

            var customers = cbCustomer.SelectedItem.ToString().Split(',');
            GETCUSTOMER[0] = customers[0].ToString();
            GETCUSTOMER[1] = customers[1].ToString();

            int cId = Convert.ToInt32(obj.GetCustomerIdByFullName(GETCUSTOMER[1].ToString(), GETCUSTOMER[0].ToString()));

            txtOrderNum.Text = obj.CreateNewBill(cId, 1).ToString();
            ID = Convert.ToInt32(txtOrderNum.Text);

            
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(obj.GetCategoryID(cbCategory.SelectedItem.ToString()));
            cbProducts.DataSource = obj.GetProducts(id);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(obj.GetCategoryID(cbCategory.SelectedItem.ToString()));
            cbProducts.DataSource = obj.GetProducts(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(obj.AddNewOrder(Convert.ToInt32(txtOrderNum.Text), cbProducts.SelectedItem.ToString(), Convert.ToInt32(txtQty.Text), "def"));

            }
            catch(Exception er)
            {
                MessageBox.Show("Network error!" + er.Message);
            }
        }



    }
}
