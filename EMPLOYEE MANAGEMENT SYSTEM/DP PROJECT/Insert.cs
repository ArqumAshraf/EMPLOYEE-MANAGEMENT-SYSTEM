using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication58
{
    class Insert : Operations
    {
        // STRATEGY PATTERN (INSERT CLASS)
        public void perform(DataGridView dg, TextBox name, TextBox id, TextBox age, TextBox department, TextBox address, ComboBox type, TextBox pass) 
        {
            StreamWriter sw = new StreamWriter("user.txt", true);
            sw.WriteLine(name.Text + "," + id.Text + "," + age.Text + "," + department.Text + "," + address.Text + "," + type.SelectedItem + "," + pass.Text);
            sw.Close();
            MessageBox.Show("information has been inserted");
            name.Text = null;
            id.Text = null;
            age.Text = null;
            address.Text = null;
            department.Text = null;
            type.SelectedItem = null;
            pass.Text = null;
        
        }

    }
}
