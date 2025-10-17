namespace cramschool
{
    partial class searchregister
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
            groupBox1 = new GroupBox();
            txtCourseName1 = new Button();
            label2 = new Label();
            comboBox3 = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvResult1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCourseName1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(845, 114);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "ค้นหาข้อมูลผู้ลงทะเบียนในหลักสูตร";
            // 
            // txtCourseName1
            // 
            txtCourseName1.Location = new Point(420, 49);
            txtCourseName1.Name = "txtCourseName1";
            txtCourseName1.Size = new Size(196, 41);
            txtCourseName1.TabIndex = 34;
            txtCourseName1.Text = "ค้นหาผู้ลงทะเบียน";
            txtCourseName1.UseVisualStyleBackColor = true;
            txtCourseName1.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(320, 57);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 32;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 9F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(102, 59);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(243, 28);
            comboBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 5;
            label3.Text = "ชื่อหลักสูตร";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(6, 60);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvResult1);
            groupBox2.Location = new Point(12, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(845, 448);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "รายละเอียดข้อมูลผู้ลงทะเบียน";
            // 
            // dgvResult1
            // 
            dgvResult1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult1.Location = new Point(6, 26);
            dgvResult1.Name = "dgvResult1";
            dgvResult1.RowHeadersWidth = 51;
            dgvResult1.Size = new Size(833, 405);
            dgvResult1.TabIndex = 30;
            // 
            // searchregister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 592);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "searchregister";
            Text = "searchregister";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResult1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button txtCourseName1;
        private Label label2;
        private ComboBox comboBox3;
        private Label label3;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvResult1;
    }
}