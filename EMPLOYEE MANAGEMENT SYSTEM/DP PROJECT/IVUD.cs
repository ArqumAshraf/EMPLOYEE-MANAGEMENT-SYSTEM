using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication58
{
    public partial class IVUD : Form
    {
        public IVUD()
        {
            InitializeComponent();
        }

        // STRATEGY PATTERN 
        private void button4_Click(object sender, EventArgs e)
        {
            Employee_Info emp_info = new Employee_Info(new Insert());
            emp_info.execute_operation(dataGridView1,textBox1,textBox2,textBox3,textBox4,textBox6,comboBox1,textBox5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Info emp_info = new Employee_Info(new View());
            emp_info.execute_operation(dataGridView1, textBox1, textBox2, textBox3, textBox4, textBox6, comboBox1, textBox5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee_Info emp_info = new Employee_Info(new Delete());
            emp_info.execute_operation(dataGridView1, textBox1, textBox2, textBox3, textBox4, textBox6, comboBox1, textBox5);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Employee_Info emp_info = new Employee_Info(new Update());
            emp_info.execute_operation(dataGridView1, textBox1, textBox2, textBox3, textBox4, textBox6, comboBox1, textBox5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login_Factory lf = new Login_Factory();
            this.Hide();
            lf.Show();
        }
        int rowindex;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            DataGridViewRow dgvr = dataGridView1.Rows[rowindex];
            textBox1.Text = dgvr.Cells[0].Value.ToString();
            textBox2.Text = dgvr.Cells[1].Value.ToString();
            textBox3.Text = dgvr.Cells[2].Value.ToString();
            textBox4.Text = dgvr.Cells[3].Value.ToString();
            textBox6.Text = dgvr.Cells[4].Value.ToString();
            comboBox1.SelectedItem = dgvr.Cells[5].Value.ToString();

            textBox5.Text = dgvr.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task t = new Task();
            this.Hide();
            t.Show();
        }
    }
}
