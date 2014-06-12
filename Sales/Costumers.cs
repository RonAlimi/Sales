using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales
{
    public class Costumers
    {

        #region Properties of Costumer

        int _cutomerID;
        string _name;
        string _surname;
        double _balance;
        // contact info
        string email;
        string phoneNum;
        string website;
        string address;
        #endregion

        #region Accessors
        public int ID
        {
            get { return _cutomerID; }
            set { _cutomerID = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        #endregion

        // create database connection 
        static string conString;
        SqlConnection connection;
        public Costumers()
        {
            conString = "Data Source=roni;Initial Catalog=inflow_local;Integrated Security=True";
            connection = new SqlConnection(conString);
        }

        #region Methods of Costumer

        public string InsertNewCostumer(string name, string surname, string email, string phone, string address, string website)
        {
            int affectedRow;
            website = "default.org";
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd;
                    using (cmd = new SqlCommand("AddNewCustomer", connection) { CommandType = CommandType.StoredProcedure })
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@surname", surname);
                        cmd.Parameters.AddWithValue("@email", name);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@address ", address);
                        cmd.Parameters.AddWithValue("@website", website);

                        affectedRow = cmd.ExecuteNonQuery();
                        // if affectedRow > 0, insert is successful
                        if (affectedRow > 0)
                            return "klienti u shtua ne databaze.";
                        else
                            return "klienti nuk u shtua ne databaze!";
                    }

                }


            }
            catch (Exception errorExecution)
            {
                return errorExecution.Message;
            }

        }//end method
        public DataSet GetCostumerInfo(string name)
        {
            try
            {
                DataSet result = new DataSet();

                using (connection = new SqlConnection(conString))
                {
                    connection.Open();
                    SqlCommand cmd;
                    using (cmd = new SqlCommand("GetCustomerInfo", connection) { CommandType = CommandType.StoredProcedure })
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(result);

                        return result;
                    }
                }

            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

        }


        /// <summary>
        /// Copyrights: Rreze Zhaku
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllCostumers()
        {
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd;
                    using (cmd = new SqlCommand("GetAllCustomers", connection) { CommandType = CommandType.StoredProcedure })
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        return ds;
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
        public DataSet GetCostumerOrderHistory(int id)
        {
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd;
                    using (cmd = new SqlCommand("GetCustomerOrderHistory", connection)
                    {
                        CommandType = CommandType.StoredProcedure,
                    })
                    {
                        cmd.Parameters.Add(new SqlParameter("@CustomerID", id));
                        cmd.ExecuteNonQuery();

                        DataSet ds = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(ds);

                        return ds;
                    }

                }

            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public DataSet GetCustomerList()
        {
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd;
                    using (cmd = new SqlCommand("GetAllCustomers", connection)
                    {
                        CommandType = CommandType.StoredProcedure,
                    })
                    {
                        cmd.ExecuteNonQuery();

                        DataSet ds = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(ds);

                        return ds;
                    }
                }

            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }
        #endregion

        #region PUBLISH THIS TO WEBSERVICE

        public string GetLastOrderNum()
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from Purchaseinfo ", connection);
                string count = cmd.ExecuteScalar().ToString();

                return count;
            }
        }

        public string GetProductPrice(string name)
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select price from Products where name = '" + name + "'", connection);
                try
                {
                    string price = cmd.ExecuteScalar().ToString();
                    return price;
                }
                catch (NullReferenceException)
                {
                    return "0";
                }


            }
        }

        public List<string> GetCustomersList()
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT surname + ',' + name AS Customer FROM dbo.Customer", connection);
                List<string> set = new List<string>();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    set.Add(reader[0].ToString());
                } reader.Close();

                return set;
            }
        }

        public string GetCategoryID(string cat)
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select Category.catID from Category where catName = '" + cat + "'", connection);
                string id = cmd.ExecuteScalar().ToString();

                return id;
            }
        }

        public List<string> GetCat()
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT catName From Category", connection);
                List<string> set = new List<string>();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    set.Add(reader[0].ToString());
                } reader.Close();

                return set;
            }
        }//end this

        public List<string> GetProducts(int id)
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT name From Products where catID = " + id, connection);
                List<string> set = new List<string>();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    set.Add(reader[0].ToString());
                } reader.Close();

                return set;
            }
        }



        #endregion

    }



}
