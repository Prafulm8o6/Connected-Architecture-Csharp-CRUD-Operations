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
    public partial class View : Form
    {

        private string strConfig = ConfigurationManager.ConnectionStrings["connectedArchitecture"].ToString();

        public View()
        {
            InitializeComponent();
        }


        private void View_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(strConfig);

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM stud_mst", con);

            SqlDataReader dr = cmd.ExecuteReader();

            BindingSource bs = new BindingSource();

            bs.DataSource = dr;

            dataGridView1.DataSource = bs;

            con.Close();

        }
    }
}
