namespace Assignment_4._2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            studentBindingSource = new BindingSource(components);
            txtFirstName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtGPA = new TextBox();
            txtStudentID = new TextBox();
            label4 = new Label();
            btnAddUpdate = new Button();
            btnDeleteStudent = new Button();
            btnClear = new Button();
            btnSaveInfo = new Button();
            studentIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentFirstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentLastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gPADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentIDDataGridViewTextBoxColumn, studentFirstNameDataGridViewTextBoxColumn, studentLastNameDataGridViewTextBoxColumn, gPADataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(397, 203);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            dataGridView1.SelectionChanged += DisplaySelectedRow;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(486, 12);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(101, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 44);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Last name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 15);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "First name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(486, 41);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(101, 23);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(525, 76);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 5;
            label3.Text = "GPA:";
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(563, 73);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(24, 23);
            txtGPA.TabIndex = 8;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(486, 73);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(24, 23);
            txtStudentID.TabIndex = 6;
            txtStudentID.TextChanged += ChangeAddButton;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 76);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 7;
            label4.Text = "Student ID:";
            // 
            // btnAddUpdate
            // 
            btnAddUpdate.Location = new Point(416, 102);
            btnAddUpdate.Name = "btnAddUpdate";
            btnAddUpdate.Size = new Size(171, 23);
            btnAddUpdate.TabIndex = 9;
            btnAddUpdate.Text = "Add Student";
            btnAddUpdate.UseVisualStyleBackColor = true;
            btnAddUpdate.Click += btnAddUpdate_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(416, 189);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(171, 23);
            btnDeleteStudent.TabIndex = 13;
            btnDeleteStudent.Text = "Delete Selected Student";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(416, 131);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(171, 23);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear Selection and Fields";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.Location = new Point(416, 160);
            btnSaveInfo.Name = "btnSaveInfo";
            btnSaveInfo.Size = new Size(171, 23);
            btnSaveInfo.TabIndex = 12;
            btnSaveInfo.Text = "Save Top GPA Student Info";
            btnSaveInfo.UseVisualStyleBackColor = true;
            btnSaveInfo.Click += btnSaveInfo_Click;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            studentIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            studentIDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            studentIDDataGridViewTextBoxColumn.HeaderText = "Student ID";
            studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            studentIDDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            studentIDDataGridViewTextBoxColumn.Width = 87;
            // 
            // studentFirstNameDataGridViewTextBoxColumn
            // 
            studentFirstNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentFirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            studentFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            studentFirstNameDataGridViewTextBoxColumn.Name = "studentFirstNameDataGridViewTextBoxColumn";
            studentFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentLastNameDataGridViewTextBoxColumn
            // 
            studentLastNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentLastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            studentLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            studentLastNameDataGridViewTextBoxColumn.Name = "studentLastNameDataGridViewTextBoxColumn";
            studentLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gPADataGridViewTextBoxColumn
            // 
            gPADataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            dataGridViewCellStyle1.Format = "N1";
            gPADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            gPADataGridViewTextBoxColumn.HeaderText = "GPA";
            gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            gPADataGridViewTextBoxColumn.ReadOnly = true;
            gPADataGridViewTextBoxColumn.Width = 54;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 226);
            Controls.Add(btnSaveInfo);
            Controls.Add(btnClear);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnAddUpdate);
            Controls.Add(txtStudentID);
            Controls.Add(label4);
            Controls.Add(txtGPA);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Learning Management System";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource studentBindingSource;
        private TextBox txtFirstName;
        private Label label1;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtGPA;
        private TextBox txtStudentID;
        private Label label4;
        private Button btnAddUpdate;
        private Button btnDeleteStudent;
        private Button btnClear;
        private Button btnSaveInfo;
        private DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentFirstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentLastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
    }
}
