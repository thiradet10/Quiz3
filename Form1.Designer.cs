using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Quiz3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Major = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_id = new TextBox();
            tb_name = new TextBox();
            tb_department = new TextBox();
            tb_grade = new TextBox();
            btn_addStd = new Button();
            btn_showstd = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lb_id = new Label();
            lb_name = new Label();
            lb_major = new Label();
            lb_grade = new Label();
            lb_advisor = new Label();
            cmbAdvisor = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label11 = new Label();
            button1 = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 117);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "StudenID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 78);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "NameSyuden";
            // 
            // Major
            // 
            Major.AutoSize = true;
            Major.Location = new Point(66, 167);
            Major.Name = "Major";
            Major.Size = new Size(48, 20);
            Major.TabIndex = 2;
            Major.Text = "Major";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 210);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Grade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 35);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "Advisor";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(131, 114);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(151, 27);
            tb_id.TabIndex = 5;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(131, 75);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(151, 27);
            tb_name.TabIndex = 6;
            // 
            // tb_department
            // 
            tb_department.Location = new Point(131, 160);
            tb_department.Name = "tb_department";
            tb_department.Size = new Size(151, 27);
            tb_department.TabIndex = 7;
            // 
            // tb_grade
            // 
            tb_grade.Location = new Point(131, 203);
            tb_grade.Name = "tb_grade";
            tb_grade.Size = new Size(151, 27);
            tb_grade.TabIndex = 8;
            // 
            // btn_addStd
            // 
            btn_addStd.Location = new Point(75, 251);
            btn_addStd.Name = "btn_addStd";
            btn_addStd.Size = new Size(217, 35);
            btn_addStd.TabIndex = 10;
            btn_addStd.Text = "AddDataStuden";
            btn_addStd.UseVisualStyleBackColor = true;
            btn_addStd.Click += btn_addStd_Click;
            // 
            // btn_showstd
            // 
            btn_showstd.Location = new Point(429, 278);
            btn_showstd.Name = "btn_showstd";
            btn_showstd.Size = new Size(243, 215);
            btn_showstd.TabIndex = 11;
            btn_showstd.Text = "ShowTopStuden";
            btn_showstd.UseVisualStyleBackColor = true;
            btn_showstd.Click += btn_showstd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 55);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 14;
            label6.Text = "StudenID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 87);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 15;
            label7.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 126);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 16;
            label8.Text = "Major";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 157);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 17;
            label9.Text = "GPA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 192);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 18;
            label10.Text = "Advisor";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(146, 55);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(58, 20);
            lb_id.TabIndex = 19;
            lb_id.Text = "label11";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(146, 87);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(58, 20);
            lb_name.TabIndex = 20;
            lb_name.Text = "label12";
            // 
            // lb_major
            // 
            lb_major.AutoSize = true;
            lb_major.Location = new Point(146, 126);
            lb_major.Name = "lb_major";
            lb_major.Size = new Size(58, 20);
            lb_major.TabIndex = 21;
            lb_major.Text = "label13";
            // 
            // lb_grade
            // 
            lb_grade.AutoSize = true;
            lb_grade.Location = new Point(146, 160);
            lb_grade.Name = "lb_grade";
            lb_grade.Size = new Size(58, 20);
            lb_grade.TabIndex = 22;
            lb_grade.Text = "label14";
            // 
            // lb_advisor
            // 
            lb_advisor.AutoSize = true;
            lb_advisor.Location = new Point(146, 192);
            lb_advisor.Name = "lb_advisor";
            lb_advisor.Size = new Size(58, 20);
            lb_advisor.TabIndex = 23;
            lb_advisor.Text = "label15";
            // 
            // cmbAdvisor
            // 
            cmbAdvisor.FormattingEnabled = true;
            cmbAdvisor.Location = new Point(131, 32);
            cmbAdvisor.Name = "cmbAdvisor";
            cmbAdvisor.Size = new Size(151, 28);
            cmbAdvisor.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_advisor);
            groupBox1.Controls.Add(lb_grade);
            groupBox1.Controls.Add(lb_major);
            groupBox1.Controls.Add(lb_name);
            groupBox1.Controls.Add(lb_id);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(429, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 235);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลนักศึกษา";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbAdvisor);
            groupBox2.Controls.Add(btn_addStd);
            groupBox2.Controls.Add(tb_grade);
            groupBox2.Controls.Add(tb_name);
            groupBox2.Controls.Add(tb_department);
            groupBox2.Controls.Add(tb_id);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(Major);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(68, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 318);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "DataStuden";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 22);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 30;
            label3.Text = "NameTeacher";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 57);
            label11.Name = "label11";
            label11.Size = new Size(114, 20);
            label11.TabIndex = 31;
            label11.Text = "BranchesTaught";
            // 
            // button1
            // 
            button1.Location = new Point(78, 99);
            button1.Name = "button1";
            button1.Size = new Size(217, 35);
            button1.TabIndex = 32;
            button1.Text = "AddDataTeacher";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(65, 340);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(351, 153);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Text = "DataTeacher";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 574);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_showstd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Major;
        private Label label4;
        private Label label5;
        private TextBox tb_id;
        private TextBox tb_name;
        private TextBox tb_department;
        private TextBox tb_grade;
        private Button btn_addStd;
        private Button btn_showstd;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lb_id;
        private Label lb_name;
        private Label lb_major;
        private Label lb_grade;
        private Label lb_advisor;
        private ComboBox cmbAdvisor;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label11;
        private Button button1;
        private GroupBox groupBox3;
    }
}
