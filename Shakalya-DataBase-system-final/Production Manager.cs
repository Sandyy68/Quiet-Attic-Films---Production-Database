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
using static System.Windows.Forms.AxHost;

namespace DataBase_asssingment
{
    public partial class Production_Manager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=Shakalya_Database;Integrated Security=True");

        public Production_Manager()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttn_Search_Click(object sender, EventArgs e)
        {
            // setting vars
            string prodID = txtProdID.Text;
            string clId = "";
          

            // getting production name to textbox

            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from Production join Client on Production.Clnt_ID = Client.Clnt_ID where Prod_ID ='" + prodID + "';", con);

                SqlDataReader myR = cmd.ExecuteReader();
                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        txtProdName.Text = myR["Prod_Name"].ToString();
                        //clId = myR["Client_ID"].ToString();
                        cmbClntName.SelectedItem = myR["Clnt_Name"];
                        cmbProdType.SelectedItem = myR["Prod_Type"];
                        dtp_start.Value = DateTime.Parse(myR["Start_Date"].ToString());
                        dtp_end.Value = DateTime.Parse(myR["End_Date"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No Production with this ID !", "No Records !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtProdName.Text != "" && txtProdName.Text != "")
            {
                // getting textbox text to vars
                string prodID = txtProdID.Text;
                string prodName = txtProdName.Text;
                string prodClient = cmbClntName.SelectedItem.ToString();
                string stratdate = dtp_start.Value.ToString("yyyy-MM-dd");
                string enddate = dtp_end.Value.ToString("yyyy-MM-dd");
                string prodType = cmbProdType.SelectedItem.ToString();

                // inserting data
                SqlCommand cmd = null;
                cmd = new SqlCommand("insert into Production (Prod_ID, Prod_Name,Clnt_ID,Start_Date,End_Date,Prod_Type) values ('" + prodID + "','" + prodName + "',(select Client_ID from Client where Client_Name = '"+ prodClient + "'),'" + stratdate + "','" + enddate + "','"+prodType+"')", con);

                try
                {
                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();


                    MessageBox.Show("Added Successfully!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
                Clearall();
                Program.showTable(con, "select * from Production", dataGridView1);
            }
            else
            {
                MessageBox.Show("Fill all the input fields !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // asign Production cmbs
            loadProdCmbs();
            // load dgvs
            loadDgvs();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txtProdID.Text != ""  && txtProdName.Text != "")
            {
                //MessageBox.Show(cmbClientName.SelectedItem.ToString());
                

                //Get the textbox content into a variable
                string prodID = txtProdID.Text;
                string prodName = txtProdName.Text;
                string clntName = cmbClntName.SelectedItem.ToString();
                string startdate = dtp_start.Value.ToString("yyyy-MM-dd");
                string enddate = dtp_end.Value.ToString("yyyy-MM-dd");
                string prodType = cmbProdType.SelectedItem.ToString();

                SqlCommand cmd = null;
                cmd = new SqlCommand("update Production set Prod_Name = '" + prodName + "', Clnt_ID = (select Clnt_ID from Client where Clnt_Name = '" + clntName+"'), Start_Date='" + startdate + "', End_Date='" + enddate + "', Prod_Type = '" + prodType+ "' where Prod_ID='" + prodID + "'", con);

                try
                {
                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();


                    MessageBox.Show("Updated Successfully!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
                Program.showTable(con, "select * from Production", dataGridView1);
            }
            else
            {
                MessageBox.Show("Fill all the input fields !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // asign Production cmbs
            loadProdCmbs();
            // load dgvs
            loadDgvs();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txtProdID.Text != "")
            {
                string prodID =txtProdID.Text;


                try
                {

                    con.Open();

                    SqlCommand cmd = new SqlCommand("Delete from Production where Prod_ID = '" + prodID + "' ", con);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Successfully Deleted !", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                    con.Close();
                }
                Clearall();
                Program.showTable(con, "select * from Production", dataGridView1);
            }
            else
            {
                MessageBox.Show("Provide the Production ID !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            // asign Production cmbs
            loadProdCmbs();
            // load dgvs
            loadDgvs();

        }

        private void btn_Clearall_Click(object sender, EventArgs e)
        {
            Clearall();
        }
        public void Clearall()
        {
            txtProdID.Text = "";
            
            txtProdName.Text = "";
            dtp_start.Value = DateTime.Today;
            dtp_end.Value = DateTime.Today;
        }

        private void Production_Manager_Load(object sender, EventArgs e)
        {
            // load clients
            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("select * from Client", con);
                SqlDataReader myrecord = cl.ExecuteReader();
                if (myrecord.HasRows)
                {
                    while (myrecord.Read())
                    {
                        cmbClntName.Items.Add(myrecord["Clnt_Name"]);
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
            // asign Production cmbs
            loadProdCmbs();
            // load dgvs
            loadDgvs();
            // load locations
            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("SELECT Loc_Name FROM Location", con);
                SqlDataReader myrecord = cl.ExecuteReader();
                if (myrecord.HasRows)
                {
                    cmbLocPPL.Items.Clear();
                    while (myrecord.Read())
                    {
                        cmbLocPPL.Items.Add(myrecord["Loc_Name"]);
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

        private void loadProdCmbs()
        {
            cmbProdPPS.Items.Clear();
            cmbProdPPL.Items.Clear();
            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("select * from Production", con);
                SqlDataReader myrecord = cl.ExecuteReader();
                if (myrecord.HasRows)
                {
                    while (myrecord.Read())
                    {
                        cmbProdPPS.Items.Add(myrecord["Prod_Name"]);
                        cmbProdPPL.Items.Add(myrecord["Prod_Name"]);
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

        private void loadDgvs()
        {
            Program.showTable(con, "SELECT Prod_ID , Prod_Name, Clnt_Name , Start_Date , End_Date , Prod_Type from Production join Client on Production.Clnt_ID = Client.Clnt_ID;", dataGridView1);
            Program.showTable(con, "SELECT Prod_Name, Prop_Name, Loc_Name FROM Production_Property_Location JOIN Production ON Production_Property_Location.Prod_ID = Production.Prod_ID JOIN Property ON Production_Property_Location.Prop_ID = Property.Prop_ID JOIN Location ON Production_Property_Location.Loc_ID = Location.Loc_ID ORDER BY Prod_Name ASC;", dataGridView2);
            Program.showTable(con, "SELECT Prod_Name, St_Name, St_Type FROM Staff_Production JOIN Production ON Staff_Production.Prod_ID = Production.Prod_ID JOIN Staff ON Staff_Production.St_ID = Staff.St_ID ORDER BY Prod_Name ASC;", dataGridView3);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void cmbProdPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProdPPS.SelectedIndex != -1)
            {
                string selectProd = cmbProdPPS.SelectedItem.ToString();

                try
                {
                    con.Open();
                    SqlCommand cl = null;
                    cl = new SqlCommand("SELECT St_Name FROM Staff WHERE St_ID NOT IN (SELECT s.St_ID FROM Staff_Production ps JOIN Staff s ON ps.St_ID = s.St_ID WHERE ps.Prod_ID = (select Prod_ID from Production where Prod_Name = '" + selectProd + "'));", con);
                    SqlDataReader myrecord = cl.ExecuteReader();
                    if (myrecord.HasRows)
                    {
                        cmbStaffPPS.Items.Clear();
                        while (myrecord.Read())
                        {
                            cmbStaffPPS.Items.Add(myrecord["St_Name"]);
                            
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
        }

        private void cmbProdPP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProdPPL.SelectedIndex != -1)
            {
                string selectProd = cmbProdPPL.SelectedItem.ToString();

                try
                {
                    con.Open();
                    SqlCommand cl = null;
                    cl = new SqlCommand("SELECT Prop_Name FROM Property WHERE Prop_ID NOT IN (SELECT s.Prop_ID FROM Production_Property_Location ps JOIN Property s ON ps.Prop_ID = s.Prop_ID WHERE ps.Prod_ID = (select Prod_ID from Production where Prod_Name = '" + selectProd + "'));", con);
                    SqlDataReader myrecord = cl.ExecuteReader();
                    if (myrecord.HasRows)
                    {
                        cmbPropPPL.Items.Clear();
                        while (myrecord.Read())
                        {
                            cmbPropPPL.Items.Add(myrecord["Prop_Name"]);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure to assign this Staff member?","Are you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            // inputs
            string selectProd = cmbProdPPS.SelectedItem.ToString();
            string selectStaff = cmbStaffPPS.SelectedItem.ToString();

            if (DialogResult == DialogResult.Yes && selectProd != "" && selectStaff != "")
            {

                try
                {
                    con.Open();
                    SqlCommand cl = null;
                    cl = new SqlCommand("insert into Staff_Production values ((select Prod_ID from Production where Prod_Name = '" + selectProd + "'),(select St_ID from Staff where St_Name = '" + selectStaff + "'));", con);
                    cl.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
                // load dgvs
                loadDgvs();

                // clear selections in cmbs
                cmbProdPPS.SelectedIndex = -1;
                cmbStaffPPS.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure to assign this Property and Location?","Are you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            string selectedProd = cmbProdPPL.SelectedItem.ToString();
            string selectedProp = cmbPropPPL.SelectedItem.ToString();
            string selectedLoc = cmbLocPPL.SelectedItem.ToString();

            if (DialogResult == DialogResult.Yes && selectedProd != "" && selectedProp != "" && selectedLoc != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cl = null;
                    cl = new SqlCommand("insert into Production_Property_Location values ((select Prod_ID from Production where Prod_Name = '"+selectedProd+"'),(select Prop_ID from Property where Prop_Name = '"+selectedProp+"'),(select Loc_ID from Location where Loc_Name = '"+selectedLoc+"'))", con);
                    cl.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
            }
            // load dgvs
            loadDgvs();
            cmbProdPPL.SelectedIndex = -1;
            cmbPropPPL.Items.Clear();
        }

        private void cmbPropPP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbStaffPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = "Staff";
            string staffName = cmbStaffPPS.SelectedItem.ToString();

            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("select St_Type from Staff where St_Name = '"+staffName+"';", con);
                SqlDataReader myrecord = cl.ExecuteReader();
                if (myrecord.HasRows)
                {
                    while (myrecord.Read())
                    {
                        label8.Text += " / " + myrecord["St_Type"].ToString();

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

        private void txtProdName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
