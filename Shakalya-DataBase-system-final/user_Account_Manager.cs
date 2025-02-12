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
    public partial class user_Account_Manager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=Shakalya_Database;Integrated Security=True");

        public user_Account_Manager()
        {
            InitializeComponent();
        }

        private void user_Account_Manager_Load(object sender, EventArgs e)
        {
            Program.showTable(con, "select * from User_Login", dgv_User_Acc);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Uid = txt_user_Id.Text;
            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand("Select * from User_Login where UID ='" + Uid + "'", con);

                SqlDataReader myrecords = cmd.ExecuteReader();
                if (myrecords.HasRows)
                {
                    while (myrecords.Read())
                    {
                        txt_Pass.Text = myrecords["Pass"].ToString();
                        txt_user_Name.Text = myrecords["Uname"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No record from this User ID !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string Uname = txt_user_Name.Text;
            string pass = txt_Pass.Text;
            string uID = txt_user_Id.Text;


            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into User_Login(UID,Uname,Pass) values ('" + uID+"','" + Uname + "','" + pass + "')", con);

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();


                MessageBox.Show("Successfully  Added!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clearall();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from User_Login", dgv_User_Acc);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string Uname = txt_user_Name.Text;
            string pass = txt_Pass.Text;
            string uID = txt_user_Id.Text;
            

            SqlCommand cmd = null;
            cmd = new SqlCommand("update User_Login set Uname ='" + Uname + "', Pass='" + pass + "' where UID = '" + uID+"';", con);

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();


                MessageBox.Show("Successfully  Updated!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from User_Login", dgv_User_Acc);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string user = txt_user_Id.Text;

            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("Delete from User_Login where UID = '" + user + "' ", con);
                cmd.ExecuteNonQuery();

                con.Close();



                MessageBox.Show("Successfully Deleted!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clearall();

            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
                con.Close();
            }
            Program.showTable(con, "select * from User_Login", dgv_User_Acc);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearall();
        }
        public void Clearall()
        {
            txt_user_Name.Clear();
            txt_Pass.Clear();
            txt_user_Id.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (Login.accountLevel == "Admin")
            {
                Admin_Dash_Board s = new Admin_Dash_Board();
                s.Show();
                Hide();
            }
            else
            {
                staff_dashboard s = new staff_dashboard();
                s.Show();
                Hide();
            }
        }
    }
}
