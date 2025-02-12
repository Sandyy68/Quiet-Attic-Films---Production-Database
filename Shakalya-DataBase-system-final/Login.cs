using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_asssingment
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=Shakalya_Database;Integrated Security=True");
        // which account level
        public static string accountLevel;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accName = txtUserName.Text;
            string accPass = txtPassword.Text;
            bool foundMatch = false;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from User_Login;", con);
                SqlDataReader myR = cmd.ExecuteReader();
                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        string userName = myR["Uname"].ToString();
                        string password = myR["Pass"].ToString();

                        if (userName == accName && password == accPass)
                        {
                            foundMatch = true;
                            if (userName == "Admin")
                            {
                                // grant permission for admin
                                Admin_Dash_Board d = new Admin_Dash_Board();
                                d.Show();
                                Hide();
                                accountLevel = "Admin";
                            }
                            else
                            {
                                // grant permission for staff
                                staff_dashboard d = new staff_dashboard();
                                d.Show();
                                Hide();
                                accountLevel = "Staff";
                            }
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Accounts Available !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (!foundMatch)
                {
                    // display error message
                    MessageBox.Show("Wrong Account Login !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
