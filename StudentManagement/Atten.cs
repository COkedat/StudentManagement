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
        public Atten() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            // 저장 버튼

        }
        private void button2_Click(object sender, EventArgs e) {
            // 모두 선택
            for (int i = 0; i < checkedListBox1.Items.Count; i++) {
                checkedListBox1.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            // 모두 해제
            for (int i = 0; i < checkedListBox1.Items.Count; i++) {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        
    }
}
