using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainInterface
{
    public partial class ConnectionForm : Form
    {
        private SqlConnection conn;
        private string connString;

        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            txtServer.Text = "(local)";
            txtDB.Text = "QLTDBD";
            cbbSecType.SelectedItem = cbbSecType.Items[0];
            txtUN.Enabled = false;
            txtPW.Enabled = false;
        }

        // COMPONENT EVENTS
        private void cbbSecType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSecType.SelectedIndex == 1)
            {
                txtUN.Enabled = true;
                txtPW.Enabled = true;
            }
            else
            {
                txtUN.Enabled = false;
                txtPW.Enabled = false;
            }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            createConnectionString();
            conn = new SqlConnection(connString);
            if(testConnection(conn))
                MessageBox.Show("Connection: OK");
            else
                MessageBox.Show("Connection: FAIL");
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(conn == null)
            {
                createConnectionString();
                conn = new SqlConnection(connString);
            }
            if (!testConnection(conn))
            {
                MessageBox.Show("Something wrong has occured! Fail to set connection to server.");
                return;
            }
            Management mgmt = (Management) Application.OpenForms["Management"];
            if (mgmt != null)
            {
                mgmt.Connection = new SqlConnection(conn.ConnectionString);
                this.Close();
            }
            else
                MessageBox.Show("Something went wrong! Fail to set connection to server.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ADDITIONAL METHODS
        private void createConnectionString()
        {
            string secType = cbbSecType.SelectedIndex == 0
                ? "Integrated Security=SSPI"
                : String.Format("User ID={0};Password={1}", txtUN.Text, txtPW.Text);
            connString = String.Format("Data Source={0};Initial Catalog={1};{2}", txtServer.Text, txtDB.Text, secType);
        }

        private bool testConnection(SqlConnection conn )
        {
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
