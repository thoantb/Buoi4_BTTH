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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form1 frm1;
        public Model1 dbcontext;
        public Form2(Form1 form1, Model1 dbcontext)
        {
            InitializeComponent();
            this.frm1 = form1;
            this.dbcontext = dbcontext;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BindGridFaculty(frm1.facultys);
        }
        void BindGridFaculty(List<Faculty> faculties)
        {
            dgvFaculty.Rows.Clear();
            foreach (var faculty in faculties)
            {
                int index = dgvFaculty.Rows.Add();
                dgvFaculty.Rows[index].Cells[0].Value = faculty.FacultyId;
                dgvFaculty.Rows[index].Cells[1].Value = faculty.FacultyName;
                dgvFaculty.Rows[index].Cells[2].Value = faculty.TotalProfessor;
            }
        }

        private void btnF2Update_Click(object sender, EventArgs e)
        {
            try
            {
                int totalProf = int.Parse(txtFacultyId.Text);
                Faculty findFaculty = dbcontext.Faculties.FirstOrDefault(p => p.FacultyId == totalProf);
                if(findFaculty != null)
                {
                    findFaculty.FacultyId = int.Parse(txtFacultyId.Text);
                    findFaculty.FacultyName = txtFacultyName.Text;
                    int? total = null;
                    if (!string.IsNullOrEmpty(txtTotalProfessor.Text))
                    {
                        total = int.Parse(txtTotalProfessor.Text);
                    }
                    findFaculty.TotalProfessor = total;
                    dbcontext.SaveChanges();
                    BindGridFaculty(dbcontext.Faculties.ToList());
                    
                }
                else
                {
                    Faculty faculty = new Faculty();
                    faculty.FacultyId = int.Parse(txtFacultyId.Text);
                    faculty.FacultyName = txtFacultyName.Text;
                    int? total = null;
                    if (!string.IsNullOrEmpty(txtTotalProfessor.Text))
                    {
                        total = Convert.ToInt32(txtTotalProfessor.Text);
                    }
                    faculty.TotalProfessor = total; 
                    dbcontext.Faculties.Add(faculty);
                    dbcontext.SaveChanges();
                    BindGridFaculty(dbcontext.Faculties.ToList());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnF2Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int totalProf = int.Parse(txtFacultyId.Text);
                Faculty findFaculty = dbcontext.Faculties.FirstOrDefault(p => p.FacultyId == totalProf);
                {
                    DialogResult dlr = MessageBox.Show("Ban co chac chan muon xoa", "Thong bao", MessageBoxButtons.YesNo);
                    if(dlr == DialogResult.Yes)
                    {
                        dbcontext.Faculties.Remove(findFaculty);
                        dbcontext.SaveChanges();
                        BindGridFaculty(dbcontext.Faculties.ToList());
                    }
                }
            }
            catch(Exception ex ) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
