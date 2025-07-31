using System;
using System.ComponentModel;

namespace Assignment_4._2
{
    public partial class MainForm : Form
    {
        public BindingList<Student> students = Student.PopulateStudents();
        public Dictionary<uint, Student> studentDict = new();
        public MainForm()
        {
            InitializeComponent();

            // Show login screen
            LoginScreen loginForm = new();
            loginForm.ShowDialog();

            // Populate Dictionary
            foreach (Student student in students)
            {
                studentDict.Add(student.ID, student);
            }

            // Bind list to DataGridView
            studentBindingSource.DataSource = students;

            // Allow Add/Update button to be clicked with the "Enter" key
            AcceptButton = btnAddUpdate;
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            // Clear DataGridView selection and textboxes
            btnClear.PerformClick();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            // If fields are empty
            if (String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtStudentID.Text) || String.IsNullOrEmpty(txtGPA.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Missing Information", MessageBoxButtons.OK);
                return;
            }
            else // Check if inputs are valid
            {
                if (IsValidInput())
                {
                    // If Student ID does exist, add student
                    if (!studentDict.ContainsKey(Convert.ToUInt32(txtStudentID.Text)))
                        {
                        // Add new student
                        Student newStudent = new Student() { ID = Convert.ToUInt32(txtStudentID.Text), FirstName = txtFirstName.Text, LastName = txtLastName.Text, GPA = Convert.ToSingle(txtGPA.Text) };
                        students.Add(newStudent);
                        studentDict.Add(newStudent.ID, newStudent);

                        // Set btnAddUpdate to "Update Student"
                        btnAddUpdate.Text = "Update Student";
                    }
                    else // Update student
                    {
                        DialogResult messageBox = MessageBox.Show("Are you sure you want to update the student with this new information?", "Update Confirmation", MessageBoxButtons.YesNo);

                        if (messageBox == DialogResult.Yes)
                        {
                            // Get selected student
                            Student student = studentDict.GetValueOrDefault(Convert.ToUInt32(txtStudentID.Text));

                            // Update student info (except for ID)
                            student.FirstName = txtFirstName.Text;
                            student.LastName = txtLastName.Text;
                            student.GPA = Convert.ToSingle(txtGPA.Text);
                            studentBindingSource.ResetBindings(false);
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear textboxes and dataGridView1 selection
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtStudentID.Text = String.Empty;
            txtGPA.Text = String.Empty;
            dataGridView1.ClearSelection();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            // Save info of student with highest GPA to text file
            float highestGPA = 0;
            Student highestGPAStudent = new();
            string directoryPath = @"..\..\..";
            string fileName = "HighestGPA.txt";
            string fullPath = Path.Combine(directoryPath, fileName);

            // Search for student with highest GPA
            foreach (Student student in studentDict.Values)
            {
                if (student.GPA > highestGPA)
                {
                    highestGPA = student.GPA;
                    highestGPAStudent = student;
                }
            }

            // Write student info to file
            try
            {
                using (StreamWriter writer = new(fullPath))
                {
                    writer.WriteLine($"Student ID: {highestGPAStudent.ID}");
                    writer.WriteLine($"First name: {highestGPAStudent.FirstName}");
                    writer.WriteLine($"Last name: {highestGPAStudent.LastName}");
                    writer.WriteLine($"GPA: {highestGPAStudent.GPA}");
                }
            }
            catch
            {
                MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OK);
            }

            // Display student info in MessageBox (also testing that it wrote the file correctly)
            try
            {
                using (StreamReader reader = new(fullPath))
                {
                    MessageBox.Show($"{highestGPAStudent.FirstName} {highestGPAStudent.LastName} had the highest GPA. " +
                        $"\n\nThe following information was written to {fileName}:\n\n" + reader.ReadToEnd(),
                        "Highest GPA",MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            // Delete selected student

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult messageBox = MessageBox.Show("Are you sure you want to delete this student?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (messageBox == DialogResult.Yes)
                {
                    // Get Student ID of selected student
                    uint studentID = Convert.ToUInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                    // Remove student from both BindingList and Dictionary                
                    students.Remove(studentDict.GetValueOrDefault(studentID));
                    studentDict.Remove(studentID);
                }
            }
        }

        private bool IsValidInput()
        {
            // Check that all fields are filled out
            if (String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtStudentID.Text) || String.IsNullOrEmpty(txtGPA.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Missing Information", MessageBoxButtons.OK);
                return false;
            }

            // Check that Student ID is a uint and does not already exist
            if (!UInt32.TryParse(txtStudentID.Text, out uint studentID))
            //{
            //    if (studentDict.ContainsKey(studentID))
            //    {
            //        MessageBox.Show("Student ID already exists.", "Error", MessageBoxButtons.OK);
            //        return false;
            //    }
            //}
            //else
            {
                MessageBox.Show("Student ID must be a positive integer value.", "Error", MessageBoxButtons.OK);
                return false;
            }

            // Check that GPA is a positive number

            if (!Single.TryParse(txtGPA.Text, out float studentGPA) || studentGPA < 0)
            {
                MessageBox.Show("GPA must be a positive number.", "Error", MessageBoxButtons.OK);
                return false;
            }

            // If all conditions pass
            return true;
        }

        private void DisplaySelectedRow(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            // Get Student ID of selected student
            uint studentID = Convert.ToUInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            // Get selected student
            Student student = studentDict.GetValueOrDefault(studentID);

            // Display student info in textboxes
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtStudentID.Text = student.ID.ToString();
            txtGPA.Text = student.GPA.ToString("N1");
        }

        private void ChangeAddButton(object sender, EventArgs e)
        {
            uint.TryParse(txtStudentID.Text, out uint studentID);
            if (!studentDict.ContainsKey(studentID) || String.IsNullOrEmpty(txtStudentID.Text))
                btnAddUpdate.Text = "Add Student";
            else
            {
                btnAddUpdate.Text = "Update Student";
                Student student = studentDict.GetValueOrDefault(Convert.ToUInt32(txtStudentID.Text));
                dataGridView1.Rows[students.IndexOf(student)].Selected = true;
            }
        }
    }
}
