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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void ขอมลผสอนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instructor instructor = new instructor();
            instructor.Show();
        }

        private void ขอมลหลกสตรToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crouse crouse = new crouse();
            crouse.Show();
        }

        private void ขอมลหมเรยนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studygroup studygroup = new studygroup();
            studygroup.Show();
        }

        private void ขอมลผเรยนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student student = new student();
            student.Show();
        }

        private void ขอมลการลงทะเบยนเรยนในหมเรยนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void รายละเอยดหลกสตรToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchcrouse searchcrouse = new searchcrouse();
            searchcrouse.Show();
        }

        private void รายละเอยดหมเรยนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchstudygroup searchstudygroup = new searchstudygroup();
            searchstudygroup.Show();

        }

        private void ขอมลผเรยนToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            searchstudent searchstudent = new searchstudent();
            searchstudent.Show();
        }

        private void ขอมลผลงทะเบยนเรยนแตละหลกสตรToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchregister searchregister = new searchregister();
            searchregister.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            
        }

        private void ขอมลผเรยนทสำเรจในหลกสตรToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
