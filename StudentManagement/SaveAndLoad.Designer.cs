namespace StudentManagement
{
    partial class SaveAndLoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveBox = new System.Windows.Forms.ListBox();
            this.loadBox = new System.Windows.Forms.ListBox();
            this.save = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveBox
            // 
            this.saveBox.FormattingEnabled = true;
            this.saveBox.ItemHeight = 12;
            this.saveBox.Location = new System.Drawing.Point(12, 12);
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(176, 280);
            this.saveBox.TabIndex = 0;
            // 
            // loadBox
            // 
            this.loadBox.FormattingEnabled = true;
            this.loadBox.ItemHeight = 12;
            this.loadBox.Location = new System.Drawing.Point(247, 12);
            this.loadBox.Name = "loadBox";
            this.loadBox.Size = new System.Drawing.Size(176, 280);
            this.loadBox.TabIndex = 1;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(63, 298);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "저장";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(247, 298);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 23);
            this.select.TabIndex = 3;
            this.select.Text = "파일선택";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(348, 298);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 4;
            this.load.Text = "불러오기";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // SaveAndLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 331);
            this.Controls.Add(this.load);
            this.Controls.Add(this.select);
            this.Controls.Add(this.save);
            this.Controls.Add(this.loadBox);
            this.Controls.Add(this.saveBox);
            this.Name = "SaveAndLoad";
            this.Text = "SaveAndLoad";
            this.Load += new System.EventHandler(this.SaveAndLoad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox saveBox;
        private System.Windows.Forms.ListBox loadBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button load;
    }
}