using System;
using System.Windows.Forms;

namespace App
{
    public partial class Instructor_Form : Form
    {
        public String LoginName { get; set; }

        public Instructor_Form(String LoginName)
        {
            InitializeComponent();
            this.LoginName = LoginName;
            label4.Text = "Welcome " + (LoginName) + " :)";
        }

        private void Instructor_Form_Load(object sender, EventArgs e)
        {
            dgv1.DataSource = Instructor_BizLayer.Get_Instructor(LoginName);
            dgv2.DataSource = Instructor_BizLayer.GetTeach_Courses(LoginName);
            cm_Students.DisplayMember = "Name";
            cm_Students.ValueMember = "Name";
            cm_Students.DataSource = Instructor_BizLayer.GetTeach_Courses(LoginName);
            dgv3.DataSource = Instructor_BizLayer.GetStudent_Course(cm_Students.SelectedValue.ToString(), LoginName);
            txt_name.Text = dgv1.Rows[0].Cells[0].Value.ToString();
            txt_degree.Text = dgv1.Rows[0].Cells[1].Value.ToString();
            txt_pass.Text = dgv1.Rows[0].Cells[2].Value.ToString();
            txt_name.Enabled = false;
            txt_degree.Enabled = false;
            txt_pass.Enabled = false;
            btn_edit.Visible = false;
        }

        private void btn_ins_Click(object sender, EventArgs e)
        {
            dgv3.DataSource = Instructor_BizLayer.GetStudent_Course(cm_Students.SelectedValue.ToString(), LoginName);
        }

        private void dgv1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_name.Enabled = true;
            txt_degree.Enabled = true;
            txt_pass.Enabled = true;
            btn_edit.Visible = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int status = Instructor_BizLayer.Edit_Instructor(txt_name.Text, txt_degree.Text,txt_pass.Text,LoginName);
            if (status > 0)
            {
                txt_name.Enabled = false;
                txt_degree.Enabled = false;
                txt_pass.Enabled = false;
                btn_edit.Visible = false;
                dgv1.DataSource = Instructor_BizLayer.Get_Instructor(LoginName);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Form().Show();
        }

        private void Instructor_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
