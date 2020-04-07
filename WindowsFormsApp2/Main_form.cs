using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Main_form : Form
    {
        private static string CONNECTION_STRING = "Data Source=localhost:1521/orcl; User Id=hr;Password=hr;";
        OracleConnection conn = new OracleConnection();
        public Main_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register f = new Register();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(Dirty_work.pass_string(R_email_value) && Dirty_work.pass_string(R_password_value))
            {
                try
                {
                    using (conn = new OracleConnection(CONNECTION_STRING))
                    {
                        //deschiderea conexiunii
                        conn.Open();
                        string sqlCommand = Comenzi_SQL.Search_Databse_client(R_email_value.Text, R_password_value.Text);
                        
                        using (OracleDataAdapter oda = new OracleDataAdapter(sqlCommand, conn))
                        {
                            DataTable dt = new DataTable();
                            oda.Fill(dt);
                            dataGridView1.DataSource = dt;
                            //MessageBox.Show("String:" + dataGridView1.RowCount);
                            if (dataGridView1.RowCount >1)
                            {
                                MessageBox.Show("Pass");
                                if(R_email_value.Text != "hr")
                                {
                                    this.Hide();
                                    Lista_produse l = new Lista_produse();
                                    l.Show();
                                }
                                else
                                {
                                    this.Hide();
                                    Client_form c = new Client_form();
                                    c.Show();
                                }
                                
                            }
                                
                            else
                                MessageBox.Show("No pass");
                        }
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

        private void R_email_value_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Main_form_Load(object sender, EventArgs e)
        {

        }

        private void R_password_value_TextChanged(object sender, EventArgs e)
        {
            R_password_value.PasswordChar = '●';
        }
    }
}
