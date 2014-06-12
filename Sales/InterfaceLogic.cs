using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;


namespace Sales
{
    class InterfaceLogic
    {
        string conString;
        SqlConnection connection;

        public InterfaceLogic()
        {
            conString = "Data Source=roni;Initial Catalog=inflow_local;Integrated Security=True";
            connection = new SqlConnection(conString);
        }


        

        public DataSet SearchCustomer(string customer)
        {
            DataSet list = new DataSet();

            using (connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select name,surname from Customer where name like '%"+customer+"%'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(list);
                return list;
            }

        }

        
    }
}
