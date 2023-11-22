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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

namespace StudentManagement {


    public partial class Main : Form {
        public List<Student> students;
        public Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            students = GetStudents();
            ListViewItem item;
            lVMainStudents.BeginUpdate();

            // 뷰모드 지정
            lVMainStudents.View = View.Details;

            if (students == null) {
                InitializeStudentsJson();                                             // make sample json
                students = GetStudents();
            }

            foreach (var student in students) {
                item = GetListViewStudent(student);
                lVMainStudents.Items.Add(item);
            }
            lVMainStudents.EndUpdate();
        }

        private ListViewItem GetListViewStudent(Student student) {
            // 학생 정보를 리스트뷰 아이템을 변환
            ListViewItem tmpItem = new ListViewItem(student.Id.ToString());
            tmpItem.SubItems.Add(student.Name);
            tmpItem.SubItems.Add(student.Kor.ToString());
            tmpItem.SubItems.Add(student.Eng.ToString());
            tmpItem.SubItems.Add(student.Math.ToString());
            tmpItem.SubItems.Add(student.Social.ToString());
            tmpItem.SubItems.Add(student.Sci.ToString());
            tmpItem.SubItems.Add(student.Atten.ToString());
            tmpItem.SubItems.Add(student.Absent.ToString());
            tmpItem.SubItems.Add(student.Group.ToString());
            return tmpItem;
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

        private void btnMainMoveAdd_Click(object sender, EventArgs e) {
            // 추가 시
            Main_add addForm = new Main_add(ref students, "add");
            addForm.autoUpdate += new Main_add.DataPassEventHandler(autoUpdate);
            addForm.ShowDialog();
        }
        private void btnMainMoveEdit_Click(object sender, EventArgs e) {
            // 수정 시
            // 학생 한명만 선택하도록 함
            if (lVMainStudents.SelectedIndices.Count == 0 || lVMainStudents.SelectedIndices.Count > 1) {
                MessageBox.Show("한 명의 학생을 선택해주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            Student editTarget = students[lVMainStudents.SelectedIndices[0]];

            Console.WriteLine(editTarget);
            Main_add addForm = new Main_add(ref editTarget, "edit");
            addForm.autoUpdate += new Main_add.DataPassEventHandler(autoUpdate);
            addForm.ShowDialog();
        }

        // 정보 변경 시마다 정보를 최신화 시키는 함수
        public void autoUpdate() {
            ListViewItem item;

            // 인덱스 번호를 기준으로 동기화 시킴 ( 인덱스 번호 +1 )
            for (int i=0; i<students.Count; i++) {
                students[i].Id = i + 1;
            }

            // 학생 정보 최신화
            lVMainStudents.BeginUpdate();
            lVMainStudents.Items.Clear();
            foreach (var student in students) {
                item = GetListViewStudent(student);
                lVMainStudents.Items.Add(item);
            }
            lVMainStudents.EndUpdate();

            // 데이터 동기화
            SyncJsonFile();
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

        private void btnMainMoveDraw_Click(object sender, EventArgs e) {
            Draw drawForm = new Draw(this);
            //drawForm.GroupsAssigned += UpdateGroups; //이벤트 핸들러 등록
            drawForm.ShowDialog();
            autoUpdate();
        }

        // 이벤트 핸들러
        private void UpdateGroups(List<Student> updatedStudents) {
            ListViewItem item;
            // 학생들의 조 정보 업데이트
            students = updatedStudents;

            // 학생 정보 최신화
            lVMainStudents.BeginUpdate();
            lVMainStudents.Items.Clear();
            foreach (var student in students) {
                item = GetListViewStudent(student);
                lVMainStudents.Items.Add(item);
            }
            lVMainStudents.EndUpdate();

            // 데이터 동기화
            SyncJsonFile();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (lVMainStudents.SelectedIndices.Count > 0) {
                DialogResult dialogResult = MessageBox.Show("선택된 학생을 목록에서 제거하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                //OK 클릭할 경우 그냥 진행
                if (dialogResult == DialogResult.OK) {
                    // 리스트 뒤집어서 제거해줘야함
                    List<int> tmpList = new List<int>();
                    foreach (int idx in lVMainStudents.SelectedIndices) {tmpList.Add(idx); }
                    tmpList.Reverse();
                    foreach (int idx in tmpList) {
                        students.RemoveAt(idx);
                    }
                    MessageBox.Show("선택된 학생이 목록에서 제거되었습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Cancel 클릭 시
                if (dialogResult == DialogResult.Cancel) {
                    return;
                }
            }
            else { 
                MessageBox.Show("선택된 학생이 없습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            autoUpdate();
        }

        private void SyncJsonFile()
        {
            string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("students.json", json);
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
