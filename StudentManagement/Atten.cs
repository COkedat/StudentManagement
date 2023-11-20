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
    public partial class Atten : Form {
        Main main;
        
        public Atten() {
            InitializeComponent();
        }
        public Atten(Main main) {
            InitializeComponent();
            this.main = main;
        }
        private void button1_Click(object sender, EventArgs e) {
            // 저장 버튼
            DialogResult dialogResult = MessageBox.Show("출석 결과를 등록하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //OK 클릭할 경우 그냥 진행
            if (dialogResult == DialogResult.OK) {
                for (int i = 0; i < listStudents.Items.Count; i++) {
                    // 해당 학생 출석 시
                    if (listStudents.GetItemChecked(i))
                        main.students[i].AddAtten();
                        
                    // 해당 학생 결석 시
                    else 
                        if(!checkNoAbsent.Checked) main.students[i].AddAbsent();
                }
            }
            //Cancel 클릭 시
            else if (dialogResult == DialogResult.Cancel) {
                return;
            }
            MessageBox.Show("출석 등록이 완료되었습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void button2_Click(object sender, EventArgs e) {
            // 모두 선택
            for (int i = 0; i < listStudents.Items.Count; i++) {
                listStudents.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            // 모두 해제
            for (int i = 0; i < listStudents.Items.Count; i++) {
                listStudents.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void Atten_Load(object sender, EventArgs e) {
            // 해당 창이 로드 될 경우
            // 메인 학생 목록에서 가져옴
            listStudents.Items.Clear();

            foreach (var student in main.students) {
                listStudents.Items.Add(student.Name);
            }
        }
    }
}
