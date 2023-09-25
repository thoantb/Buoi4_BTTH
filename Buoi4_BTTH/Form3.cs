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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form1 frm1;
        public Model1 dbcontext;
        public Form3(Form1 form1, Model1 dbcontext)
        {
            InitializeComponent();
            this.frm1 = form1;
            this.dbcontext = dbcontext;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            FillFaculty(dbcontext.Faculties.ToList());
        }
        void FillFaculty(List<Faculty> facultyList)
        {
            this.comboBox1.DataSource = facultyList;
            this.comboBox1.DisplayMember = "FacultyName";
            this.comboBox1.ValueMember = "FacultyId";
        }

        private void btnF3Update_Click(object sender, EventArgs e)
        {
            if(txtFindId.Text == "" && txtFindName.Text == "")
            {
                dgvFindStudent.Rows.Clear();
                foreach(var findCbx in dbcontext.Students.ToList())
                {
                    if(findCbx.Faculty.FacultyName == comboBox1.Text)
                    {
                        int index = dgvFindStudent.Rows.Add();
                        dgvFindStudent.Rows[index].Cells[0].Value = findCbx.StudentId;
                        dgvFindStudent.Rows[index].Cells[1].Value = findCbx.FullName;
                        dgvFindStudent.Rows[index].Cells[2].Value = findCbx.Faculty.FacultyName;
                        dgvFindStudent.Rows[index].Cells[3].Value = findCbx.AverageScore;
                    }
                }
            }
            else if(txtFindId.Text == "")
            {
                dgvFindStudent.Rows.Clear();
                foreach (var findCbx in dbcontext.Students.ToList())
                {
                    if ( findCbx.FullName == txtFindName.Text && findCbx.Faculty.FacultyName == comboBox1.Text)
                    {
                        int index = dgvFindStudent.Rows.Add();
                        dgvFindStudent.Rows[index].Cells[0].Value = findCbx.StudentId;
                        dgvFindStudent.Rows[index].Cells[1].Value = findCbx.FullName;
                        dgvFindStudent.Rows[index].Cells[2].Value = findCbx.Faculty.FacultyName;
                        dgvFindStudent.Rows[index].Cells[3].Value = findCbx.AverageScore;
                    }
                }
            }
            else if( txtFindName.Text == "")
            {
                dgvFindStudent.Rows.Clear();
                foreach (var findCbx in dbcontext.Students.ToList())
                {
                    if (findCbx.StudentId == txtFindId.Text && findCbx.Faculty.FacultyName == comboBox1.Text)
                    {
                        int index = dgvFindStudent.Rows.Add();
                        dgvFindStudent.Rows[index].Cells[0].Value = findCbx.StudentId;
                        dgvFindStudent.Rows[index].Cells[1].Value = findCbx.FullName;
                        dgvFindStudent.Rows[index].Cells[2].Value = findCbx.Faculty.FacultyName;
                        dgvFindStudent.Rows[index].Cells[3].Value = findCbx.AverageScore;
                    }
                }
            }
            else
            {
                dgvFindStudent.Rows.Clear();
                foreach (var findCbx in dbcontext.Students.ToList())
                {
                    if (findCbx.FullName == txtFindName.Text && findCbx.StudentId == txtFindId.Text && findCbx.Faculty.FacultyName == comboBox1.Text)
                    {
                        int index = dgvFindStudent.Rows.Add();
                        dgvFindStudent.Rows[index].Cells[0].Value = findCbx.StudentId;
                        dgvFindStudent.Rows[index].Cells[1].Value = findCbx.FullName;
                        dgvFindStudent.Rows[index].Cells[2].Value = findCbx.Faculty.FacultyName;
                        dgvFindStudent.Rows[index].Cells[3].Value = findCbx.AverageScore;
                    }
                }
            }

        }

        private void btnF3Remove_Click(object sender, EventArgs e)
        {

        }
    }
}
