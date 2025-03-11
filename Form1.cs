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

            cmbAdvisor.Items.AddRange(advisors.Select(a => a.Name).ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_addStd_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string major = tb_department.Text;
            double grade = double.Parse(tb_grade.Text);
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

            lb_id.Text = id;
            lb_name.Text = name;
            lb_major.Text = major;
            lb_grade.Text = grade.ToString();
            lb_advisor.Text = advisor.Name;

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
