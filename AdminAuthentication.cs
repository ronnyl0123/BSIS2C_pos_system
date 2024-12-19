using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pos_system
{
    public partial class AdminAuthentication : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public AdminAuthentication()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\rezel\Documents\Visual Studio 2015\Projects\pos_system\pos_system\bin\Debug\Balagbag.accdb";
        }

        private void AdminAuthentication_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT UserType FROM accuser WHERE UserName = @username AND Password = @password";
                cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);

                // Execute the command and retrieve the user type and first name
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string userType = reader["UserType"].ToString();

                    if (userType == "Admin")
                    {
                        MessageBox.Show("appproved");
                    }
                    else
                    {
                        MessageBox.Show("Admin only");
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username and password are not correct.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

