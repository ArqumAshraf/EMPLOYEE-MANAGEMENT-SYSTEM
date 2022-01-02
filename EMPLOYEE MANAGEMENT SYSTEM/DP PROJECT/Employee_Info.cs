using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication58
{
    class Employee_Info
    {
        // STRATEGY PATTERN (CONTEXT )
        private Operations operations;

        public Employee_Info(Operations operations) 
        {
            this.operations = operations;
        }

        public void execute_operation(DataGridView dg, TextBox name, TextBox id, TextBox age, TextBox department,TextBox address, ComboBox type, TextBox pass) 
        {
            operations.perform(dg, name, id, age, department, address, type, pass);
            
             

        }

    }
}
