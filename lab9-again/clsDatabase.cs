using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;



namespace lab9_again
{
    class clsDatabase
    {
        public static SqlConnection con;
        public static bool openConnection()
        {
            try
            {
                con = new SqlConnection("Server=WinDev2311Eval; Database=lab9;User Id=mylogin;password=mylogin");
                con.Open();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public static bool closeConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}