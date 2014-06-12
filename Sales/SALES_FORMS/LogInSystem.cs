using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.SALES_FORMS
{
    class LogInSystem
    {
        string _user;
        string _pass;
        string employeeId;
        string conString;
        SqlConnection connection;

        public LogInSystem()
        {
            conString = "Data Source=roni;Initial Catalog=inflow_local;Integrated Security=True";
        }

        public string GetUsername
        {
            get { return _user; }
            set { _user = value; }
        }

        public string GetPassword
        {
            get { return _pass; }
            set { _pass = value; }
        }


        public bool ValidateUser(string userInput,string passInput)
        {

            using (connection = new SqlConnection(conString))
            {
                connection.Open();
                string qryUsers = "select * from LogIn where username = @user and password = @pass";
                SqlCommand cmd = new SqlCommand(qryUsers, connection);
                cmd.Parameters.AddWithValue("@user", userInput);
                cmd.Parameters.AddWithValue("@pass", passInput);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    _user = reader[0].ToString();
                    _pass = reader[1].ToString();
                    employeeId = reader[2].ToString();
                   
                    if (_user != userInput && _pass != passInput)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                } reader.Close();

                return false;
            }
     
        }

        public string GetEmployeeId()
        {
            return employeeId;
        }

        public string GetEmployeeName()
        {
            return GetUsername;
        }
    }
}
