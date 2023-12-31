﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Windows.Forms.VisualStyles;

namespace StudentManagement
{
    public partial class SaveAndLoad : Form
    {
        Main mF;
        public SaveAndLoad(Main mainForm)
        {
            InitializeComponent();
            mF = mainForm;
        }

        private void SaveAndLoad_Load(object sender, EventArgs e)
        {
            List<Student> students;
            string jsonFile = File.ReadAllText("students.json");
            students = JsonSerializer.Deserialize<List<Student>>(jsonFile);

            string temp = " ";
            int index = 1;
            foreach (Student i in students) //json파일의 요소의 번호와 이름을 saveBox에 출력
            {
                temp = index + ". " + i.Name;
                saveBox.Items.Add(temp);
                index++;


                loadBox.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e) //저장
        {
            string fileName;          
            SaveFileDialog saveFileDialoig = new SaveFileDialog();
            saveFileDialoig.FileName = "students_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".json"; //초기 파일명을 지정할 때 사용한다.
            saveFileDialoig.Filter = "json 파일(*.json)|*.json|모든 파일 (*.*)|*.*";

            if (saveFileDialoig.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialoig.FileName;
                StreamWriter sw = new StreamWriter(fileName);
                sw.Write(File.ReadAllText("students.json"));
                sw.Close();
            }
        }

        string jsonFile = ""; //파일선택, 불러오기에서 사용

        private void button2_Click(object sender, EventArgs e) //파일선택
        {
            List<Student> students;      
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "json 파일|*.json";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog.FileName) == ".json")
                {
                    jsonFile = File.ReadAllText(openFileDialog.FileName); //선택한 파일을 읽음
                    students = JsonSerializer.Deserialize<List<Student>>(jsonFile);
                    string temp = " ";
                    int index = 1;
                    foreach (Student i in students) //json파일의 요소의 번호와 이름을 loadBox에 출력
                    {
                        temp = index + ". " + i.Name;
                        loadBox.Items.Add(temp);
                        index++;
                    }
                }
                else //json파일이 아닐때
                    MessageBox.Show("json파일을 선택해주세요!");
            }
        }

        private void load_Click(object sender, EventArgs e) //불러오기
        {
            if (jsonFile != "")
            {
                List<Student> students = JsonSerializer.Deserialize<List<Student>>(jsonFile);
                File.WriteAllText("students.json", jsonFile);
                mF.lVMainStudents.Items.Clear();
                foreach (Student i in students)
                {
                    mF.lVMainStudents.Items.Add(mF.GetListViewStudent(i));
                }
                MessageBox.Show("json 파일을 불러오는데 성공했습니다!","알림",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("먼저 파일을 선택해주세요!");
        }
    }
}
