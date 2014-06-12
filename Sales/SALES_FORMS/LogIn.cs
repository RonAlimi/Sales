using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.SALES_FORMS
{
    public partial class LogIn : Form
    {
        //Get inputs:
        string getUsername;
        string getPassword;
        string getID;
        //objects
        LogInSystem objLogin = new LogInSystem();
        //SALES_FORMS.SalesMainFrm frmMain = new SalesMainFrm();


        public LogIn()
        {
            InitializeComponent();

            //init
            getUsername = null;
            getPassword = null;
            getID = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            getUsername = txtUsername.Text;
            getPassword = txtPassword.Text;
            bool result = objLogin.ValidateUser(getUsername, getPassword);
            if (result)
            {
                MessageBox.Show("Session started!");
                getID = objLogin.GetEmployeeId();

                Client frm = new Client();
                frm.Show();
          
            }
            else
            {
                MessageBox.Show("Invalid inputs. Please check your usename and password!");
            }
        }

   
    }
}
