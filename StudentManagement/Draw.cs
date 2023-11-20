using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement {
    public partial class Draw : Form {

        // 이벤트 정의
        public event Action<List<Student>> GroupsAssigned;

        private List<Student> students;
        public Draw(Main main)
        {
            InitializeComponent();
            students = main.students;
        }

        private void Draw_Load(object sender, EventArgs e)
        {
            foreach (var student in students)
            {
                // 각 학생의 번호, 이름, 그룹(조) 번호를 함께 가져오기
                string studentInfo = $"{student.Id}번 {student.Name}, 그룹: {student.Group}";
                listbefore.Items.Add(studentInfo);
            }
        }

        private void listbefore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listafter.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 이벤트 발생
            GroupsAssigned?.Invoke(students);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listafter.Items.Clear(); //초기화 하지 않은 것을 사전에 방지

            if (radioButton1.Checked)
            {
                // radioButton1이 체크된 경우, 무작위로 한 명을 추첨하여 listafter에 추가
                Random random = new Random();
                int randomIndex = random.Next(students.Count);
                Student selectedStudent = students[randomIndex];
                listafter.Items.Add($"추첨 결과: {selectedStudent.Id}번 {selectedStudent.Name}");
            }
            else if (radioButton2.Checked)
            {
                // radioButton2가 체크된 경우, textch1에 있는 숫자만큼의 인원으로 조를 나누어 listafter에 추가
                if (int.TryParse(textch1.Text, out int groupSize))
                {
                    List<List<Student>> groups = DivideIntoGroups(students, groupSize); //학생목록섞기
                    int groupNumber = 1;

                    foreach (var group in groups)
                    {
                        foreach (var student in group)
                        {
                            listafter.Items.Add($"{groupNumber}조 {student.Id}번 {student.Name}");
                            student.Group = groupNumber; //student 클래스의 Group을 뽑힌 조로 변경
                        }

                        groupNumber++;
                    }
                }
                else
                {
                    MessageBox.Show("올바른 숫자를 입력하세요.");
                }
            }
            else if (radioButton3.Checked)
            {
                // radioButton3이 체크된 경우, textch2에 적힌 수만큼 인원을 추첨하여 listafter에 추가
                if (int.TryParse(textch2.Text, out int numberOfWinners))
                {
                    Random random = new Random();
                    for (int i = 0; i < numberOfWinners; i++)
                    {
                        int randomIndex = random.Next(students.Count);
                        Student selectedStudent = students[randomIndex];
                        listafter.Items.Add($"추첨 결과: {selectedStudent.Id}: {selectedStudent.Name}");
                    }
                }
                else
                {
                    MessageBox.Show("올바른 숫자를 입력하세요.");
                }
            }
            else
            {
                MessageBox.Show("라디오 버튼을 선택하세요.");
            }
        }
        private List<List<Student>> DivideIntoGroups(List<Student> students, int groupSize)
        {
            List<List<Student>> groups = new List<List<Student>>();
            List<Student> shuffledStudents = students.OrderBy(x => Guid.NewGuid()).ToList(); // 학생 목록 섞기

            for (int i = 0; i < shuffledStudents.Count; i += groupSize)
            {
                List<Student> group = shuffledStudents.Skip(i).Take(groupSize).ToList();
                groups.Add(group);
            }

            return groups;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listafter.Items.Clear();
            foreach (var student in students)
            {
                student.Group = 0;
                listafter.Items.Add($"{student.Group}조 {student.Id}번 {student.Name}");
            }

        }
    }
}
