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
            this.btnMainMoveAdd = new System.Windows.Forms.Button();
            this.editGrade = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lVMainStudents = new System.Windows.Forms.ListView();
            this.lV_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lV_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lV_Kor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lV_Eng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lV_Math = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lV_Social = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lV_Sci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lV_Atten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lV_Absent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lV_Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.옵션OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장및불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.만든사람들ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainMoveAdd
            // 
            this.btnMainMoveAdd.Location = new System.Drawing.Point(643, 48);
            this.btnMainMoveAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainMoveAdd.Name = "btnMainMoveAdd";
            this.btnMainMoveAdd.Size = new System.Drawing.Size(143, 29);
            this.btnMainMoveAdd.TabIndex = 1;
            this.btnMainMoveAdd.Text = "추가";
            this.btnMainMoveAdd.UseVisualStyleBackColor = true;
            this.btnMainMoveAdd.Click += new System.EventHandler(this.btnMainMoveAdd_Click);
            // 
            // editGrade
            // 
            this.editGrade.Location = new System.Drawing.Point(643, 159);
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
            this.button1.Location = new System.Drawing.Point(643, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "출석 관리";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.editAtten_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(643, 232);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(143, 29);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "추첨";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnMainMoveDraw_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(643, 122);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lVMainStudents
            // 
            this.lVMainStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lV_Id,
            this.lV_Name,
            this.lV_Kor,
            this.lV_Eng,
            this.lV_Math,
            this.lV_Social,
            this.lV_Sci,
            this.lV_Atten,
            this.lV_Absent,
            this.lV_Group});
            this.lVMainStudents.FullRowSelect = true;
            this.lVMainStudents.GridLines = true;
            this.lVMainStudents.HideSelection = false;
            this.lVMainStudents.Location = new System.Drawing.Point(15, 48);
            this.lVMainStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lVMainStudents.Name = "lVMainStudents";
            this.lVMainStudents.Size = new System.Drawing.Size(622, 377);
            this.lVMainStudents.TabIndex = 2;
            this.lVMainStudents.UseCompatibleStateImageBehavior = false;
            // 
            // lV_Id
            // 
            this.lV_Id.Text = "번호";
            this.lV_Id.Width = 45;
            // 
            // lV_Name
            // 
            this.lV_Name.Text = "이름";
            this.lV_Name.Width = 80;
            // 
            // lV_Kor
            // 
            this.lV_Kor.Text = "국어";
            // 
            // lV_Eng
            // 
            this.lV_Eng.Text = "영어";
            // 
            // lV_Math
            // 
            this.lV_Math.Text = "수학";
            // 
            // lV_Social
            // 
            this.lV_Social.Text = "사회";
            // 
            // lV_Sci
            // 
            this.lV_Sci.Text = "과학";
            // 
            // lV_Atten
            // 
            this.lV_Atten.Text = "출석";
            // 
            // lV_Absent
            // 
            this.lV_Absent.Text = "결석";
            // 
            // lV_Group
            // 
            this.lV_Group.Text = "조";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 85);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "수정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnMainMoveEdit_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(645, 373);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(27, 22);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(645, 401);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(27, 22);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.옵션OToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 옵션OToolStripMenuItem
            // 
            this.옵션OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장및불러오기ToolStripMenuItem,
            this.만든사람들ToolStripMenuItem});
            this.옵션OToolStripMenuItem.Name = "옵션OToolStripMenuItem";
            this.옵션OToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.옵션OToolStripMenuItem.Text = "옵션(&O)";
            // 
            // 저장및불러오기ToolStripMenuItem
            // 
            this.저장및불러오기ToolStripMenuItem.Name = "저장및불러오기ToolStripMenuItem";
            this.저장및불러오기ToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.저장및불러오기ToolStripMenuItem.Text = "저장 및 불러오기(&S)";
            this.저장및불러오기ToolStripMenuItem.Click += new System.EventHandler(this.저장및불러오기ToolStripMenuItem_Click);
            // 
            // 만든사람들ToolStripMenuItem
            // 
            this.만든사람들ToolStripMenuItem.Name = "만든사람들ToolStripMenuItem";
            this.만든사람들ToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.만든사람들ToolStripMenuItem.Text = "만든 사람들(&P)";
            this.만든사람들ToolStripMenuItem.Click += new System.EventHandler(this.만든사람들ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lVMainStudents);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.editGrade);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMainMoveAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "학생 정보 관리 시스템";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMainMoveAdd;
        private System.Windows.Forms.Button editGrade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader lV_Id;
        private System.Windows.Forms.ColumnHeader lV_Name;
        private System.Windows.Forms.ColumnHeader lV_Kor;
        private System.Windows.Forms.ColumnHeader lV_Eng;
        private System.Windows.Forms.ColumnHeader lV_Math;
        private System.Windows.Forms.ColumnHeader lV_Social;
        private System.Windows.Forms.ColumnHeader lV_Sci;
        private System.Windows.Forms.ColumnHeader lV_Atten;
        private System.Windows.Forms.ColumnHeader lV_Absent;
        private System.Windows.Forms.ColumnHeader lV_Group;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 옵션OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장및불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 만든사람들ToolStripMenuItem;
        public System.Windows.Forms.ListView lVMainStudents;
    }
}

