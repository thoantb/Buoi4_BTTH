using Buoi4_BTTH.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4_BTTH
{
    public partial class Form1 : Form
    {
        public Form1 form1;
        public Form2 form2;
        public Form3 form3;
        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }


        static Model1 context = new Model1();
        public List<Faculty> facultys = context.Faculties.ToList();
        List<Student> students = context.Students.ToList();

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFaculty.SelectedIndex = 0;
            try
            {
                FillFaculty(facultys);
                BindGrid(students);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FillFaculty(List<Faculty> facultys)
        {
            this.cbFaculty.DataSource = facultys;
            this.cbFaculty.DisplayMember = "FacultyName";
            this.cbFaculty.ValueMember = "FacultyId";
        }
        private void BindGrid(List<Student> students)
        {
            dgvStudent.Rows.Clear();
            foreach (Student student in students)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = student.StudentId;
                dgvStudent.Rows[index].Cells[1].Value = student.FullName;
                dgvStudent.Rows[index].Cells[2].Value = student.AverageScore;
                dgvStudent.Rows[index].Cells[3].Value = student.Faculty.FacultyName;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtStudentId.Text == "" || txtAverageScore.Text == "" || txtFullName.Text == "")
                {
                    throw new Exception("Vui long nhap day du thong tin!");
                }
                else
                {
                    foreach (Student student in students)
                    {
                        if(student.StudentId == txtStudentId.Text)
                        {
                            throw new Exception("Ma so sinh vien da ton tai!");
                        }
                    }
                    Student s = new Student();
                    s.StudentId = txtStudentId.Text;
                    s.FullName = txtFullName.Text;
                    s.FacultyId = (cbFaculty.SelectedItem as Faculty).FacultyId;
                    s.AverageScore = float.Parse(txtAverageScore.Text);
                    context.Students.Add(s);
                    context.SaveChanges();
                    BindGrid(context.Students.ToList());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtStudentId.Text == "" || txtAverageScore.Text == "" || txtFullName.Text == "")
                {
                    throw new Exception("Vui long nhap day du thong tin!");
                }
                else
                {
                    Student findStudent = context.Students.FirstOrDefault(p => p.StudentId == txtStudentId.Text);
                    if(findStudent == null)
                    {
                        MessageBox.Show("Khong tim thay mssv!", "Thong bao", MessageBoxButtons.OK);
                    }
                    else
                    {
                        findStudent.FullName = txtFullName.Text;
                        findStudent.AverageScore = float.Parse(txtAverageScore.Text);
                        findStudent.FacultyId = (cbFaculty.SelectedItem as Faculty).FacultyId;
                        context.SaveChanges();
                        BindGrid(context.Students.ToList());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Student findStudent = context.Students.FirstOrDefault(p => p.StudentId == txtStudentId.Text);
            if (findStudent == null)
            {
                MessageBox.Show("Khong tim thay mssv!", "Thong bao", MessageBoxButtons.OK);
            }
            else
            {
                context.Students.Remove(findStudent);
                context.SaveChanges();
                BindGrid(context.Students.ToList());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvStudent.CurrentRow.Selected = true;
            txtStudentId.Text = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFullName.Text = dgvStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAverageScore.Text = dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbFaculty.Text = dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() == 1)
                Application.OpenForms.OfType<Form2>().First().Close();
            Form2 frm = new Form2(this, context);
            frm.ShowDialog(this);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() == 1)
                Application.OpenForms.OfType<Form2>().First().Close();
            Form2 frm = new Form2(this, context);
            frm.ShowDialog(this);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form3>().Count() == 1)
                Application.OpenForms.OfType<Form3>().First().Close();
            Form3 frm3 = new Form3(this, context);
            frm3.ShowDialog(this);
        }
    }
}
