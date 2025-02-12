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
    public partial class Location_Manager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=Shakalya_Database;Integrated Security=True");

        public Location_Manager()
        {
            InitializeComponent();
        }

        private void bttn_Search_Click(object sender, EventArgs e)
        {
            string locID = text_Loc_ID.Text;

            try
            {

                con.Open();
               
                SqlCommand cmd = new SqlCommand("Select * from Location where Loc_ID ='" + locID + "'", con);

                SqlDataReader myR = cmd.ExecuteReader();
                if (myR.HasRows)
                {
                    while (myR.Read())
                    {

                        text_Loc_Name.Text = myR["Loc_Name"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("No record from this Location ID !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string locName = text_Loc_Name.Text;
            string locID = text_Loc_ID.Text;




            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into Location(Loc_ID,Loc_Name) values ('" + locID + "','" + locName + "')", con);

            try
            {
                con.Open();
               
                cmd.ExecuteNonQuery();

                con.Close();
               

                MessageBox.Show("Successfully Added!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                clearall();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Location", dgv_locmanager);
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string locID = text_Loc_ID.Text;
            string locName = text_Loc_Name.Text;


            SqlCommand cmd = null;
            cmd = new SqlCommand("update Location set Loc_Name='" + locName + "' where Loc_ID ='" + locID + "'", con);

            try
            {
                con.Open();
                
                cmd.ExecuteNonQuery();

                con.Close();
                

                MessageBox.Show("Successfully Updated!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Location", dgv_locmanager);
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string locID = text_Loc_ID.Text;

            try
            {

                con.Open();
               
                SqlCommand cmd = new SqlCommand("Delete from Location where Loc_ID = '" + locID + "' ", con);
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
            Program.showTable(con, "select * from Location", dgv_locmanager);
        }

        private void bttn_Clearall_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall() 
        {
            text_Loc_ID.Text = "";
            text_Loc_Name.Text = "";
        }

        private void Location_Manager_Load(object sender, EventArgs e)
        {
            Program.showTable(con, "select * from Location", dgv_locmanager);

        }

        private void btn_Back_Click(object sender, EventArgs e)
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

        private void text_locationname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
