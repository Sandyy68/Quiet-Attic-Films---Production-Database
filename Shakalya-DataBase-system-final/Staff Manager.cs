using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_asssingment
{
    public partial class Staff_Manager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=Shakalya_Database;Integrated Security=True");

        public Staff_Manager()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string stID = txt_StID.Text;

            try
            {

                con.Open();
                
                SqlCommand cmd = new SqlCommand("Select * from Staff where St_ID ='" + stID + "'", con);

                SqlDataReader myrecord = cmd.ExecuteReader();
                if (myrecord.HasRows)
                {
                    while (myrecord.Read())
                    {

                        txt_StName.Text = myrecord["St_Name"].ToString();
                        cbx_StStaffType.Text = myrecord["St_Type"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Table Empty !", "Empty Table !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string stID = txt_StID.Text;
            string stName = txt_StName.Text;
            string stType = cbx_StStaffType.SelectedItem.ToString();


            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into Staff(St_ID,St_Name,St_Type) values ('"+stID+"','" + stName + "','" + stType + "')", con);

            try
            {
                con.Open();
                
                cmd.ExecuteNonQuery();

                con.Close();
                

                MessageBox.Show(" Successfully Added!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                clearall();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Staff", dgv_StaffManager);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string stID = txt_StID.Text;
            string stName = txt_StName.Text;
            string stType = cbx_StStaffType.SelectedItem.ToString();


            SqlCommand cmd = null;
            cmd = new SqlCommand("update Staff set St_Name='" + stName + "', St_Type='" + stType + "' where St_ID='" + stID + "'", con);

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
            Program.showTable(con, "select * from Staff", dgv_StaffManager);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string stID = txt_StID.Text;

            try
            {

                con.Open();
                
                SqlCommand cmd = new SqlCommand("Delete from Staff where St_ID = '" + stID + "' ", con);
                cmd.ExecuteNonQuery();

                con.Close();
                


                MessageBox.Show("Successfully Deleted!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearall();
               
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
                con.Close();
            }
            Program.showTable(con, "select * from Staff", dgv_StaffManager);
        }

        private void btn_Clearall_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            txt_StID.Text = "";
            txt_StName.Text = "";
            cbx_StStaffType.Text = "";
        }

        private void Staff_Manager_Load(object sender, EventArgs e)
        {
            
            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from Staff_Types;", con);

                SqlDataReader myrecord = cmd.ExecuteReader();
                if (myrecord.HasRows)
                {
                    while (myrecord.Read())
                    {
                        cbx_StStaffType.Items.Add(myrecord["St_Type"].ToString());

                    }
                }
                else
                {
                    MessageBox.Show("Table Empty !", "Empty Table !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            
            Program.showTable(con, "select * from Staff", dgv_StaffManager);

        }

        private void button1_Click(object sender, EventArgs e)
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
