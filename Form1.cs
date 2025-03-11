namespace Quiz3
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();


        public Form1()
        {
            InitializeComponent();
            LoadAdvisors();
        }
        private void LoadAdvisors()
        {
            advisors.Add(new Advisor("Dr.Katy", "Computer Science"));
            advisors.Add(new Advisor("Dr.Binne", "ECON"));
            advisors.Add(new Advisor("Dr.Katy", "Computer Science"));
            advisors.Add(new Advisor("Dr.Binne", "ECON"));

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
            double grade = double.Parse(tbGrade.Text);
            string advisorName = cmbAdvisor.SelectedItem?.ToString();

            Advisor advisor = advisors.FirstOrDefault(a => a.Name == advisorName);
            if (advisor == null)
            {
                MessageBox.Show("Please select a valid advisor.");
                return;
            }

            Student student = new Student(id, name, major, grade, advisor);
            students.Add(student);
            advisor.AddStudent(student);

            lbId.Text = id;
            lbName.Text = name;
            lbMajor.Text = major;
            lbGrade.Text = grade.ToString();
            lbAdvisor.Text = advisor.Name;

            MessageBox.Show("Student added successfully!");
        }

        private void btn_showstd_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No students recorded.");
                return;
            }

            Student topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
            MessageBox.Show($"Top Student: {topStudent.Name} (Grade: {topStudent.Grade})");
        }
    }
}
