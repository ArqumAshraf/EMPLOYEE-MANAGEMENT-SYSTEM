using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication58
{
    class Admin : LOGIN
    {
        // FACTRY PATTERN( ADMIN CLASS)
        // SINGLETON PATTERN
        private int e_id = 1234;
        private int pass = 4321;

        

        private Admin() { }

        public static Admin getinstance() 
        {
            Admin admin = new Admin();
            return admin;
        
        }


        public void login(string a , string b) 
        {
            if (Convert.ToInt32(a) == e_id && Convert.ToInt32(b) == pass)
            {
                IVUD iv = new IVUD();
                Login_Factory f1 = new Login_Factory();
                f1.Hide();
                iv.Show();
            }
        }

        
    }
}
