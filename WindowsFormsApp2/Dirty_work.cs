using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Dirty_work
    {
        public static  bool pass_string(TextBox s)
        // functia verifica daca valoarea introdusa este diferita de null
        {
            if (s.Text == "")
            {
                s.BackColor = Color.Red;
                MessageBox.Show("Valoarea introdusa: " + s.Text + " nu este introdusa corecta sau lipseste");
                return false;

            }
            return true;

        }

        public static bool pass_number(TextBox s)
        //functia verifica daca valoarea introdusa este diferita de null si este un numar
        {
            bool cond = false;
            int val = 0;
            cond = Int32.TryParse(s.Text, out val);
            if (!cond)
                MessageBox.Show("Valoarea introdusa: " + s.Text + " nu este introdusa corect sau lipseste");
            return cond;
        }
    }
}
