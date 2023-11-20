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
    public partial class Grade : Form {
        public Grade() {
            InitializeComponent();
        }
        private void Grade_Load(object sender, EventArgs e) {
            // 해당 창이 로드 될 경우
            // 메인 학생 목록에서 가져옴
            listBox1.Items.Clear();
            Main main = new Main();

            foreach(var student in main.students) {
                listBox1.Items.Add(student.Name);
            }
            
        }
        private void button1_Click(object sender, EventArgs e) {
            // 저장 버튼 클릭시

            // 점수들 중 변경된 점수를 클래스에 저장 (todo)


            // 변경 내역 보고
            label9.Text = "";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            // 리스트박스에서 아무 학생이나 선택 시

            // 저장 버튼 활성화
            button1.Enabled = true;

            // 선택된 학생의 점수들을 텍스트 박스에 저장

        }
    }
}
