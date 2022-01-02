using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication58
{
    class Attendance : OTHER_TASK
    {
        // FACADE PATTERN (ATTENDANCE CLASS)
        public void mark_attendance(TextBox id, CheckBox p, DateTimePicker dtp)
        {
            StreamWriter sw = new StreamWriter("attendance_emp.txt");
            if (p.Checked)
            {

                sw.WriteLine(id.Text);
                sw.WriteLine(dtp.Text);
                sw.WriteLine("present");
                sw.Close();
            }
            else
            {

                sw.WriteLine(id.Text);
                sw.WriteLine(dtp.Text);
                sw.WriteLine("absent");
                sw.Close();
            }
        }

        public void salary_calculate(TextBox id, TextBox dept, ComboBox type) 
        {
        
        }

        public void add_pfund(TextBox id , Salary sc)
        {

        }



    }
}
