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
    public partial class StaffTypes : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=Shakalya_Database;Integrated Security=True");
        public StaffTypes()
        {
            InitializeComponent();
        }

        private void StaffTypes_Load(object sender, EventArgs e)
        {
            Program.showTable(con, "select * from Staff_Types", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Stf = txt_STF.Text;
            
            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from Staff_Types where St_Type ='" + Stf + "'", con);

                SqlDataReader myR = cmd.ExecuteReader();
                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        txt_STFSal.Text = myR["St_Fee"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No Staff Type with this ID !", "No Records !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
        }

        private void clearAll()
        {
            txt_STF.Clear();
            txt_STFSal.Clear();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stfTypes = txt_STF.Text;
            string stfSal = txt_STFSal.Text;

            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("insert into Staff_Types values ('"+stfTypes+ "','"+stfSal+"')", con);
                cl.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Staff_Types", dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stfTypes = txt_STF.Text;
            string stfSal = txt_STFSal.Text;

            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("update Staff_Types set St_Fee = '"+stfSal+"' where St_Type = '"+stfTypes+"';", con);
                cl.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Staff_Types", dataGridView1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string StaffType = txt_STF.Text;

            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("delete from Staff_Types where St_Type = '"+StaffType+"';", con);
                cl.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Staff_Types", dataGridView1);

        }

        private void button6_Click(object sender, EventArgs e)
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
