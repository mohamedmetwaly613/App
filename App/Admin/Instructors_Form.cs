using System;
using System.Windows.Forms;

namespace App
{
    public partial class Instructors_Form : Form
    {
        public Instructors_Form()
        {
            InitializeComponent();
        }

        private void Instructors_Form_Load(object sender, EventArgs e)
        {
            btn_delete.Visible = false;
            dgv.DataSource = Instructors_BizLayer.Getall_Instructor();
            cm_dept.DisplayMember = "dept_name";
            cm_dept.ValueMember = "dept_id";
            cm_dept.DataSource = Instructors_BizLayer.Getall_Department();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int roweffect = Instructors_BizLayer.Add_Instructor(int.Parse(txt_id.Text), txt_name.Text, txt_degree.Text,float.Parse(txt_salary.Text), int.Parse(cm_dept.SelectedValue.ToString()), txt_user.Text, txt_password.Text);
            if (roweffect > 0)
            {
                dgv.DataSource = Instructors_BizLayer.Getall_Instructor();
                txt_id.Text = txt_name.Text = txt_degree.Text = txt_salary.Text = txt_user.Text = txt_password.Text = "";
            }
        }

        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txt_degree.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            txt_salary.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
            cm_dept.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
            txt_user.Text = dgv.SelectedRows[0].Cells[5].Value.ToString();
            txt_password.Text = dgv.SelectedRows[0].Cells[6].Value.ToString();

            btn_add.Visible = false;
            btn_delete.Visible = true;
            txt_id.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int status = Instructors_BizLayer.Delete_Instructor(int.Parse(txt_id.Text));
            if (status > 0)
            {
                txt_id.Text = txt_name.Text = txt_degree.Text = txt_salary.Text = txt_user.Text = txt_password.Text = "";
                btn_add.Visible = true;
                btn_delete.Visible = false;
                txt_id.Enabled = true;
                dgv.DataSource = Instructors_BizLayer.Getall_Instructor();

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Form().Show();
        }

        private void Instructors_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
