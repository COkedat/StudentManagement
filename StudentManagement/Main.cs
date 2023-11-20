using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement {

    
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void save_Click(object sender, EventArgs e) {
            // 학생 정보 저장 버튼

        }

        private void load_Click(object sender, EventArgs e) {
            // 학생 정보 불러오기 버튼
            string jsonFromFile = File.ReadAllText("students.json");

            // deserialize
            List<Student> studentsFromJson = JsonSerializer.Deserialize<List<Student>>(jsonFromFile);

            foreach (var student in studentsFromJson) {
                Console.WriteLine($"번호: {student.Id}, 이름: {student.Name}, 국어: {student.Kor}, 영어: {student.Eng}, 수학: {student.Math}, 사회: {student.Social}, 과학: {student.Sci}, 출석: {student.Atten}, 결석: {student.Absent}, 조: {student.Group}");
            }
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

    }
    



}
