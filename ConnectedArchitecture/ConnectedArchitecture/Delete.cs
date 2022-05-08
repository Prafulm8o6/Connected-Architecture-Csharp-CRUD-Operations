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
    public partial class Delete : Form
    {
        private string strConfig = ConfigurationManager.ConnectionStrings["connectedArchitecture"].ToString();

        public Delete()
        {
            InitializeComponent();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strConfig);

                int srno = Int32.Parse(mtxtRollNo.Text);

                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM stud_mst WHERE stud_rno = " + srno + "");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Record Deleted Successfully.");

                mtxtRollNo.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
