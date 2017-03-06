namespace MainInterface
{
    partial class Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.TeacherTab = new System.Windows.Forms.TabPage();
            this.cbAutoUpdateDB = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCommit_1 = new System.Windows.Forms.Button();
            this.btnDelete_1 = new System.Windows.Forms.Button();
            this.btnUpdate_1 = new System.Windows.Forms.Button();
            this.btnAdd_1 = new System.Windows.Forms.Button();
            this.btnRedo_1 = new System.Windows.Forms.Button();
            this.btnUndo_1 = new System.Windows.Forms.Button();
            this.teacherGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.txtTeacherPhoneNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TeamTab = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete_2 = new System.Windows.Forms.Button();
            this.btnUpdate_2 = new System.Windows.Forms.Button();
            this.btnAdd_2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.teamGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbTeam = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FootballGroundTab = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete_3 = new System.Windows.Forms.Button();
            this.btnUpdate_3 = new System.Windows.Forms.Button();
            this.btnAdd_3 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.groundGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.TeacherTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.TeamTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.FootballGroundTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groundGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionMenu
            // 
            this.connectionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.connectToDBToolStripMenuItem});
            this.connectionMenu.Name = "connectionMenu";
            this.connectionMenu.Size = new System.Drawing.Size(86, 20);
            this.connectionMenu.Text = "Connections";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.setupToolStripMenuItem.Text = "Setup";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // connectToDBToolStripMenuItem
            // 
            this.connectToDBToolStripMenuItem.Name = "connectToDBToolStripMenuItem";
            this.connectToDBToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.connectToDBToolStripMenuItem.Text = "Connect to DB";
            this.connectToDBToolStripMenuItem.Click += new System.EventHandler(this.connectToDBToolStripMenuItem_Click);
            // 
            // mainTabs
            // 
            this.mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabs.Controls.Add(this.TeacherTab);
            this.mainTabs.Controls.Add(this.TeamTab);
            this.mainTabs.Controls.Add(this.FootballGroundTab);
            this.mainTabs.Location = new System.Drawing.Point(8, 24);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(491, 725);
            this.mainTabs.TabIndex = 1;
            this.mainTabs.SelectedIndexChanged += new System.EventHandler(this.mainTabs_SelectedIndexChanged);
            // 
            // TeacherTab
            // 
            this.TeacherTab.Controls.Add(this.cbAutoUpdateDB);
            this.TeacherTab.Controls.Add(this.button5);
            this.TeacherTab.Controls.Add(this.textBox1);
            this.TeacherTab.Controls.Add(this.label5);
            this.TeacherTab.Controls.Add(this.btnCommit_1);
            this.TeacherTab.Controls.Add(this.btnDelete_1);
            this.TeacherTab.Controls.Add(this.btnUpdate_1);
            this.TeacherTab.Controls.Add(this.btnAdd_1);
            this.TeacherTab.Controls.Add(this.btnRedo_1);
            this.TeacherTab.Controls.Add(this.btnUndo_1);
            this.TeacherTab.Controls.Add(this.teacherGridView);
            this.TeacherTab.Controls.Add(this.groupBox1);
            this.TeacherTab.Controls.Add(this.label1);
            this.TeacherTab.Location = new System.Drawing.Point(4, 22);
            this.TeacherTab.Name = "TeacherTab";
            this.TeacherTab.Padding = new System.Windows.Forms.Padding(3);
            this.TeacherTab.Size = new System.Drawing.Size(483, 699);
            this.TeacherTab.TabIndex = 0;
            this.TeacherTab.Text = "Giáo viên";
            this.TeacherTab.UseVisualStyleBackColor = true;
            // 
            // cbAutoUpdateDB
            // 
            this.cbAutoUpdateDB.AutoSize = true;
            this.cbAutoUpdateDB.Checked = true;
            this.cbAutoUpdateDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoUpdateDB.Location = new System.Drawing.Point(281, 393);
            this.cbAutoUpdateDB.Name = "cbAutoUpdateDB";
            this.cbAutoUpdateDB.Size = new System.Drawing.Size(171, 17);
            this.cbAutoUpdateDB.TabIndex = 11;
            this.cbAutoUpdateDB.Text = "Automatically update database";
            this.cbAutoUpdateDB.UseVisualStyleBackColor = true;
            this.cbAutoUpdateDB.CheckedChanged += new System.EventHandler(this.cbAutoUpdateDB_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(377, 422);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Execute";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SQL Command";
            // 
            // btnCommit_1
            // 
            this.btnCommit_1.Enabled = false;
            this.btnCommit_1.Location = new System.Drawing.Point(306, 457);
            this.btnCommit_1.Name = "btnCommit_1";
            this.btnCommit_1.Size = new System.Drawing.Size(106, 23);
            this.btnCommit_1.TabIndex = 7;
            this.btnCommit_1.Text = "Commit Changes";
            this.btnCommit_1.UseVisualStyleBackColor = true;
            this.btnCommit_1.Click += new System.EventHandler(this.btnCommit_1_Click);
            // 
            // btnDelete_1
            // 
            this.btnDelete_1.Location = new System.Drawing.Point(214, 457);
            this.btnDelete_1.Name = "btnDelete_1";
            this.btnDelete_1.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_1.TabIndex = 7;
            this.btnDelete_1.Text = "Delete";
            this.btnDelete_1.UseVisualStyleBackColor = true;
            this.btnDelete_1.Click += new System.EventHandler(this.btnDelete_1_Click);
            // 
            // btnUpdate_1
            // 
            this.btnUpdate_1.Location = new System.Drawing.Point(121, 457);
            this.btnUpdate_1.Name = "btnUpdate_1";
            this.btnUpdate_1.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate_1.TabIndex = 7;
            this.btnUpdate_1.Text = "Update";
            this.btnUpdate_1.UseVisualStyleBackColor = true;
            this.btnUpdate_1.Click += new System.EventHandler(this.btnUpdate_1_Click);
            // 
            // btnAdd_1
            // 
            this.btnAdd_1.Location = new System.Drawing.Point(29, 457);
            this.btnAdd_1.Name = "btnAdd_1";
            this.btnAdd_1.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_1.TabIndex = 6;
            this.btnAdd_1.Text = "Add";
            this.btnAdd_1.UseVisualStyleBackColor = true;
            this.btnAdd_1.Click += new System.EventHandler(this.btnAdd_1_Click);
            // 
            // btnRedo_1
            // 
            this.btnRedo_1.Enabled = false;
            this.btnRedo_1.Location = new System.Drawing.Point(121, 389);
            this.btnRedo_1.Name = "btnRedo_1";
            this.btnRedo_1.Size = new System.Drawing.Size(75, 23);
            this.btnRedo_1.TabIndex = 5;
            this.btnRedo_1.Text = "Redo";
            this.btnRedo_1.UseVisualStyleBackColor = true;
            // 
            // btnUndo_1
            // 
            this.btnUndo_1.Enabled = false;
            this.btnUndo_1.Location = new System.Drawing.Point(29, 389);
            this.btnUndo_1.Name = "btnUndo_1";
            this.btnUndo_1.Size = new System.Drawing.Size(75, 23);
            this.btnUndo_1.TabIndex = 4;
            this.btnUndo_1.Text = "Undo";
            this.btnUndo_1.UseVisualStyleBackColor = true;
            // 
            // teacherGridView
            // 
            this.teacherGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.teacherGridView.Location = new System.Drawing.Point(6, 135);
            this.teacherGridView.MultiSelect = false;
            this.teacherGridView.Name = "teacherGridView";
            this.teacherGridView.ReadOnly = true;
            this.teacherGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teacherGridView.Size = new System.Drawing.Size(471, 235);
            this.teacherGridView.TabIndex = 3;
            this.teacherGridView.SelectionChanged += new System.EventHandler(this.teacherGridView_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTeacherID);
            this.groupBox1.Controls.Add(this.txtTeacherName);
            this.groupBox1.Controls.Add(this.txtTeacherPhoneNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Location = new System.Drawing.Point(106, 13);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(140, 20);
            this.txtTeacherID.TabIndex = 1;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(106, 50);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(250, 20);
            this.txtTeacherName.TabIndex = 1;
            // 
            // txtTeacherPhoneNo
            // 
            this.txtTeacherPhoneNo.Location = new System.Drawing.Point(106, 86);
            this.txtTeacherPhoneNo.Name = "txtTeacherPhoneNo";
            this.txtTeacherPhoneNo.Size = new System.Drawing.Size(140, 20);
            this.txtTeacherPhoneNo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Giáo Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Giáo Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // TeamTab
            // 
            this.TeamTab.Controls.Add(this.checkBox1);
            this.TeamTab.Controls.Add(this.button6);
            this.TeamTab.Controls.Add(this.textBox2);
            this.TeamTab.Controls.Add(this.label6);
            this.TeamTab.Controls.Add(this.btnDelete_2);
            this.TeamTab.Controls.Add(this.btnUpdate_2);
            this.TeamTab.Controls.Add(this.btnAdd_2);
            this.TeamTab.Controls.Add(this.button9);
            this.TeamTab.Controls.Add(this.button10);
            this.TeamTab.Controls.Add(this.teamGridView);
            this.TeamTab.Controls.Add(this.groupBox2);
            this.TeamTab.Location = new System.Drawing.Point(4, 22);
            this.TeamTab.Name = "TeamTab";
            this.TeamTab.Padding = new System.Windows.Forms.Padding(3);
            this.TeamTab.Size = new System.Drawing.Size(483, 699);
            this.TeamTab.TabIndex = 1;
            this.TeamTab.Text = "Đội bóng";
            this.TeamTab.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(382, 603);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Execute";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 605);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 608);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "SQL Command";
            // 
            // btnDelete_2
            // 
            this.btnDelete_2.Location = new System.Drawing.Point(219, 638);
            this.btnDelete_2.Name = "btnDelete_2";
            this.btnDelete_2.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_2.TabIndex = 16;
            this.btnDelete_2.Text = "Delete";
            this.btnDelete_2.UseVisualStyleBackColor = true;
            // 
            // btnUpdate_2
            // 
            this.btnUpdate_2.Location = new System.Drawing.Point(126, 638);
            this.btnUpdate_2.Name = "btnUpdate_2";
            this.btnUpdate_2.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate_2.TabIndex = 16;
            this.btnUpdate_2.Text = "Update";
            this.btnUpdate_2.UseVisualStyleBackColor = true;
            // 
            // btnAdd_2
            // 
            this.btnAdd_2.Location = new System.Drawing.Point(34, 638);
            this.btnAdd_2.Name = "btnAdd_2";
            this.btnAdd_2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_2.TabIndex = 15;
            this.btnAdd_2.Text = "Add";
            this.btnAdd_2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(126, 570);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = "Redo";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(34, 570);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Undo";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // teamGridView
            // 
            this.teamGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.teamGridView.Location = new System.Drawing.Point(6, 281);
            this.teamGridView.MultiSelect = false;
            this.teamGridView.Name = "teamGridView";
            this.teamGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teamGridView.Size = new System.Drawing.Size(471, 267);
            this.teamGridView.TabIndex = 12;
            this.teamGridView.SelectionChanged += new System.EventHandler(this.teamGridView_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.cbbTeam);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 272);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtStudentID);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtRole);
            this.groupBox4.Controls.Add(this.txtNumber);
            this.groupBox4.Controls.Add(this.txtTeam);
            this.groupBox4.Controls.Add(this.txtClass);
            this.groupBox4.Controls.Add(this.txtStudentName);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(23, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 223);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Sinh Viên";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(92, 19);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(140, 20);
            this.txtStudentID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Sinh Viên";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(92, 184);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(140, 20);
            this.txtRole.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(92, 152);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(140, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(92, 119);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(140, 20);
            this.txtTeam.TabIndex = 1;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(92, 88);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(140, 20);
            this.txtClass.TabIndex = 1;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(92, 55);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(250, 20);
            this.txtStudentName.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Vai Trò";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Số Áo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Đội Bóng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên Sinh Viên";
            // 
            // cbbTeam
            // 
            this.cbbTeam.FormattingEnabled = true;
            this.cbbTeam.Location = new System.Drawing.Point(115, 13);
            this.cbbTeam.Name = "cbbTeam";
            this.cbbTeam.Size = new System.Drawing.Size(140, 21);
            this.cbbTeam.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Đội Bóng";
            // 
            // FootballGroundTab
            // 
            this.FootballGroundTab.Controls.Add(this.checkBox2);
            this.FootballGroundTab.Controls.Add(this.button11);
            this.FootballGroundTab.Controls.Add(this.textBox6);
            this.FootballGroundTab.Controls.Add(this.label10);
            this.FootballGroundTab.Controls.Add(this.btnDelete_3);
            this.FootballGroundTab.Controls.Add(this.btnUpdate_3);
            this.FootballGroundTab.Controls.Add(this.btnAdd_3);
            this.FootballGroundTab.Controls.Add(this.button14);
            this.FootballGroundTab.Controls.Add(this.button15);
            this.FootballGroundTab.Controls.Add(this.groundGridView);
            this.FootballGroundTab.Controls.Add(this.groupBox3);
            this.FootballGroundTab.Location = new System.Drawing.Point(4, 22);
            this.FootballGroundTab.Name = "FootballGroundTab";
            this.FootballGroundTab.Size = new System.Drawing.Size(483, 699);
            this.FootballGroundTab.TabIndex = 2;
            this.FootballGroundTab.Text = "Sân bóng";
            this.FootballGroundTab.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(374, 389);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 19;
            this.button11.Text = "Execute";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(118, 391);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(250, 20);
            this.textBox6.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "SQL Command";
            // 
            // btnDelete_3
            // 
            this.btnDelete_3.Location = new System.Drawing.Point(208, 424);
            this.btnDelete_3.Name = "btnDelete_3";
            this.btnDelete_3.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_3.TabIndex = 16;
            this.btnDelete_3.Text = "Delete";
            this.btnDelete_3.UseVisualStyleBackColor = true;
            // 
            // btnUpdate_3
            // 
            this.btnUpdate_3.Location = new System.Drawing.Point(118, 424);
            this.btnUpdate_3.Name = "btnUpdate_3";
            this.btnUpdate_3.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate_3.TabIndex = 16;
            this.btnUpdate_3.Text = "Update";
            this.btnUpdate_3.UseVisualStyleBackColor = true;
            // 
            // btnAdd_3
            // 
            this.btnAdd_3.Location = new System.Drawing.Point(26, 424);
            this.btnAdd_3.Name = "btnAdd_3";
            this.btnAdd_3.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_3.TabIndex = 15;
            this.btnAdd_3.Text = "Add";
            this.btnAdd_3.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(118, 356);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 14;
            this.button14.Text = "Redo";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(26, 356);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 13;
            this.button15.Text = "Undo";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // groundGridView
            // 
            this.groundGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groundGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groundGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.groundGridView.Location = new System.Drawing.Point(6, 92);
            this.groundGridView.MultiSelect = false;
            this.groundGridView.Name = "groundGridView";
            this.groundGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groundGridView.Size = new System.Drawing.Size(471, 235);
            this.groundGridView.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 83);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(115, 50);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(250, 20);
            this.textBox8.TabIndex = 1;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(115, 13);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(140, 20);
            this.textBox9.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên Sân Bóng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã Sân Bóng";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(289, 574);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(171, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Automatically update database";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(278, 360);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(171, 17);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Automatically update database";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 755);
            this.Controls.Add(this.mainTabs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Management";
            this.Text = "Quản lý dữ liệu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Management_FormClosed);
            this.Load += new System.EventHandler(this.Management_Load);
            this.Shown += new System.EventHandler(this.Management_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTabs.ResumeLayout(false);
            this.TeacherTab.ResumeLayout(false);
            this.TeacherTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TeamTab.ResumeLayout(false);
            this.TeamTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.FootballGroundTab.ResumeLayout(false);
            this.FootballGroundTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groundGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionMenu;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage TeamTab;
        private System.Windows.Forms.TabPage FootballGroundTab;
        private System.Windows.Forms.TabPage TeacherTab;
        private System.Windows.Forms.Button btnUpdate_1;
        private System.Windows.Forms.Button btnAdd_1;
        private System.Windows.Forms.Button btnRedo_1;
        private System.Windows.Forms.Button btnUndo_1;
        private System.Windows.Forms.DataGridView teacherGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTeacherPhoneNo;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate_2;
        private System.Windows.Forms.Button btnAdd_2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView teamGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate_3;
        private System.Windows.Forms.Button btnAdd_3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DataGridView groundGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbTeam;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToDBToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete_1;
        private System.Windows.Forms.Button btnDelete_2;
        private System.Windows.Forms.Button btnDelete_3;
        private System.Windows.Forms.Button btnCommit_1;
        private System.Windows.Forms.CheckBox cbAutoUpdateDB;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

