using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication58
{
    class Delete : Operations
    {
        // STRATEGY PATTERN (DELETE CLASS)
        public void perform(DataGridView dg, TextBox name, TextBox id, TextBox age, TextBox address, TextBox department, ComboBox type, TextBox pass) 
        {
            string a = "";
            foreach (DataGridViewRow item in dg.SelectedRows)
            {
                a = item.Cells[0].Value.ToString();
                dg.Rows.RemoveAt(item.Index);
            }
            StreamReader sr = new StreamReader("user.txt", true);
            StreamWriter sw = new StreamWriter("temp.txt", true);

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(a) == true)
                {

                }
                else
                {
                    sw.WriteLine(line);
                }
            }
            sr.Close();
            sw.Close();
            File.Delete("user.txt");
            File.Move("temp.txt", "user.txt");
            File.Delete("temp.txt");
        
        }

    }
}
