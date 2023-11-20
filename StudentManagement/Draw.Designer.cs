namespace StudentManagement {
    partial class Draw {
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
            this.listbefore = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textch1 = new System.Windows.Forms.TextBox();
            this.textch2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.randbtn = new System.Windows.Forms.Button();
            this.listafter = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbefore
            // 
            this.listbefore.FormattingEnabled = true;
            this.listbefore.ItemHeight = 15;
            this.listbefore.Location = new System.Drawing.Point(25, 76);
            this.listbefore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listbefore.Name = "listbefore";
            this.listbefore.Size = new System.Drawing.Size(307, 514);
            this.listbefore.TabIndex = 0;
            this.listbefore.SelectedIndexChanged += new System.EventHandler(this.listbefore_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "학생 명단";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(341, 502);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1명 추첨";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(341, 531);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 19);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "그룹 추첨";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(341, 560);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(113, 19);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "여러 명 추첨";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "인";
            // 
            // textch1
            // 
            this.textch1.Location = new System.Drawing.Point(432, 528);
            this.textch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textch1.Name = "textch1";
            this.textch1.Size = new System.Drawing.Size(25, 25);
            this.textch1.TabIndex = 7;
            // 
            // textch2
            // 
            this.textch2.Location = new System.Drawing.Point(448, 556);
            this.textch2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textch2.Name = "textch2";
            this.textch2.Size = new System.Drawing.Size(25, 25);
            this.textch2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "인";
            // 
            // randbtn
            // 
            this.randbtn.Location = new System.Drawing.Point(247, 599);
            this.randbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.randbtn.Name = "randbtn";
            this.randbtn.Size = new System.Drawing.Size(86, 29);
            this.randbtn.TabIndex = 10;
            this.randbtn.Text = "추첨하기";
            this.randbtn.UseVisualStyleBackColor = true;
            this.randbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listafter
            // 
            this.listafter.FormattingEnabled = true;
            this.listafter.ItemHeight = 15;
            this.listafter.Location = new System.Drawing.Point(491, 76);
            this.listafter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listafter.Name = "listafter";
            this.listafter.Size = new System.Drawing.Size(307, 514);
            this.listafter.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 664);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "닫기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(703, 599);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "목록 초기화";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(26, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "추첨기";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 599);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "그룹 초기화";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 708);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listafter);
            this.Controls.Add(this.randbtn);
            this.Controls.Add(this.textch2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textch1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbefore);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Draw";
            this.Text = "draw";
            this.Load += new System.EventHandler(this.Draw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbefore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textch1;
        private System.Windows.Forms.TextBox textch2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button randbtn;
        private System.Windows.Forms.ListBox listafter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}