using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace pos_system
{
    public static class UserSession
    {
        public static string LoggedInCashierID { get; set; }
        public static string FirstName { get; set; }
    }
    class Operations
    {
        protected OleDbConnection getcon()
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\rezel\Documents\Visual Studio 2015\Projects\pos_system\pos_system\bin\Debug\Balagbag.accdb";
            return con;
        }
        
        public void insertdata(string query)
        {
            OleDbConnection con = getcon();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("PRODUCT ADDED SUCCESSFULLY");
            con.Close();
        }
        public DataSet populate(string query)
        {
            OleDbConnection con = getcon();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
