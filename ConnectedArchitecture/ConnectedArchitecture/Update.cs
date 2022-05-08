using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ConnectedArchitecture
{
    public partial class Update : Form
    {

        private string strConfig = ConfigurationManager.ConnectionStrings["connectedArchitecture"].ToString();

        public Update()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strConfig);

                int srno = Int32.Parse(mtxtRollNo.Text);
                string sname = txtSName.Text;
                string semail = txtEmail.Text;
                DateTime dob = DateTime.Parse(dpDOB.Text);

                con.Open();

                SqlCommand findCmd = new SqlCommand("SELECT * FROM stud_mst WHERE stud_rno = " + srno + "");
                findCmd.Connection = con;
                findCmd.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("UPDATE stud_mst SET stud_name = '" + sname + "', stud_email = '" + semail + "', stud_dob = '" + dob + "' WHERE stud_rno = " + srno + "");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Record Updated.");

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
    }
}
