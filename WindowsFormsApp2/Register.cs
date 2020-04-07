using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Register : Form
    {
        private static string CONNECTION_STRING = "Data Source=localhost:1521/orcl; User Id=hr;Password=hr;";
        OracleConnection conn = new OracleConnection();
        public Register()
        {
            InitializeComponent();
        }

        private bool pass_string(TextBox s)
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
        private bool pass_number(TextBox s)
        //functia verifica daca valoarea introdusa este diferita de null si este un numar
        {
            bool cond = false;
            int val = 0;
            cond = Int32.TryParse(s.Text, out val);
            if(!cond)
                MessageBox.Show("Valoarea introdusa: " + s.Text + " nu este introdusa corect sau lipseste");
            return cond;
        }
        private void reset_colors()
        {
            password_value.BackColor = city_value.BackColor = firstName_value.BackColor = lastName_value.BackColor = adress_value.BackColor 
                = email_value.BackColor = phoneNumber_value.BackColor = id_value.BackColor = Color.White;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool cond = false;
            string birthday_date = Timepicker_birthday.Value.ToShortDateString();
            if (Timepicker_birthday.Value > DateTime.Now)
                MessageBox.Show("Nu sti introdus data de nastere corecta");

            int val = 0;
            cond = Int32.TryParse(id_value.Text, out val);
            if (pass_string(password_value) && pass_string(city_value) && pass_string(firstName_value) && pass_string(lastName_value) && pass_string(adress_value)
                && pass_string(email_value) && pass_string(phoneNumber_value) && pass_number(id_value) && Timepicker_birthday.Value < DateTime.Now)
            {
                    reset_colors();
                    try
                    {
                        using (conn = new OracleConnection(CONNECTION_STRING))
                        {
                            //deschiderea conexiunii
                            conn.Open();
                            string command =Comenzi_SQL.UpdateClient(val, city_value.Text,firstName_value.Text,
                            lastName_value.Text,birthday_date,adress_value.Text,phoneNumber_value.Text,
                            password_value.Text,email_value.Text );

                        if (Comenzi_SQL.ExecuteOracleCommand(command, conn))
                        {
                            MessageBox.Show("Datele au fost introduse cu succes");
                            this.Hide();
                            Main_form f = new Main_form();
                            f.Show();
                        }

                        else
                            MessageBox.Show("ID-ul acesta este deja luat de catre o persoana");
                            
                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        conn.Dispose();
                    }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_form f = new Main_form();
            f.Show();
        }

        private void password_value_TextChanged(object sender, EventArgs e)
        {
            password_value.PasswordChar = '●';
        }
    }
}
