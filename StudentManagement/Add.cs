using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Add : Form
    {

        private Main mainForm;
        private int index;

        public Add(Main mainForm, int index)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.index = index;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 저장 버튼
            mainForm.students.Add(new Student(index, textName.Text));
            mainForm.autoUpdate();
        }
    }
}
