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
    public partial class Properties_Manager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=Shakalya_Database;Integrated Security=True");

        public Properties_Manager()
        {
            InitializeComponent();
        }

        private void bttn_Search_Click(object sender, EventArgs e)
        {
            string propID = text_propID.Text;

            try
            {

                con.Open();
                
                SqlCommand cmd = new SqlCommand("Select * from Property where Prop_ID ='" + propID + "'", con);

                SqlDataReader myrecord = cmd.ExecuteReader();
                if (myrecord.HasRows)
                {
                    while (myrecord.Read())
                    {

                        text_propName.Text = myrecord["Prop_Name"].ToString();
                        cbx_propType.Text = myrecord["Prop_Type"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("No record from this Property ID !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clearall();
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
            string propID = text_propID.Text;
            string propName = text_propName.Text;
            string propType = cbx_propType.SelectedItem.ToString();


            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into Property(Prop_ID,Prop_Name,Prop_Type) values ('" + propID+"','" + propName + "','" + propType + "')", con);

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
            Program.showTable(con, "select * from Property", dgv_PropManager);
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string propertyname = text_propName.Text;
            string propertytype = cbx_propType.SelectedItem.ToString();
            string propertyid = text_propID.Text;

            SqlCommand cmd = null;
            cmd = new SqlCommand("update Property set Prop_Name ='" + propertyname + "', Prop_Type='" + propertytype + "' where Prop_ID='" + propertyid + "'", con);

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
            Program.showTable(con, "select * from Property", dgv_PropManager);
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            string propertyid = text_propID.Text;

            try
            {

                con.Open();
               
                SqlCommand cmd = new SqlCommand("Delete from Property where Prop_ID = '" + propertyid + "' ", con);
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
            Program.showTable(con, "select * from Property", dgv_PropManager);
        }

        private void bttn_Clearall_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            text_propID.Text = "";
            text_propName.Text = "";
            cbx_propType.Text = "";
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

        private void text_propertyid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Properties_Manager_Load(object sender, EventArgs e)
        {
            Program.showTable(con, "select * from Property", dgv_PropManager);
        }
    }
}
