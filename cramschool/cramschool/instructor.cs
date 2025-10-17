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
    public partial class instructor : Form
    {
        public instructor()
        {
            InitializeComponent();
            Load1();
        }
        void Load1()
        {
            SqlConnection conn = DB.cramschool();
            SqlCommand cmd = new SqlCommand("SELECT * from instructor", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
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

                SqlConnection conn = DB.cramschool();
                SqlCommand cmd = new SqlCommand("AddInstructor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ist_name ", textBox1.Text);
                cmd.Parameters.AddWithValue("@ist_Lastname", textBox2.Text);
                cmd.Parameters.AddWithValue("@namenumber", textBox5.Text);
                cmd.Parameters.AddWithValue("@mobilenumber", textBox3.Text);
                cmd.Parameters.AddWithValue("@email ", textBox4.Text);

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
            object idObj = dataGridView1.CurrentRow.Cells["ist_id"]?.Value;
            if (idObj == null || idObj == DBNull.Value || !int.TryParse(idObj.ToString(), out int studentId))
            {
                MessageBox.Show("ไม่พบ ist_id ในแถวที่เลือก");
                return;
            }

            using (SqlConnection conn = DB.cramschool())
            using (SqlCommand cmd = new SqlCommand("DelInstructor", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ist_id", SqlDbType.Int).Value = studentId;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox2.Text) ||
               string.IsNullOrWhiteSpace(textBox3.Text) ||
               string.IsNullOrWhiteSpace(textBox4.Text) ||
               string.IsNullOrWhiteSpace(textBox5.Text))
             
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
            int istId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ist_id"].Value);

            using (SqlConnection conn = DB.cramschool())
            {


                using (SqlCommand cmd = new SqlCommand("EditInstructor", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // ส่งพารามิเตอร์ทั้งหมด
                    cmd.Parameters.AddWithValue("@ist_id", istId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ist_name ", textBox1.Text);
                    cmd.Parameters.AddWithValue("@ist_Lastname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@namenumber", textBox5.Text);
                    cmd.Parameters.AddWithValue("@mobilenumber", textBox3.Text);
                    cmd.Parameters.AddWithValue("@email ", textBox4.Text);


                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            MessageBox.Show("แก้ไขข้อมูลนักเรียนสำเร็จ");
            Load1();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is DataRowView drv)
            {
                textBox1.Text = Convert.ToString(drv["ist_name"]);
                textBox2.Text = Convert.ToString(drv["ist_Lastname"]);
                textBox5.Text = Convert.ToString(drv["namenumber"]);
                textBox3.Text = Convert.ToString(drv["mobilenumber"]);
                textBox4.Text = Convert.ToString(drv["email"]);
            }
            else
            {
                MessageBox.Show("กรุณาเลือกแถว หรือ DataSource ไม่ใช่ DataTable");
            }
        }
    }
}
