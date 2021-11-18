
namespace App
{
    partial class Student_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cm_topic = new System.Windows.Forms.ComboBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cm_course = new System.Windows.Forms.ComboBox();
            this.btn_Take = new System.Windows.Forms.Button();
            this.cm_instructor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ins = new System.Windows.Forms.Button();
            this.btn_CL_ins = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(437, 87);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(484, 309);
            this.dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Courses :";
            // 
            // cm_topic
            // 
            this.cm_topic.FormattingEnabled = true;
            this.cm_topic.Location = new System.Drawing.Point(815, 402);
            this.cm_topic.Name = "cm_topic";
            this.cm_topic.Size = new System.Drawing.Size(106, 23);
            this.cm_topic.TabIndex = 2;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(840, 431);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(81, 23);
            this.btn_filter.TabIndex = 4;
            this.btn_filter.Text = "Apply Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(840, 431);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(81, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear Filter";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter Course By Topic :";
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(12, 87);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.Size = new System.Drawing.Size(198, 213);
            this.dgv2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Courses You Take :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Take Course";
            // 
            // cm_course
            // 
            this.cm_course.FormattingEnabled = true;
            this.cm_course.Location = new System.Drawing.Point(89, 306);
            this.cm_course.Name = "cm_course";
            this.cm_course.Size = new System.Drawing.Size(121, 23);
            this.cm_course.TabIndex = 11;
            // 
            // btn_Take
            // 
            this.btn_Take.Location = new System.Drawing.Point(135, 335);
            this.btn_Take.Name = "btn_Take";
            this.btn_Take.Size = new System.Drawing.Size(75, 23);
            this.btn_Take.TabIndex = 12;
            this.btn_Take.Text = "Enroll Me";
            this.btn_Take.UseVisualStyleBackColor = true;
            this.btn_Take.Click += new System.EventHandler(this.btn_Take_Click);
            // 
            // cm_instructor
            // 
            this.cm_instructor.FormattingEnabled = true;
            this.cm_instructor.Location = new System.Drawing.Point(574, 402);
            this.cm_instructor.Name = "cm_instructor";
            this.cm_instructor.Size = new System.Drawing.Size(97, 23);
            this.cm_instructor.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Show Course Instructor";
            // 
            // btn_ins
            // 
            this.btn_ins.Location = new System.Drawing.Point(590, 431);
            this.btn_ins.Name = "btn_ins";
            this.btn_ins.Size = new System.Drawing.Size(81, 23);
            this.btn_ins.TabIndex = 15;
            this.btn_ins.Text = "Show";
            this.btn_ins.UseVisualStyleBackColor = true;
            this.btn_ins.Click += new System.EventHandler(this.btn_ins_Click);
            // 
            // btn_CL_ins
            // 
            this.btn_CL_ins.Location = new System.Drawing.Point(590, 431);
            this.btn_CL_ins.Name = "btn_CL_ins";
            this.btn_CL_ins.Size = new System.Drawing.Size(81, 23);
            this.btn_CL_ins.TabIndex = 16;
            this.btn_CL_ins.Text = "Clear";
            this.btn_CL_ins.UseVisualStyleBackColor = true;
            this.btn_CL_ins.Click += new System.EventHandler(this.btn_CL_ins_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 431);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 461);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_CL_ins);
            this.Controls.Add(this.btn_ins);
            this.Controls.Add(this.cm_instructor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Take);
            this.Controls.Add(this.cm_course);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.cm_topic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Student_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_form_FormClosed);
            this.Load += new System.EventHandler(this.Student_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cm_topic;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cm_course;
        private System.Windows.Forms.Button btn_Take;
        private System.Windows.Forms.ComboBox cm_instructor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ins;
        private System.Windows.Forms.Button btn_CL_ins;
        private System.Windows.Forms.Button btn_back;
    }
}

