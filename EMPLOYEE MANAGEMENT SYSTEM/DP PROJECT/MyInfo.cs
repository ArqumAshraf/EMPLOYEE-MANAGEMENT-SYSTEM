using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication58
{
    public partial class MyInfo : Form
    {
        public MyInfo(string eid)
        {
            InitializeComponent();
            label10.Text = eid;
        }

        private void MyInfo_Load(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.write(label9,label10,label11,label12,label13,label14,label15,label16);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] read = File.ReadAllLines("attendance_emp.txt");
            int count = 0;
            int i = 0;
            for (i = 0; i < read.Length; i += 3)
            {
                if (label10.Text == read[i])
                {
                    count++;
                    break;

                }
            }
            if (count > 0)
            {
                listBox1.Items.Add(read[i]);
                listBox1.Items.Add(read[i+1]);
                listBox1.Items.Add(read[i+2]);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] words = File.ReadAllLines("performance.txt");
            for (int i = 0; i < words.Length; i++)
            {
                if (textBox1.Text == words[i])
                {
                    chart1.Series["points"].Points.AddXY(words[i+1], words[i+2]);
                    
                }
            }
        }
    }
}
