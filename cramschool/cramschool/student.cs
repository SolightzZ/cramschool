using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cramschool
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
            Load1();
        }
        void Load1()
        {
            SqlConnection conn = DB.cramschool();
            SqlCommand cmd = new SqlCommand("SELECT * from student", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูล");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูล");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูล");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูล");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูล");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูล");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูล");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูล");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูล");
                return;
            }

            SqlConnection conn = DB.cramschool();
            SqlCommand cmd = new SqlCommand("Addstudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@student_name ", textBox1.Text);
            cmd.Parameters.AddWithValue("@student_lastname", textBox2.Text);
            cmd.Parameters.AddWithValue("@road", textBox3.Text);
            cmd.Parameters.AddWithValue("@district_d", textBox4.Text);
            cmd.Parameters.AddWithValue("@house_number", textBox5.Text);
            cmd.Parameters.AddWithValue("@district_a", textBox6.Text);
            cmd.Parameters.AddWithValue("@Province", textBox7.Text);
            cmd.Parameters.AddWithValue("@zipcode", textBox8.Text);
            cmd.Parameters.AddWithValue("@Phone_number", textBox9.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("เพิ่มข้อมูลผู้เช่าสำเร็จ");
            Load1();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบ");
                return;
            }

            // ดึงค่า student_id จากคอลัมน์ใน Grid
            object idObj = dataGridView1.CurrentRow.Cells["student_id"]?.Value;
            if (idObj == null || idObj == DBNull.Value || !int.TryParse(idObj.ToString(), out int studentId))
            {
                MessageBox.Show("ไม่พบ student_id ในแถวที่เลือก");
                return;
            }

            using (SqlConnection conn = DB.cramschool())
            using (SqlCommand cmd = new SqlCommand("Delstudent", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@student_id", SqlDbType.Int).Value = studentId;

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("ลบข้อมูลนักเรียนสำเร็จ");
            clear();
            Load1();
           

        }

        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox8.Text) ||
                string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการแก้ไขให้ครบทุกช่อง");
                return;
            }

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการแก้ไข");
                return;
            }

            // ✅ ดึงค่า student_id จาก DataGridView
            int studentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["student_id"].Value);

            using (SqlConnection conn = DB.cramschool())
            {
 

                using (SqlCommand cmd = new SqlCommand("Editstudent", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // ส่งพารามิเตอร์ทั้งหมด
                    cmd.Parameters.AddWithValue("@student_id", studentId);
                    cmd.Parameters.AddWithValue("@Phone_number", textBox9.Text);
                    cmd.Parameters.AddWithValue("@zipcode", textBox8.Text);
                    cmd.Parameters.AddWithValue("@house_number", textBox5.Text);
                    cmd.Parameters.AddWithValue("@road", textBox3.Text);
                    cmd.Parameters.AddWithValue("@district_d", textBox4.Text);
                    cmd.Parameters.AddWithValue("@district_a", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Province", textBox7.Text);
                    cmd.Parameters.AddWithValue("@student_name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@student_lastname", textBox2.Text);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            MessageBox.Show("แก้ไขข้อมูลนักเรียนสำเร็จ");
            Load1();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var row = dataGridView1.CurrentRow;

                textBox1.Text = Convert.ToString(row.Cells["student_name"]?.Value);
                textBox2.Text = Convert.ToString(row.Cells["student_lastname"]?.Value);
                textBox3.Text = Convert.ToString(row.Cells["road"]?.Value);
                textBox4.Text = Convert.ToString(row.Cells["district_d"]?.Value);
                textBox5.Text = Convert.ToString(row.Cells["house_number"]?.Value);
                textBox6.Text = Convert.ToString(row.Cells["district_a"]?.Value);
                textBox7.Text = Convert.ToString(row.Cells["Province"]?.Value);
                textBox8.Text = Convert.ToString(row.Cells["zipcode"]?.Value);
                textBox9.Text = Convert.ToString(row.Cells["Phone_number"]?.Value);
            }

        }
    }
}
