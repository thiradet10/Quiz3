namespace Quiz3
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();


        public Form1()
        {
            InitializeComponent();
            UpdateStudentList();
            LoadAdvisors();
        }
        private void LoadAdvisors()
        {
            advisors.Add(new Advisor("Dr.Poscy", "CIS"));
            advisors.Add(new Advisor("Dr.Teradat", "ECON"));

            cmbAdvisor.Items.AddRange(advisors.Select(a => a.Name).ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_addStd_Click(object sender, EventArgs e)
        {
            string id = tbId.Text;
            string name = tbName.Text;
            string major = tbDepartment.Text;
            double grade;

            if (!double.TryParse(tbGrade.Text, out grade))
            {
                MessageBox.Show("��سҡ�͡�ô�繵���Ţ��ҹ��");
                return;
            }

            if (cmbAdvisor.SelectedItem == null)
            {
                MessageBox.Show("��س����͡�Ҩ�������֡��");
                return;
            }
            string advisorName = cmbAdvisor.SelectedItem.ToString();
            Advisor advisor = advisors.FirstOrDefault(a => a.Name == advisorName);

            Student student = new Student(id, name, major, grade, advisor);
            students.Add(student);
            advisor.AddStudent(student);

            lbId.Text = student.ID;
            lbName.Text = student.Name;
            lbMajor.Text = student.Major;
            lbGrade.Text = student.Grade.ToString();
            lbAdvisor.Text = student.Advisor.Name;

            UpdateStudentList();
            MessageBox.Show("���������Źѡ�֡�����º����");
            tbId.Clear();
            tbName.Clear();
            tbDepartment.Clear();
            tbGrade.Clear();

        }

        private void btnShowstd_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No students recorded.");
                return;
            }

            Student topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
            MessageBox.Show($"Top Student: {topStudent.Name} Grade: {topStudent.Grade} ");
        }
        private void UpdateStudentList()
        {
            lstStuden.Items.Clear();
            foreach (var student in students)
            {
                lstStuden.Items.Add(student.Name);
            }
        }

        private void lstStuden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStuden.SelectedIndex != -1)
            {
                // �֧���͹ѡ�֡�ҷ��١���͡
                string selectedName = lstStuden.SelectedItem.ToString();

                // ���ҹѡ�֡�ҷ��ç�Ѻ���ͷ�����͡
                Student student = students.FirstOrDefault(s => s.Name == selectedName);

                // ��Ҿ��ѡ�֡�� ����ѻവ������价�� Labels
                if (student != null)
                {
                    lbId.Text = student.ID;
                    lbName.Text = student.Name;
                    lbMajor.Text = student.Major;
                    lbGrade.Text = student.Grade.ToString();
                    lbAdvisor.Text = student.Advisor.Name;
                }
            }
        }

        private void cmbAdvisor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string advisorName = tbNt.Text;
            string advisorDepartment = tbBt.Text;

            if (string.IsNullOrWhiteSpace(advisorName) || string.IsNullOrWhiteSpace(advisorDepartment))
            {
                MessageBox.Show("��سҡ�͡�������Ҩ�������ú��ǹ");
                return;
            }

            Advisor newAdvisor = new Advisor(advisorName, advisorDepartment);
            advisors.Add(newAdvisor);
            cmbAdvisor.Items.Add(newAdvisor.Name);

            MessageBox.Show("�����Ҩ�������º����");
            tbNt.Clear();
            tbBt.Clear();
        }
    }
}
