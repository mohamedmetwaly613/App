using System;
using System.Windows.Forms;

namespace App
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
            this.cm_box.DataSource = new object[4] {"Course","Topic","Student", "Instructor"};
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            switch (cm_box.SelectedItem.ToString())
            {
                case "Course":
                    new Course_Form().Show();
                    break;
                case "Topic":
                    new Topic_Form().Show();
                    break;
                case "Student":
                    new Students_Form().Show();
                    break;
                case "Instructor":
                    new Instructors_Form().Show();
                    break;
                default:
                    break;
            }
            
        }

        private void Admin_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
