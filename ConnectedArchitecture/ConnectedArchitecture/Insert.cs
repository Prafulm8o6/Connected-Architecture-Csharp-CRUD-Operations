using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectedArchitecture
{
    public partial class Insert : Form
    {

        private string strConfig = ConfigurationManager.ConnectionStrings["connectedArchitecture"].ToString();

        public Insert()
        {
            InitializeComponent();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(strConfig);

                int srno = Int32.Parse(mtxtRollNo.Text);
                string sname = txtSName.Text;
                string semail = txtEmail.Text;
                DateTime dob = DateTime.Parse(dpDOB.Text);


                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO stud_mst (stud_rno,stud_name,stud_email,stud_dob) VALUES (" + srno + ",'" + sname + "','" + semail + "','" + dob + "')");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Record Inserted Successfully.");

                mtxtRollNo.Clear();
                txtEmail.Clear();
                txtSName.Clear();
                dpDOB.Text = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lnkLblView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            View obj = new View();
            obj.Show();
        }

        private void lnkLblUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Update obj = new Update();
            obj.Show();
        }

        private void lnkLblDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Delete obj = new Delete();
            obj.Show();
        }
    }
}
