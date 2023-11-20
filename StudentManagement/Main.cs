using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement {


    public partial class Main : Form {
        public List<Student> students;
        public Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            students = GetStudents();

            if (students == null) {
                InitializeStudentsJson();                                             // make sample json
                students = GetStudents();
            }

            foreach (var student in students) {
                lBMainStudents.Items.Add(student.ToString());
            }
        }

        private List<Student> GetStudents() {
            try {
                string jsonFromFile = File.ReadAllText("students.json");            // get some file
                return JsonSerializer.Deserialize<List<Student>>(jsonFromFile);
            }
            catch (Exception ex)                                                    // no file | deserialize failed
            {
                Console.WriteLine($"exception: {ex.Message}");
                return null;
            }
        }

        // students.json 예제 생성기
        private void InitializeStudentsJson() {
            string json;

            List<Student> studentsTemp = new List<Student>
                    {
                        new Student(1, "김종천", 98, 76, 88, 67, 100, 0, 0, 0),
                        new Student(2, "서강민", 87, 65, 52, 74, 47, 0, 0, 0),
                        new Student(3, "강종제", 96, 42, 53, 89, 96, 0, 0, 0),
                        new Student(4, "허상수", 92, 98, 75, 68, 67, 0, 0, 0),
                        new Student(5, "최명조", 100, 76, 96, 62, 23, 0, 0, 0),
                        new Student(6, "김나눔", 22, 4, 34, 29, 14, 0, 0, 0)
                    };

            json = JsonSerializer.Serialize(studentsTemp, new JsonSerializerOptions { WriteIndented = true });

            // save
            File.WriteAllText("students.json", json);
        }

        private void btnMainMoveAtten_Click(object sender, EventArgs e) {
            //Atten attenForm = new Atten();
            //attenForm.Show();
        }

        // 정보 변경 시마다 정보를 최신화 시키는 함수
        private void autoUpdate() {
            // 인덱스 번호를 기준으로 동기화 시킴 ( 인덱스 번호 +1 )
            for (int i=0; i<students.Count; i++) {
                students[i].Id = i + 1;
            }

            // 학생 정보 최신화
            lBMainStudents.Items.Clear();
            foreach (var student in students) {
                lBMainStudents.Items.Add(student.ToString());
            }
        }

        private void editGrade_Click(object sender, EventArgs e) {
            Grade grade = new Grade(this);
            grade.ShowDialog();
            autoUpdate();
        }

        private void editAtten_Click(object sender, EventArgs e) {
            Atten atten = new Atten(this);
            atten.ShowDialog();
            autoUpdate();
        }
    }

    // 학생 클래스
    public class Student {
        public Student() { }
        public Student(int id, string name) {
            this.id = id;
            this.name = name;
        }
        public Student(int id, string name, int kor, int eng, int math, int social, int sci, int atten, int absent, int group) {
            Id = id;
            Name = name;
            Kor = kor;
            Eng = eng;
            Math = math;
            Social = social;
            Sci = sci;
            Atten = atten;
            Absent = absent;
            Group = group;
        }

        // 번호
        private int id;
        // 이름
        private string name;

        // 국영수사과
        private int kor;
        private int eng;
        private int math;
        private int social;
        private int sci;

        // 출석 및 결석 카운트
        private int atten;
        private int absent;

        // 그룹(조) 번호 ( 편성 안되었을 경우 0 )
        private int group;

        // 번호 이름 프로퍼티
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }

        // 점수 프로퍼티
        public int Kor { get { return kor; } set { kor = value; } }
        public int Eng { get { return eng; } set { eng = value; } }
        public int Math { get { return math; } set { math = value; } }
        public int Social { get { return social; } set { social = value; } }
        public int Sci { get { return sci; } set { sci = value; } }

        // 출석 및 결석 프로퍼티
        public int Atten { get { return atten; } set { atten = value; } }
        public int Absent { get { return absent; } set { absent = value; } }

        // 그룹(조) 번호 프로퍼티
        public int Group { get { return group; } set { group = value; } }

        // 출석 결석 증가
        public void AddAtten() {
            Atten++;
        }
        public void AddAbsent() {
            Absent++;
        }
        public override string ToString() {
            return $"{Id}: {Name}, 국어: {Kor}, 영어: {Eng}, 수학: {Math}, 사회: {Social}, 과학: {Sci}, 출석: {Atten}, 결석: {Absent}, 조: {Group}";
        }
    }
}
