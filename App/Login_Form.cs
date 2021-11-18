using System;
using System.Data;
using System.Windows.Forms;

namespace App
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            this.cm_box.DataSource = new object[3] { "Admin", "Student", "Instructor" };
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            switch (cm_box.SelectedItem.ToString())
            {
                case "Admin":
                    DataTable roweffect = Login_BizLayer.Getall_LoginAdmin(txt_user.Text, txt_password.Text);
                    if (roweffect.Rows.Count > 0)
                    {
                        this.Hide();
                        new Admin_Form().Show();
                    }
                    else
                    {
                        MessageBox.Show("Please enter Correct Username and Password");
                    }
                    break;
                case "Student":
                    roweffect = Login_BizLayer.Getall_LoginStudent(txt_user.Text, txt_password.Text);
                    if (roweffect.Rows.Count > 0)
                    {
                        this.Hide();
                        new Student_form(txt_user.Text).Show();
                    }
                    else
                    {
                        MessageBox.Show("Please enter Correct Username and Password");
                    }
                    break;
                case "Instructor":
                    roweffect = Login_BizLayer.Getall_LoginInstructor(txt_user.Text, txt_password.Text);
                    if (roweffect.Rows.Count > 0)
                    {
                        this.Hide();
                        new Instructor_Form(txt_user.Text).Show();
                    }
                    else
                    {
                        MessageBox.Show("Please enter Correct Username and Password");
                    }
                    break;
                default:
                    break;
            }

        }
    }
}