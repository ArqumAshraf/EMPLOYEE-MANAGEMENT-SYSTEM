using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication58
{
    class Employee : LOGIN
    {
        // FACTRY PATTERN( EMPLOYEE CLASS)
        public void login(string a, string b) 
        {
            
          StreamReader sr = new StreamReader("user.txt");
                string line;
                string[] value = new string[7];
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        value = line.Split(',');
                    }
                    if (a == value[1] && b == value[6])
                    {
                        MyInfo info = new MyInfo(a);
                        Login_Factory f1 = new Login_Factory();
                        f1.Hide();
                        info.Show();
                    }
                }
        }

        public void write(Label name, Label e_id, Label age, Label address, Label department, Label salary, Label type, Label fund)
        {

            StreamReader sr = new StreamReader("user.txt");
            string line;
            string[] value = new string[7];
            while ((line = sr.ReadLine()) != null)
            {
                int i;
                for (i = 0; i < value.Length; i++)
                {
                    value = line.Split(',');
                    if (e_id.Text == value[i])
                    {
                        name.Text = value[0];
                        age.Text = value[2];
                        address.Text = value[3];
                        department.Text = value[4];
                        type.Text = value[5];

                        string[] words = File.ReadAllLines("salary.txt");
                        for (int j = 0; j < words.Length; j++)
                        {
                            salary.Text = (words[j + 3]);
                        }



                    }
                }


            }
            sr.Close();
        }
    }
}
