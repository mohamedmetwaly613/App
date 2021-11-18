using System;
using System.Windows.Forms;

namespace App
{
    public partial class Course_Form : Form
    {
        public Course_Form()
        {
            InitializeComponent();
        }

        private void Course_Form_Load(object sender, EventArgs e)
        {
            btn_delete.Visible = false;
            btn_update.Visible = false;
            dgv.DataSource = Course_BizLayer.Getall_Course();
            cm_topic.DisplayMember = "top_name";
            cm_topic.ValueMember = "top_id";
            cm_topic.DataSource = Topic_BizLayer.Getall_Topic();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int roweffect = Course_BizLayer.Add_Course(int.Parse(txt_id.Text), txt_name.Text, int.Parse(txt_duration.Text), int.Parse(cm_topic.SelectedValue.ToString()));
                if (roweffect > 0)
                {
                    dgv.DataSource = Course_BizLayer.Getall_Course();
                    txt_name.Text = txt_id.Text = txt_duration.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void dgv_course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txt_duration.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            cm_topic.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();

            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;
            txt_id.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int status = Course_BizLayer.Update_Course(int.Parse(txt_id.Text), txt_name.Text, int.Parse(txt_duration.Text), int.Parse(cm_topic.SelectedValue.ToString()));
            if (status > 0)
            {
                txt_id.Text = txt_name.Text = txt_duration.Text = "";
                btn_add.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;
                txt_id.Enabled = true;
                dgv.DataSource = Course_BizLayer.Getall_Course();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int status = Course_BizLayer.Delete_Course(int.Parse(txt_id.Text));
            if (status > 0)
            {
                txt_id.Text = txt_name.Text = txt_duration.Text = "";
                btn_add.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;
                txt_id.Enabled = true;
                dgv.DataSource = Course_BizLayer.Getall_Course();

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Form().Show();
        }

        private void Course_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
