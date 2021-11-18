using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Topic_Form : Form
    {
        public Topic_Form()
        {
            InitializeComponent();
        }

        private void Topic_Form_Load(object sender, EventArgs e)
        {
            btn_delete.Visible = false;
            btn_update.Visible = false;
            dgv.DataSource = Topic_BizLayer.Getall_Topic();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int roweffect = Topic_BizLayer.Add_Topic(int.Parse(txt_id.Text), txt_name.Text);
            if (roweffect > 0)
            {
                dgv.DataSource = Topic_BizLayer.Getall_Topic();
                txt_name.Text = txt_id.Text = "";
            }
        }

        private void dgv_course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();

            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;
            txt_id.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int status = Topic_BizLayer.Update_Topic(int.Parse(txt_id.Text), txt_name.Text);
            if (status > 0)
            {
                txt_id.Text = txt_name.Text = "";
                btn_add.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;
                txt_id.Enabled = true;
                dgv.DataSource = Topic_BizLayer.Getall_Topic();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int status = Topic_BizLayer.Delete_Topic(int.Parse(txt_id.Text));
            if (status > 0)
            {
                txt_id.Text = txt_name.Text = "";
                btn_add.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;
                txt_id.Enabled = true;
                dgv.DataSource = Topic_BizLayer.Getall_Topic();

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Form().Show();
        }

        private void Topic_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
