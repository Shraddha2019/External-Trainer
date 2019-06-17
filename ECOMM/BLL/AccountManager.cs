using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public static class AccountManager
    {
        //Membership and Roles management related functionality

        public static bool Validate(string userName, string password)
        {
            bool status = false;
            status = AccountsDAL.Validate(userName, password);
            return status;

        }

        //public static bool Register(string userName, string password)
        //{

        //    bool status = false;
        //    //verfiy logic
        //    //Query Processing


        //    return status;
        //}


        public static bool ChangePassword(string userName, string pldpassword, string newPassword)
        {

            bool status = false;
            // CRUD Operation
            //DML commands


            return status;
        }
    }
}
