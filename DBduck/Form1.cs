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

namespace DBduck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            int StdID = int.Parse(txtID.Text);
            string StdName = txtName.Text;
            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\C# practical\git\DB gar\DBtest1.mdf';Integrated Security=True;Connect Timeout=30");
            string qry = "INSERT INTO STUDENT VALUES ("+StdID+",'"+StdName+"')";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("INSERT SUCCESSFUL yeeeeeeeeeeeeeee");
            }

            catch(SqlException ex )
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }
    }
}
