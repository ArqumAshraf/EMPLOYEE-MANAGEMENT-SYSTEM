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
    public partial class Login_Factory : Form
    {
        // FACTORY PATTERN
        public Login_Factory()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "ADMIN")
            {
                Admin admin = Admin.getinstance();
                admin.login(textBox1.Text, textBox2.Text);
                
            }


            else if (comboBox1.SelectedItem == "EMPLOYEE")
            {
                Employee emp = new Employee();
                emp.login(textBox1.Text, textBox2.Text);
               
            }
        }
    }
}
