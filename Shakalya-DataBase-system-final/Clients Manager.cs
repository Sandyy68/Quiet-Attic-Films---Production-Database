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
    public partial class Clients_Manager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=Shakalya_Database;Integrated Security=True");
        public Clients_Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clntID = text_ClntID.Text;
            try
            {
                con.Open();
               

                SqlCommand cmd = new SqlCommand("Select * from Client where Clnt_ID ='" + clntID + "'", con);

                SqlDataReader myrecords = cmd.ExecuteReader();
                if (myrecords.HasRows)
                {
                    while (myrecords.Read())
                    {
                        text_ClntName.Text = myrecords["Clnt_Name"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No record from this Client ID !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            //Get the textbox content into a variable
            string clntName = text_ClntName.Text;
            string clntID = text_ClntID.Text;

            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into Client(Clnt_ID, Clnt_Name) values ('"+ clntID + "','" + clntName + "')", con);

            try
            {
                con.Open();
                
                cmd.ExecuteNonQuery();

                con.Close();
           
                clearall();
                MessageBox.Show("Successfully  Added!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Client", dgv_clnt_Manager);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string clntID = text_ClntID.Text;
            string clntName = text_ClntName.Text;




            SqlCommand cmd = null;
            cmd = new SqlCommand("update Client set Clnt_Name = '" + clntName + "' where Clnt_ID ='" + clntID + "'", con);

            try
            {
                con.Open();
               
                cmd.ExecuteNonQuery();

                con.Close();
                
                clearall();
                MessageBox.Show(" Successfully Updated!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Client", dgv_clnt_Manager);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string clntID = text_ClntID.Text;

            try
            {

                con.Open();
                
                SqlCommand cmd = new SqlCommand("Delete from Client where Clnt_ID = '" + clntID + "' ", con);
                cmd.ExecuteNonQuery();

                con.Close();
                

                clearall();
                MessageBox.Show("Deleted Successfully!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
                con.Close();
            }
            Program.showTable(con, "select * from Client", dgv_clnt_Manager);
        }

        private void btn_Clearall_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            text_ClntName.Text = "";
            text_ClntID.Text = "";
        }

       
        private void Clients_Manager_Load(object sender, EventArgs e)
        {
            Program.showTable(con,"select * from Client",dgv_clnt_Manager);
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void text_ClientID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
