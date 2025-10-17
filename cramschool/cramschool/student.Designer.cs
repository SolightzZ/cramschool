namespace cramschool
{
    partial class student
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            label10 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(87, 43);
            label1.Name = "label1";
            label1.Size = new Size(38, 23);
            label1.TabIndex = 1;
            label1.Text = "ชื่อ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(315, 43);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 2;
            label2.Text = "นามสกุล :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(121, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(44, 82);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 4;
            label3.Text = "บ้านเลขที่ :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(341, 81);
            label4.Name = "label4";
            label4.Size = new Size(49, 23);
            label4.TabIndex = 5;
            label4.Text = "ถนน :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(69, 119);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 6;
            label5.Text = "ตำบล :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(330, 124);
            label6.Name = "label6";
            label6.Size = new Size(60, 23);
            label6.TabIndex = 7;
            label6.Text = "อำเภอ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(62, 162);
            label7.Name = "label7";
            label7.Size = new Size(63, 23);
            label7.TabIndex = 8;
            label7.Text = "จังหวัด :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(289, 166);
            label8.Name = "label8";
            label8.Size = new Size(101, 23);
            label8.TabIndex = 9;
            label8.Text = "รหัสไปรษณีย์ :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(51, 203);
            label9.Name = "label9";
            label9.Size = new Size(74, 23);
            label9.TabIndex = 10;
            label9.Text = "โทรศัพท์ :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 342);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(854, 264);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(69, 259);
            button3.Name = "button3";
            button3.Size = new Size(132, 48);
            button3.TabIndex = 21;
            button3.Text = "เพิ่ม";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F);
            label10.Location = new Point(423, 300);
            label10.Name = "label10";
            label10.Size = new Size(0, 19);
            label10.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Segoe UI", 13F);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(844, 320);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลผู้เรียน";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(663, 259);
            button2.Name = "button2";
            button2.Size = new Size(132, 48);
            button2.TabIndex = 31;
            button2.Text = "แก้ไข";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(377, 259);
            button1.Name = "button1";
            button1.Size = new Size(132, 48);
            button1.TabIndex = 30;
            button1.Text = "ลบ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 9F);
            textBox9.Location = new Point(121, 199);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(162, 27);
            textBox9.TabIndex = 29;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 9F);
            textBox8.Location = new Point(387, 165);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(162, 27);
            textBox8.TabIndex = 28;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 9F);
            textBox7.Location = new Point(121, 162);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(162, 27);
            textBox7.TabIndex = 27;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 9F);
            textBox6.Location = new Point(387, 123);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(162, 27);
            textBox6.TabIndex = 26;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 9F);
            textBox5.Location = new Point(121, 79);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(162, 27);
            textBox5.TabIndex = 25;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F);
            textBox4.Location = new Point(121, 119);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 27);
            textBox4.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F);
            textBox3.Location = new Point(387, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 27);
            textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F);
            textBox2.Location = new Point(387, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 27);
            textBox2.TabIndex = 22;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 618);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Name = "student";
            Text = "student";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView dataGridView1;
        private Button button3;
        private Label label10;
        private GroupBox groupBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
    }
}