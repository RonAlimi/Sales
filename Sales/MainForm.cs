using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sales.SALES_FORMS;

namespace Sales
{
    public partial class MainForm : Form
    {
        #region PROPERTIES AND OBJECTS


        static string SESSION;
        LogInSystem loginFrm;
        Costumers customerObj;
        Orders orderObj;
        Client clientObj;
        InterfaceLogic obj;

        WS_Sales.WS_SalesSoapClient wsObj;

        #endregion

        public MainForm(string employee)
        {
            InitializeComponent();

            //start session
            SESSION = employee;

            //init objects
            customerObj = new Costumers();
            orderObj = new Orders();
            obj = new InterfaceLogic();
            wsObj = new WS_Sales.WS_SalesSoapClient();

            btnGetinfo.Enabled = false;
        }


        #region FORM EVENTS

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string website = "";

            if (txtName.Text != string.Empty)
            {
                if (txtSurname.Text != string.Empty)
                {
                    if (txtAddress.Text != string.Empty)
                    {
                        MessageBox.Show(wsObj.InsertNewCostumer(name, surname, email, phone, address, website));
                        ClearTextboxes();
                    }
                    else
                        MessageBox.Show("Address is a required field");
                }
                else
                    MessageBox.Show("Surname is a required field");
            }
            else
                MessageBox.Show("Name is a required field!");

            statusLbl.Text = "Ready";

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            datagridSearch.DataSource = obj.SearchCustomer(txtSearchByCustomer.Text).Tables[0];
            btnGetinfo.Enabled = true;
        }

        private void btnGetinfo_Click(object sender, EventArgs e)
        {
            if (datagridSearch.SelectedCells.Count > 0)
            {

                int selectedRowIndex = datagridSearch.SelectedCells[0].RowIndex;
                DataGridViewRow row = datagridSearch.Rows[selectedRowIndex];
                string getVal = Convert.ToString(row.Cells[0].Value);
                datagridMain.DataSource = customerObj.GetCostumerInfo(getVal).Tables[0];
            }
            else
            {
                MessageBox.Show("Please select a row to view customer info!");
            }
        }

        #endregion

       



        #region TOOL STRIP EVENTS

        private void tstripInvoices_Click(object sender, EventArgs e)
        {
            datagridMain.DataSource = wsObj.GetAllInvoices().Tables[0];
        }

        private void tsripGetSales_Click(object sender, EventArgs e)
        {
            datagridMain.DataSource = wsObj.GetOrderList().Tables[0];
        }

        private void tstripCustomerList_Click(object sender, EventArgs e)
        {
            datagridMain.DataSource = wsObj.GetAllCostumers().Tables[0];
        }

        #endregion




        #region MENU STRIP EVENTS

        private void supportChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientObj = new Client();
            clientObj.ShowDialog(this);
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            AddNewOrderForm addFrm = new AddNewOrderForm();
            addFrm.ShowDialog();
             * */
            OrderNewForm f = new OrderNewForm();
            f.ShowDialog();
        }

        #endregion


        #region CHECKERS

        private void ClearTextboxes()
        {
            txtName.Text = null;
            txtSurname.Text = null;
            txtEmail.Text = null;
            txtPhone.Text = null;
            txtAddress.Text = null;
        }

        #endregion

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }





    }
}
