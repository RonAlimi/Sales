using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales
{
    public class Orders
    {
        #region Order Properties

        int _id;
        string _status;
        string _costumerID;
        string _location;
        double _paidTotal;
        string _date;
        static string conString;
        SqlConnection connection;

        #endregion

        #region Accessors
        public Orders()
        {
            conString = "Data Source=roni;Initial Catalog=inflow_local;Integrated Security=True";
        }
        public int OrderID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string CostumerID
        {
            get { return _costumerID; }
            set { _costumerID = value; }
        }
        public string ShippmentLocation
        {
            get { return _location; }
            set { _location = value; }
        }
        public double TotalPayment
        {
            get { return _paidTotal; }
            set { _paidTotal = value; }
        }
        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }
        #endregion

        #region Public Methods
        //Update
        public string AddNewOrder(int id, string productName, int qty, string description)
        {
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    if (CheckInStock(productName))
                    {
                        if (GetQuantity(productName) > qty)
                        {
                            return AddToBasket(id, productName, qty, description).ToString();
                        }
                        else
                            return "There are less available items in Stock for this product!";
                    }
                    else
                        return "Not in Stock!";


                }
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }
        private string AddToBasket(int id, string productName, int qty, string description)
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd;
                using (cmd = new SqlCommand("AddItemsToBill", connection) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.AddWithValue("@billId", id);
                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@quantity", qty);
                    cmd.Parameters.AddWithValue("@description", description);

                    int result = cmd.ExecuteNonQuery();
                    if (result < 1)
                    {
                        return "added to bill";
                    }
                    else
                        return "couldn't add to bill";

                }

            }
        }
        //Select
        public DataSet GetOrderByCostumer(string name)
        {
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd;
                    using (cmd = new SqlCommand("GetOrderByCustomer", connection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure,
                    })
                    {
                        cmd.Parameters.AddWithValue("@name", name);
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
        public DataSet GetOrderByDate(string date)
        {
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd;
                    using (cmd = new SqlCommand("GetOrderByDate", connection) { CommandType = CommandType.StoredProcedure })
                    {
                        DateTime dbdate = DateTime.Parse(string.Format(date, "yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@parameterDate", dbdate);
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

        public DataSet GetOrderList()
        {
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd;
                    using (cmd = new SqlCommand("GetAllSales", connection)
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

        public string GetLastOrder()
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from Purchaseinfo", connection);
                string getThis = cmd.ExecuteScalar().ToString();
                connection.Close();

                return getThis;
            }
        }
        #endregion

        #region Helpers

        private bool CheckInStock(string productName)
        {
            int qty = GetQuantity(productName);

            if (qty > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int GetQuantity(string productname)
        {

            using (connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlCommand cmd;
                using (cmd = new SqlCommand("CheckInStock", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    cmd.Parameters.AddWithValue("@productName", productname);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int getQuantity = 0;
                    while (reader.Read())
                    {
                        getQuantity = Convert.ToInt32(reader[0]);
                    }
                    reader.Close();

                    return getQuantity;
                }
            }
        }

        private int GetIdFromProductName(string product)
        {
            int id = -1;
            using (connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select prid from Products where Products.name = '" + product + "'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader[0]);
                } reader.Close();
            }
            return id;
        }

        public int CreateNewBill(int cId, int eid)
        {

            try
            {
                // return this:
                int billId = -1;

                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmdCreateBill;
                    using (cmdCreateBill = new SqlCommand("CreateBill", connection)
                    {
                        CommandType = CommandType.StoredProcedure,
                    })
                    {
                        cmdCreateBill.Parameters.AddWithValue("@costumerId", cId);
                        cmdCreateBill.Parameters.AddWithValue("@employeeId", eid);
                        cmdCreateBill.ExecuteNonQuery();

                        // Add items to bill;
                        SqlCommand cmdGetBillId = new SqlCommand("select IDENT_CURRENT('Purchaseinfo')", connection);
                        SqlDataReader reader = cmdGetBillId.ExecuteReader();

                        while (reader.Read())
                        {
                            billId = Convert.ToInt32(reader[0]);
                        }
                        reader.Close();
                    }

                    return billId;
                }
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }

        }

        private string AddProductsToBill(int billId, int productId, int quantity, string description)
        {
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();

                    SqlCommand cmd;
                    using (cmd = new SqlCommand("AddItemsToBill", connection)
                    {
                        CommandType = CommandType.StoredProcedure,
                    })
                    {
                        cmd.Parameters.AddWithValue("@billId", billId);
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@description", description);

                        cmd.ExecuteNonQuery();
                        return "Transaction commited!";
                    }
                }
            }
            catch (Exception error)
            {
                return error.Message;
                throw new Exception(error.Message);
            }
        }
        #endregion


        public string GetCustomerIdByFullName(string name, string surnam)
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select Customer.cid From Customer where name = '" + name + "' and surname = '" + surnam + "'", connection);
                string result = cmd.ExecuteScalar().ToString();
                return result;
            }
        }

        /// <summary>
        /// RREZE ZHAKU author
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllInvoices()
        {
            using (connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlCommand cmd;
                using (cmd = new SqlCommand("GetAllInvoices", connection) { CommandType = CommandType.StoredProcedure })
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                    return ds;
                }
            }
        }
    }
}
