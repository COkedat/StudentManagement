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
            this.btnMainMoveAdd = new System.Windows.Forms.Button();
            this.editGrade = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMainMoveEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBMainStudents
            // 
            this.lBMainStudents.FormattingEnabled = true;
            this.lBMainStudents.ItemHeight = 12;
            this.lBMainStudents.Location = new System.Drawing.Point(12, 38);
            this.lBMainStudents.Name = "lBMainStudents";
            this.lBMainStudents.Size = new System.Drawing.Size(545, 256);
            this.lBMainStudents.TabIndex = 0;
            // 
            // btnMainMoveAdd
            // 
            this.btnMainMoveAdd.Location = new System.Drawing.Point(563, 38);
            this.btnMainMoveAdd.Name = "btnMainMoveAdd";
            this.btnMainMoveAdd.Size = new System.Drawing.Size(125, 23);
            this.btnMainMoveAdd.TabIndex = 1;
            this.btnMainMoveAdd.Text = "추가";
            this.btnMainMoveAdd.UseVisualStyleBackColor = true;
            this.btnMainMoveAdd.Click += new System.EventHandler(this.btnMainMoveAdd_Click);
            // 
            // editGrade
            // 
            this.editGrade.Location = new System.Drawing.Point(563, 125);
            this.editGrade.Name = "editGrade";
            this.editGrade.Size = new System.Drawing.Size(125, 23);
            this.editGrade.TabIndex = 1;
            this.editGrade.Text = "성적 관리";
            this.editGrade.UseVisualStyleBackColor = true;
            this.editGrade.Click += new System.EventHandler(this.editGrade_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "출석 관리";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.editAtten_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(563, 184);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(125, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "추첨";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnMainMoveDraw_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(563, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMainMoveEdit
            // 
            this.btnMainMoveEdit.Location = new System.Drawing.Point(562, 68);
            this.btnMainMoveEdit.Name = "btnMainMoveEdit";
            this.btnMainMoveEdit.Size = new System.Drawing.Size(125, 23);
            this.btnMainMoveEdit.TabIndex = 1;
            this.btnMainMoveEdit.Text = "수정";
            this.btnMainMoveEdit.UseVisualStyleBackColor = true;
            this.btnMainMoveEdit.Click += new System.EventHandler(this.btnMainMoveEdit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editGrade);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMainMoveEdit);
            this.Controls.Add(this.btnMainMoveAdd);
            this.Controls.Add(this.lBMainStudents);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "학생 정보 관리 시스템";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBMainStudents;
        private System.Windows.Forms.Button btnMainMoveAdd;
        private System.Windows.Forms.Button editGrade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMainMoveEdit;
    }
}

