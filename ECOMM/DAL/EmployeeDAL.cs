using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BOL;
namespace DAL
{
  public static class EmployeeDAL
    {

     public static string connectionstring = ConfigurationManager.ConnectionStrings["ECOMMDBConnectionString"].ToString();
      public static List<Employee> GetAll()
      {
         
          List<Employee> employees = new List<Employee>();

          SqlConnection con = new SqlConnection();
          con.ConnectionString = connectionstring;
                
          string query = "SELECT * FROM employees";
          SqlCommand cmd = new SqlCommand(query, con as SqlConnection);
          SqlDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);
          DataSet ds = new DataSet();
          da.Fill(ds);
          DataRowCollection rows = ds.Tables[0].Rows;
          foreach (DataRow row in rows)
          {
              int Id = int.Parse(row["Id"].ToString());
              string FirstName = row["Name"].ToString();
              string Gender = row["Gender"].ToString();
              string City = row["City"].ToString();
              string Email = row["Email"].ToString();
              int Age = int.Parse(row["Age"].ToString());
              // int likes = int.Parse(row["Likes"].ToString());

              employees.Add(new Employee()
              {
                  Id = Id,
                  Name = FirstName,
                  Gender = Gender,
                  City = City,
                  Email = Email,
                  Age = Age
                  //Likes = likes
              });

          }

          return employees;
      }
        public static bool Register( Employee emp)
        {
            bool status = false;
           try
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["ECOMMDBConnectionString"].ToString();
                //  connectionstring = @"data source=(localdb)\mssqllocaldb;attachdbfilename=c:\users\neova-user\documents\.net training\ecomm\ecomm\app_data\ecommdata.mdf;integrated security=true";
                string commandstring = "INSERT INTO employees (Id,Name, Gender, City, Email,Age) VALUES (@Id,@Name,@Gender,@City,@Email,@Age) ";


                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionstring;
                //    if (con.state == connectionstate.closed)
                //     con.open();
                //  string query = "select * from users where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                cmd.CommandText = commandstring;
                con.Open();

                cmd.Parameters.Add(new SqlParameter("@Id", 22));

                cmd.Parameters.Add(new SqlParameter("@Name", emp.Name));
                cmd.Parameters.Add(new SqlParameter("@Gender", emp.Gender));
                cmd.Parameters.Add(new SqlParameter("@City", emp.City));
                cmd.Parameters.Add(new SqlParameter("@Email", emp.Email));
                cmd.Parameters.Add(new SqlParameter("@Age", emp.Age));

                cmd.ExecuteNonQuery();
                con.Close();
            } 
            //if (con.State == ConnectionState.Open)
                    //con.Close();

           catch (SqlException exp)
           {
               string exceptionMessage = exp.Message;
           }
                


            return status;
        }


    }

}
