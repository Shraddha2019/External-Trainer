using System;
using System.Data;
using System.Data.SqlClient;
using BOL;
using System.Configuration;
namespace DAL
{
    public static class AccountsDAL
    {
        private static string connectionstring = string.Empty;
        //static accountsdal()
        //{
        //    //connectionstring = @"data source=(localdb)\mssqllocaldb;attachdbfilename=c:\users\ravit\source\repos\ecommercesolution\estore\app_data\ecommercedb.mdf;integrated security=true";
        //    connectionstring = @"data source=(localdb)\mssqllocaldb;attachdbfilename=c:\users\neova-user\documents\.net training\ecomm\ecomm\app_data\ecommdata.mdf;integrated security=true";
        //    ////    string connectionstring=configurationmanager.connectionstrings["ecommdbconnectionstring"].tostring();
        //    string commandstring = "select * from users where username=@username and password=@password";
        //}
        public static bool Validate(string username, string password)
        {
            bool status = false;
            string connectionstring = ConfigurationManager.ConnectionStrings["ECOMMDBConnectionString"].ToString();
            //  connectionstring = @"data source=(localdb)\mssqllocaldb;attachdbfilename=c:\users\neova-user\documents\.net training\ecomm\ecomm\app_data\ecommdata.mdf;integrated security=true";
            string commandstring = "select * from users where username=@username and password=@password";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionstring;
            //    if (con.state == connectionstate.closed)
            //     con.open();
            //  string query = "select * from users where username=@username and password=@password";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = commandstring;
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.Parameters.Add(new SqlParameter("@password", password));


            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader() as SqlDataReader;
                {
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            status = true;
                            reader.Close();
                        }
                    }

                }
            }
            catch (SqlException exp)
            {
                throw exp;

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }



            return status;
        }

    
    }

    //public static class AccountsDAL
    //{
    //    public static bool Validate(string userName, string password)
    //    {
    //        #region  string assignment
    //        bool status = false;
    //        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\RaviT\MVC\ECommerce\EStore\App_Data\TFLGreenhouse.mdf;Integrated Security=True";
    //        string connectionString = ConfigurationManager.ConnectionStrings["ECOMMDBConnectionString"].ToString();
    //        string commandString = "SELECT * FROM USERS WHERE userName=@UserName AND password=@Password";
    //        #endregion

    //        #region Command Exeuction context setting

    //        IDbConnection con = new SqlConnection();
    //        con.ConnectionString = connectionString;
    //        IDbCommand cmd = new SqlCommand();
    //        cmd.Connection = con;
    //        cmd.CommandText = commandString;
    //        cmd.Parameters.Add(new SqlParameter("@UserName", userName));
    //        cmd.Parameters.Add(new SqlParameter("@Password", password));

    //        #endregion

    //        #region Query Processing

    //        try
    //        {
    //            con.Open();
    //            SqlDataReader reader = cmd.ExecuteReader() as SqlDataReader;
    //            {
    //                if (reader != null)
    //                {
    //                    if (reader.HasRows)
    //                    {
    //                        status = true;
    //                        reader.Close();
    //                    }
    //                }

    //            }
    //        }
    //        catch (SqlException exp)
    //        {
    //            throw exp;

    //        }
    //        finally
    //        {
    //            if (con.State == ConnectionState.Open)
    //                con.Close();
    //        }


    //        #endregion

    //        return status;
    //    }

    //}
   


}