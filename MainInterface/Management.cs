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
    public partial class Management : Form
    {
        public SqlConnection Connection { get; set; }
        private SqlDataAdapter adapter;
        private DataTable table;
        private SqlCommandBuilder builder;

        public Management()
        {
            InitializeComponent();

            if (Connection != null)
            {
                adapter = new SqlDataAdapter("select * from giao_vien", Connection);
                table = new DataTable();
            }
        }

        private void Management_Load(object sender, EventArgs e)
        {
            this.Height = 600;
            mainTabs.SelectedIndex = 0;
            if (Connection != null)
            {
                adapter.Fill(table);
                teacherGridView.DataSource = table;
                builder = new SqlCommandBuilder(adapter);
            }
        }

        private void Management_Shown(object sender, EventArgs e)
        {
            if (Connection == null)
                MessageBox.Show("Connection to Database is not set. Please access the Connections menu to setup.", "Warning!");
        }

        private void Management_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["MainForm"].Show();
        }

        // MENU BEHAVIORS
        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionForm conForm = new ConnectionForm();
            conForm.Show();
        }

        private void connectToDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Connection == null)
            {
                MessageBox.Show("Please check your connection configuration again!", "Warning!");
                return;
            }
            updateGridView("default", "create new");
        }

        // TAB BEHAVIORS
        private void mainTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mainTabs.SelectedIndex)
            {
                case 0:
                    this.Height = 600;
                    break;
                case 1:
                    this.Height = 771;
                    try
                    {
                        adapter = new SqlDataAdapter("select * from doi_bong", Connection);
                        table = new DataTable();
                        adapter.Fill(table);
                        var rows = table.Rows;
                        List<String> range = new List<string>();
                        foreach(DataRow row in rows)
                        {
                            range.Add(row["ma_doi"].ToString());
                        }
                        range.Add("All");
                        cbbTeam.Items.AddRange(range.ToArray());
                        cbbTeam.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case 2:
                    this.Height = 560;
                    break;
            }
            if (mainTabs.SelectedTab.Controls.OfType<DataGridView>().First().DataSource == null && mainTabs.SelectedIndex != 1)
                updateGridView("default", "create new");
            else if (mainTabs.SelectedTab.Controls.OfType<DataGridView>().First().DataSource == null && mainTabs.SelectedIndex == 1)
                updateGridView("select ma_sv, ten_sv, sv.lop, doi_bong, so_ao, vai_tro from doi_bong as db join SINH_VIEN as sv on MA_DOI = DOI_BONG", "create new");
            else if(mainTabs.SelectedTab.Controls.OfType<DataGridView>().First().DataSource != null && mainTabs.SelectedIndex != 1)
                updateGridView();
            else
                updateGridView("select ma_sv, ten_sv, sv.lop, doi_bong, so_ao, vai_tro from doi_bong as db join SINH_VIEN as sv on MA_DOI = DOI_BONG");
        }

        // TAB COMPONENT BEHAVIORS
        // GRID VIEW BEHAVIORS
        private void teacherGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (teacherGridView.SelectedRows.Count <= 0)
                return;
            updateTeacherFields("customized");
        }

        private void teamGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (teamGridView.SelectedRows.Count <= 0)
                return;
            updateTeamFields("customized");
        }

        // OTHERS

        private void btnAdd_1_Click(object sender, EventArgs e)
        {
            try
            {
                table.Rows.Add(txtTeacherID.Text, txtTeacherName.Text, txtTeacherPhoneNo.Text);
                adapter.Update(table);
                table.Clear();
                adapter.Fill(table);
                ClearInput(groupBox1, 0);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot proceed this request.");
            }
        }

        private void btnUpdate_1_Click(object sender, EventArgs e)
        {
            int index = teacherGridView.SelectedRows[0].Index;
            DataRow row = table.Rows[index];
            try
            {
                row["ma_gv"] = txtTeacherID.Text;
                row["ten_gv"] = txtTeacherName.Text;
                row["sdt_gv"] = txtTeacherPhoneNo.Text;
                adapter.Update(table);
                table.AcceptChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot proceed this request.");
                row.RejectChanges();
            }
        }

        private void btnDelete_1_Click(object sender, EventArgs e)
        {
            int index = teacherGridView.SelectedRows[0].Index;
            DataRow row = table.Rows[index];
            row.Delete();
            try
            {
                adapter.Update(table);
                table.AcceptChanges();
                ClearInput(groupBox1, 0);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot proceed this request.");
                row.RejectChanges();
            }
        }

        private void btnCommit_1_Click(object sender, EventArgs e)
        {
            var list = table.Rows;
            int i = 0;
            foreach (DataRow row in list)
            {
                MessageBox.Show(row["ten_gv"] + " - " + table.Rows[i]["ten_gv"] + " - " +  row.RowState);
                i++;
            }
        }

        private void cbAutoUpdateDB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoUpdateDB.Checked == true)
            {
                btnUndo_1.Enabled = false;
                btnRedo_1.Enabled = false;
                btnCommit_1.Enabled = false;
            }
            else
            {
                btnUndo_1.Enabled = true;
                btnRedo_1.Enabled = true;
                btnCommit_1.Enabled = true;
            }
        }

        // ADDITIONAL METHODS
        private void updateGridView(string sqlCommand = "default", string require = "none")
        {
            if (Connection == null)
            {
                MessageBox.Show("Connection is not set.", "Warning!");
                return;
            }
            if (sqlCommand.Equals("default"))
            {
                string tableName = null;
                switch (mainTabs.SelectedIndex)
                {
                    case 0:
                        tableName = "giao_vien";
                        break;
                    case 1:
                        tableName = "doi_bong";
                        break;
                    case 2:
                        tableName = "san_bong";
                        break;
                }
                sqlCommand = String.Format("select * from {0}", tableName);
            }
            adapter = new SqlDataAdapter(sqlCommand, Connection);
            if (require.Equals("create new"))
                table = new DataTable();
            else
            {
                table = (DataTable) mainTabs.SelectedTab.Controls.OfType<DataGridView>().First().DataSource;
                table.Clear();
            }

            adapter.Fill(table);

            if (require.Equals("create new"))
            {
                TabPage tabPage = mainTabs.SelectedTab;
                if (tabPage.Controls.ContainsKey(teacherGridView.Name))
                    teacherGridView.DataSource = table;
                else if (tabPage.Controls.ContainsKey(teamGridView.Name))
                    teamGridView.DataSource = table;
                else if (tabPage.Controls.ContainsKey(groundGridView.Name))
                    groundGridView.DataSource = table;
            }
            builder = new SqlCommandBuilder(adapter);
        }

        private void updateTeacherFields(string mode = "default")
        {
            if (mode.Equals("default"))
                teacherGridView.Rows[0].Selected = true;

            var row = teacherGridView.SelectedRows[0];
            
            txtTeacherID.Text = row.Cells[0].Value.ToString();
            txtTeacherName.Text = row.Cells[1].Value.ToString();
            txtTeacherPhoneNo.Text = row.Cells[2].Value.ToString();
        }

        private void updateTeamFields(string mode = "default")
        {
            if (mode.Equals("default"))
                teamGridView.Rows[0].Selected = true;

            var row = teamGridView.SelectedRows[0];

            txtStudentID.Text = row.Cells[0].Value.ToString();
            txtStudentName.Text = row.Cells[1].Value.ToString();
            txtClass.Text = row.Cells[2].Value.ToString();
            txtTeam.Text = row.Cells[3].Value.ToString();
            txtNumber.Text = row.Cells[4].Value.ToString();
            txtRole.Text = row.Cells[5].Value.ToString();
        }
        private void SetAddEnable(bool b, int tabIndex)
        {
            switch (tabIndex)
            {
                case 0:
                    btnAdd_1.Enabled = b;
                    btnUpdate_1.Enabled = btnDelete_1.Enabled = !b;
                    break;
                case 1:
                    btnAdd_2.Enabled = b;
                    btnUpdate_2.Enabled = btnDelete_2.Enabled = !b;
                    break;
                case 2:
                    btnAdd_3.Enabled = b;
                    btnUpdate_3.Enabled = btnDelete_3.Enabled = !b;
                    break;
            }
        }

        private void ClearInput(GroupBox groupBox, int tabIndex)
        {
            var list = groupBox.Controls.OfType<TextBox>();
            foreach (TextBox txtBox in list)
                txtBox.Text = "";
            list.First().Focus();

            groupBox.Parent.Controls.OfType<DataGridView>().First().ClearSelection();
            SetAddEnable(true, tabIndex);
        }
    }
}
