using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace pos_system
{
    public partial class VerifyPass : Form
    {
        string OTPCode;
        public static string ReceivedOTP { get; set; }
        public VerifyPass(string otp)
        {
            InitializeComponent();
            ReceivedOTP = otp;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void VerifyPass_Load(object sender, EventArgs e)
        {

        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();

            this.Hide();
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            // Trim the input to avoid leading/trailing spaces
            string userInputOTP = txt_code.Text.Trim();

            // Debugging: Show the received OTP and user input
            Console.WriteLine($"Received OTP: {ReceivedOTP}");
            Console.WriteLine($"User  Input OTP: {userInputOTP}");

            if (userInputOTP == ReceivedOTP)
            {
                // OTP is valid, proceed to the next step
                MessageBox.Show("VERIFIED");
                ResetPass rp = new ResetPass();
                rp.Show();
                this.Hide();
            }
            else
            {
                // OTP is invalid
                MessageBox.Show("Invalid OTP. Please try again.");
            }
        }
    }
}
