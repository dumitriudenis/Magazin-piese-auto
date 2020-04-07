using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using WindowsFormsApp2.Clase;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private static string CONNECTION_STRING = "Data Source=localhost:1521/orcl; User Id=hr;Password=hr;";
        OracleConnection conn = new OracleConnection();

        private void Instantiate_all_tables()
        {
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.CreateCategorieTable(),conn);
                    MessageBox.Show("CreateCategorieTable a fost creata");
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.CreateClientiTable(), conn);
                    MessageBox.Show("CreateClientiTable a fost creata");
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.CreateClientTable(), conn);
                    MessageBox.Show("CreateClientTable a fost creata");
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.CreateComenziTable(), conn);
                    MessageBox.Show("CreateComenziTable a fost creata");
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.CreateDetalii_ComandaTable(), conn);
                    MessageBox.Show("CreateDetalii_ComandaTable a fost creata");
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.CreateLista_ProduseTable(), conn);
                    MessageBox.Show("CreateLista_ProduseTable a fost creata");
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.CreateProdusTable(), conn);
                    MessageBox.Show("CreateProdusTable a fost creata");
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
        private void Drop_all_tables()
        {
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.DropCategorieTable(), conn);
                    MessageBox.Show("CreateCategorieTable a fost stearsa");
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.DropClientiTable(), conn);
                    MessageBox.Show("CreateClientiTable a fost stearsa");
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.DropClientTable(), conn);
                    MessageBox.Show("CreateClientTable a fost stearsa");
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.DropComenziTable(), conn);
                    MessageBox.Show("CreateComenziTable a fost stearsa");
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.DropDetalii_ComandaTable(), conn);
                    MessageBox.Show("CreateDetalii_ComandaTable a fost stearsa");
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.DropLista_ProduseTable(), conn);
                    MessageBox.Show("CreateLista_ProduseTable a fost stearsa");
                    Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.DropProdusTable(), conn);
                    MessageBox.Show("CreateProdusTable a fost stearsa");
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
        public Form1()
        {
            InitializeComponent();
           
        } 

        private void button1_Click(object sender, EventArgs e)
        {
           // Instantiate_all_tables();
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();
                    //Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.DropClientTable(), conn);
                    //Comenzi_SQL.ExecuteOracleCommand(Comenzi_SQL.CreateClientTable(), conn);
                    string sqlCommand1 = Comenzi_SQL.CreateClientiTable();
                    string sqlCommand = "SELECT * from client";
                    using (OracleDataAdapter oda = new OracleDataAdapter(sqlCommand, conn))
                    {
                        // Utilizare DataAdapter pentru a seta datele intr-un DataTable
                        DataTable dt = new DataTable();
                        oda.Fill(dt);       
                        // setare dataSource pentru controld grid
                        dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//\\

            if(textBox1.Text != "" && textBox2.Text != "")
            {
                MessageBox.Show("date corecte");
            }
            else

            {
                MessageBox.Show("Date incorecte");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register f = new Register();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_form f = new Main_form();
            f.Show();
        }
    }
}
