using System;
using System.Windows.Forms;

namespace App
{
    public partial class Students_Form : Form
    {
        public Students_Form()
        {
            InitializeComponent();
        }

        private void Students_Form_Load(object sender, EventArgs e)
        {
            btn_delete.Visible = false;
            dgv.DataSource = Students_BizLayer.Getall_Student();
            cm_dept.DisplayMember = "dept_name";
            cm_dept.ValueMember = "dept_id";
            cm_dept.DataSource = Students_BizLayer.Getall_Department();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int roweffect = Students_BizLayer.Add_Student(int.Parse(txt_id.Text), txt_fname.Text, txt_lname.Text, txt_address.Text, int.Parse(txt_age.Text), int.Parse(cm_dept.SelectedValue.ToString()), int.Parse(txt_super.Text), txt_user.Text, txt_password.Text);
            if (roweffect > 0)
            {
                dgv.DataSource = Students_BizLayer.Getall_Student();
                txt_id.Text = txt_fname.Text = txt_lname.Text = txt_address.Text = txt_age.Text = txt_super.Text = txt_user.Text = txt_password.Text = "";
            }
        }

        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
            txt_fname.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txt_lname.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            txt_address.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
            txt_age.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
            cm_dept.Text = dgv.SelectedRows[0].Cells[5].Value.ToString();
            txt_super.Text = dgv.SelectedRows[0].Cells[6].Value.ToString();
            txt_user.Text = dgv.SelectedRows[0].Cells[7].Value.ToString();
            txt_password.Text = dgv.SelectedRows[0].Cells[8].Value.ToString();

            btn_add.Visible = false;
            btn_delete.Visible = true;
            txt_id.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int status = Students_BizLayer.Delete_Student(int.Parse(txt_id.Text));
            if (status > 0)
            {
                txt_id.Text = txt_fname.Text = txt_lname.Text = txt_address.Text = txt_age.Text = txt_super.Text = txt_user.Text = txt_password.Text = "";
                btn_add.Visible = true;
                btn_delete.Visible = false;
                txt_id.Enabled = true;
                dgv.DataSource = Students_BizLayer.Getall_Student();

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Form().Show();
        }

        private void Students_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
