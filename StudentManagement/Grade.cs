﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement {
    public partial class Grade : Form {
        Main main;
        int tmpKor, tmpEng, tmpMath, tmpSocial, tmpSci;
        int selectedIdx;
        public Grade() {
            InitializeComponent();
        }
        public Grade(Main main) {
            InitializeComponent();
            this.main = main;
        }
        private void Grade_Load(object sender, EventArgs e) {
            // 해당 창이 로드 될 경우
            // 메인 학생 목록에서 가져옴
            listStudents.Items.Clear();

            foreach(var student in main.students) {
                listStudents.Items.Add(student.Name);
            }
            
        }
        private void button1_Click(object sender, EventArgs e) {
            // 저장 버튼 클릭시

            // 점수들 중 변경된 점수를 클래스에 저장
            // 변경여부 확인
            if (isChanged()) { // 변경이 있었다면 최신화
                tmpKor = main.students[selectedIdx].Kor = ((int)numericScoreKor.Value);
                tmpEng = main.students[selectedIdx].Eng = ((int)numericScoreEng.Value);
                tmpMath = main.students[selectedIdx].Math = ((int)numericScoreMath.Value);
                tmpSocial = main.students[selectedIdx].Social = ((int)numericScoreSocial.Value);
                tmpSci = main.students[selectedIdx].Sci = ((int)numericScoreSci.Value);

                // 변경 내역 보고
                labelChanged.Text = main.students[selectedIdx].Name + " 학생의 점수가 저장되었습니다.";
            }
            else
                MessageBox.Show("점수 변경 내역이 없습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            // 리스트박스에서 아무 학생이나 선택 시
            selectedIdx = listStudents.SelectedIndex;

            // 저장 버튼 활성화
            btnScoreSave.Enabled = true;

            // 선택된 학생의 점수들을 입력 창에 띄움
            // 임시 점수 변수에도 저장
            numericScoreKor.Value = tmpKor = main.students[selectedIdx].Kor;
            numericScoreEng.Value = tmpEng = main.students[selectedIdx].Eng;
            numericScoreMath.Value = tmpMath= main.students[selectedIdx].Math;
            numericScoreSocial.Value = tmpSocial= main.students[selectedIdx].Social;
            numericScoreSci.Value = tmpSci= main.students[selectedIdx].Sci;

            // 입력 활성화
            numericScoreKor.Enabled = true;
            numericScoreEng.Enabled = true;
            numericScoreMath.Enabled = true;
            numericScoreSocial.Enabled = true;
            numericScoreSci.Enabled = true;
        }

        // 값의 변화가 있었는지 체크하는 함수
        private bool isChanged() {
            // 모두 동일시 false
            if (numericScoreKor.Value == tmpKor &&
                numericScoreEng.Value == tmpEng &&
                numericScoreMath.Value == tmpMath &&
                numericScoreSocial.Value == tmpSocial &&
                numericScoreSci.Value == tmpSci ) 
            return false;

            // 하나라도 차이 있다면 true
            else return true;
        }

    }
}
