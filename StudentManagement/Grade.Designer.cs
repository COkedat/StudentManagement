namespace StudentManagement {
    partial class Grade {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScoreSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericScoreSci = new System.Windows.Forms.NumericUpDown();
            this.numericScoreSocial = new System.Windows.Forms.NumericUpDown();
            this.numericScoreMath = new System.Windows.Forms.NumericUpDown();
            this.numericScoreEng = new System.Windows.Forms.NumericUpDown();
            this.numericScoreKor = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelChanged = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericScoreSci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScoreSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScoreMath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScoreEng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScoreKor)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listStudents
            // 
            this.listStudents.FormattingEnabled = true;
            this.listStudents.ItemHeight = 15;
            this.listStudents.Location = new System.Drawing.Point(23, 43);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(165, 469);
            this.listStudents.TabIndex = 0;
            this.listStudents.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "학생 목록";
            // 
            // btnScoreSave
            // 
            this.btnScoreSave.Enabled = false;
            this.btnScoreSave.Location = new System.Drawing.Point(48, 211);
            this.btnScoreSave.Name = "btnScoreSave";
            this.btnScoreSave.Size = new System.Drawing.Size(75, 23);
            this.btnScoreSave.TabIndex = 2;
            this.btnScoreSave.Text = "저장";
            this.btnScoreSave.UseVisualStyleBackColor = true;
            this.btnScoreSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "국어";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "영어";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "수학";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "사회";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "과학";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericScoreSci);
            this.panel1.Controls.Add(this.numericScoreSocial);
            this.panel1.Controls.Add(this.numericScoreMath);
            this.panel1.Controls.Add(this.numericScoreEng);
            this.panel1.Controls.Add(this.numericScoreKor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnScoreSave);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(205, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 244);
            this.panel1.TabIndex = 5;
            // 
            // numericScoreSci
            // 
            this.numericScoreSci.Enabled = false;
            this.numericScoreSci.Location = new System.Drawing.Point(57, 173);
            this.numericScoreSci.Name = "numericScoreSci";
            this.numericScoreSci.Size = new System.Drawing.Size(95, 25);
            this.numericScoreSci.TabIndex = 6;
            // 
            // numericScoreSocial
            // 
            this.numericScoreSocial.Enabled = false;
            this.numericScoreSocial.Location = new System.Drawing.Point(57, 142);
            this.numericScoreSocial.Name = "numericScoreSocial";
            this.numericScoreSocial.Size = new System.Drawing.Size(95, 25);
            this.numericScoreSocial.TabIndex = 6;
            // 
            // numericScoreMath
            // 
            this.numericScoreMath.Enabled = false;
            this.numericScoreMath.Location = new System.Drawing.Point(57, 112);
            this.numericScoreMath.Name = "numericScoreMath";
            this.numericScoreMath.Size = new System.Drawing.Size(95, 25);
            this.numericScoreMath.TabIndex = 6;
            // 
            // numericScoreEng
            // 
            this.numericScoreEng.Enabled = false;
            this.numericScoreEng.Location = new System.Drawing.Point(57, 82);
            this.numericScoreEng.Name = "numericScoreEng";
            this.numericScoreEng.Size = new System.Drawing.Size(95, 25);
            this.numericScoreEng.TabIndex = 6;
            // 
            // numericScoreKor
            // 
            this.numericScoreKor.Enabled = false;
            this.numericScoreKor.Location = new System.Drawing.Point(57, 52);
            this.numericScoreKor.Name = "numericScoreKor";
            this.numericScoreKor.Size = new System.Drawing.Size(95, 25);
            this.numericScoreKor.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(7, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "학생 점수";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "변경사항";
            // 
            // labelChanged
            // 
            this.labelChanged.AutoSize = true;
            this.labelChanged.Location = new System.Drawing.Point(205, 417);
            this.labelChanged.Name = "labelChanged";
            this.labelChanged.Size = new System.Drawing.Size(0, 15);
            this.labelChanged.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 58);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 15);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "이름";
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(61, 53);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 25);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.Text = " ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(205, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 91);
            this.panel2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(7, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 28);
            this.label9.TabIndex = 5;
            this.label9.Text = "학생 정보";
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelChanged);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listStudents);
            this.Name = "Grade";
            this.Text = "성적 관리";
            this.Load += new System.EventHandler(this.Grade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericScoreSci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScoreSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScoreMath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScoreEng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScoreKor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScoreSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelChanged;
        private System.Windows.Forms.NumericUpDown numericScoreSci;
        private System.Windows.Forms.NumericUpDown numericScoreSocial;
        private System.Windows.Forms.NumericUpDown numericScoreMath;
        private System.Windows.Forms.NumericUpDown numericScoreEng;
        private System.Windows.Forms.NumericUpDown numericScoreKor;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
    }
}