namespace StudentManagement {
    partial class Main {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.lBMainStudents = new System.Windows.Forms.ListBox();
            this.btnMainMoveAtten = new System.Windows.Forms.Button();
            this.editGrade = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBMainStudents
            // 
            this.lBMainStudents.FormattingEnabled = true;
            this.lBMainStudents.ItemHeight = 15;
            this.lBMainStudents.Location = new System.Drawing.Point(14, 48);
            this.lBMainStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lBMainStudents.Name = "lBMainStudents";
            this.lBMainStudents.Size = new System.Drawing.Size(622, 319);
            this.lBMainStudents.TabIndex = 0;
            // 
            // btnMainMoveAtten
            // 
            this.btnMainMoveAtten.Location = new System.Drawing.Point(643, 48);
            this.btnMainMoveAtten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainMoveAtten.Name = "btnMainMoveAtten";
            this.btnMainMoveAtten.Size = new System.Drawing.Size(143, 29);
            this.btnMainMoveAtten.TabIndex = 1;
            this.btnMainMoveAtten.Text = "추가/수정";
            this.btnMainMoveAtten.UseVisualStyleBackColor = true;
            this.btnMainMoveAtten.Click += new System.EventHandler(this.btnMainMoveAtten_Click);
            // 
            // editGrade
            // 
            this.editGrade.Location = new System.Drawing.Point(643, 85);
            this.editGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editGrade.Name = "editGrade";
            this.editGrade.Size = new System.Drawing.Size(143, 29);
            this.editGrade.TabIndex = 1;
            this.editGrade.Text = "성적 관리";
            this.editGrade.UseVisualStyleBackColor = true;
            this.editGrade.Click += new System.EventHandler(this.editGrade_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "출석 관리";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.editAtten_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editGrade);
            this.Controls.Add(this.btnMainMoveAtten);
            this.Controls.Add(this.lBMainStudents);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "학생 정보 관리 시스템";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBMainStudents;
        private System.Windows.Forms.Button btnMainMoveAtten;
        private System.Windows.Forms.Button editGrade;
        private System.Windows.Forms.Button button1;
    }
}

