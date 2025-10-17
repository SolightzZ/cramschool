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

namespace cramschool
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadRooms();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void LoadRooms()
        {
            SqlConnection conn = DB.cramschool();
            SqlCommand cmd = new SqlCommand("SELECT * FROM register", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBox3.Text))
            //{
            //    MessageBox.Show("กรุณาเลือกข้อมูล");
            //    return;
            //}
            //SqlConnection conn = DB.cramschool();

            //string sql = "SELECT COUNT(*) FROM Room WHERE room_id=@id";
            //SqlCommand cmdCheck = new SqlCommand(checkSql, conn);
            //cmdCheck.Parameters.AddWithValue("@id", textBox3.Text);

        }
    }
}
