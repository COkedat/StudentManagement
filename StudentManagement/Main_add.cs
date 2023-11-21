using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagement
{

    public partial class Main_add : Form
    {
        List<Student> students = null;
        Student editTarget;
        //델리게이트
        public delegate void DataPassEventHandler();

        //이벤트 생성
        public event DataPassEventHandler autoUpdate;

        string mode; // "add" or "edit"
        public Main_add()
        {
            InitializeComponent();
        }
        public Main_add(ref List<Student> data, string mode)
        {
            InitializeComponent();

            students = data;
            this.mode = mode;
        }
        public Main_add(ref Student data, string mode)
        {
            InitializeComponent();

            editTarget = data;
            this.mode = mode;
        }

        private void Main_add_Load(object sender, EventArgs e)
        {
            if(mode == "add")
            {
                int len = students.Count;
                textBox1.Text = (students[len - 1].Id + 1).ToString();
            } else if(mode == "edit")
            {
                textBox1.Text = editTarget.Id.ToString();
                textBox2.Text = editTarget.Name.ToString();
                textBox3.Text = editTarget.Kor.ToString();
                textBox4.Text = editTarget.Eng.ToString();
                textBox5.Text = editTarget.Math.ToString();
                textBox6.Text = editTarget.Social.ToString();
                textBox7.Text = editTarget.Sci.ToString();
                textBox8.Text = editTarget.Atten.ToString();
                textBox9.Text = editTarget.Absent.ToString();
                textBox10.Text = editTarget.Group.ToString();
            }

        }
        private void errorCheck()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("번호을 입력해주세요.", "입력 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요.", "입력 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("국어점수를 입력해주세요.", "입력 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("영어점수를 입력해주세요.", "입력 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("수학점수를 입력해주세요.", "입력 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("사회점수를 입력해주세요.", "입력 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("과학점수를 입력해주세요.", "입력 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox8.Text == "")
            {
                MessageBox.Show("출석을 입력해주세요.", "입력 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox9.Text == "")
            {
                MessageBox.Show("결석을 입력해주세요.", "입력 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox10.Text == "")
            {
                MessageBox.Show("조를 입력해주세요.", "입력 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void add()
        {
            int id = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            int kor = int.Parse(textBox3.Text);
            int eng = int.Parse(textBox4.Text);
            int math = int.Parse(textBox5.Text);
            int social = int.Parse(textBox6.Text);
            int sci = int.Parse(textBox7.Text);
            int atten = int.Parse(textBox8.Text);
            int absent = int.Parse(textBox9.Text);
            int group = int.Parse(textBox10.Text);
            students.Add(new Student(id, name, kor, eng, math, social, sci, atten, absent, group));
        }
        private void edit()
        {
            editTarget.Id = int.Parse(textBox1.Text);
            editTarget.Name = textBox2.Text;
            editTarget.Kor = int.Parse(textBox3.Text);
            editTarget.Eng = int.Parse(textBox4.Text);
            editTarget.Math = int.Parse(textBox5.Text);
            editTarget.Social = int.Parse(textBox6.Text);
            editTarget.Sci = int.Parse(textBox7.Text);
            editTarget.Atten = int.Parse(textBox8.Text);
            editTarget.Absent = int.Parse(textBox9.Text);
            editTarget.Group = int.Parse(textBox10.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            errorCheck();
            if (mode == "add")
            {
                add();
            } else if (mode == "edit")
            {
                edit();
            }
            autoUpdate();
            Application.OpenForms["Main_add"].Close();
        }
    }
}
