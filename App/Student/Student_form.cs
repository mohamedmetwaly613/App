using System;
using System.Windows.Forms;

namespace App
{
    public partial class Student_form : Form
    {
        public String LoginName { get; set; }

        public Student_form(String LoginName)
        {
            InitializeComponent();
            this.LoginName = LoginName;
            label4.Text = "Welcome " + (LoginName) + " :)";
        }

        private void Student_form_Load(object sender, EventArgs e)
        {
            dgv.DataSource = Student_BizLayer.Getall_Course();
            dgv2.DataSource = Student_BizLayer.GetTaken_Course(LoginName);
            cm_topic.DisplayMember = "top_name";
            cm_topic.ValueMember = "top_id";
            cm_topic.DataSource = Student_BizLayer.Getall_Topic();
            cm_course.DisplayMember = "crs_name";
            cm_course.ValueMember = "crs_id";
            cm_course.DataSource = Student_BizLayer.Add_Course();
            cm_instructor.DisplayMember = "crs_name";
            cm_instructor.ValueMember = "crs_id";
            cm_instructor.DataSource = Student_BizLayer.Add_Course();
            btn_CL_ins.Visible = false;
            btn_clear.Visible = false;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            dgv.DataSource = Student_BizLayer.GetFilter_Course(int.Parse(cm_topic.SelectedValue.ToString()));
            btn_clear.Visible = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dgv.DataSource = Student_BizLayer.Getall_Course();
            btn_CL_ins.Visible = false;
            btn_clear.Visible = false;
        }

        private void btn_Take_Click(object sender, EventArgs e)
        {
            int roweffect = Student_BizLayer.Add_Course(int.Parse(cm_course.SelectedValue.ToString()), Student_BizLayer.Getst_id(LoginName));
            if (roweffect > 0)
            {
                dgv2.DataSource = Student_BizLayer.GetTaken_Course(LoginName);
            }
        }

        private void btn_ins_Click(object sender, EventArgs e)
        {
            dgv.DataSource = Student_BizLayer.Get_course_ins(cm_instructor.Text);
            btn_CL_ins.Visible = true;
        }

        private void btn_CL_ins_Click(object sender, EventArgs e)
        {
            dgv.DataSource = Student_BizLayer.Getall_Course();
            btn_CL_ins.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Form().Show();
        }

        private void Student_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
