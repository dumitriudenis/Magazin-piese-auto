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
    
    public partial class Lista_produse : Form
    {
        private static string CONNECTION_STRING = "Data Source=localhost:1521/orcl; User Id=hr;Password=hr;";
        OracleConnection conn = new OracleConnection();
        public Lista_produse()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
            //afiseaza toti clientii
        {
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();
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

        private void button2_Click(object sender, EventArgs e)
         //back button 
        {
            this.Hide();
            Main_form m = new Main_form();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
            //afiseaza toate produsele
        {
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();
                    string sqlCommand = "select * from produs";
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

        private void button3_Click(object sender, EventArgs e)
            //deschide fereastra cu adaugare produs
        {
            Adaugare_produs p = new Adaugare_produs();
            p.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
            //search client in DB
        {
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();
                    
                    string sqlCommand = Comenzi_SQL.Search_Database_client_name(client_name_TextBox.Text);
                    if (Dirty_work.pass_string(client_name_TextBox))
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

        private void button6_Click(object sender, EventArgs e)
            //search produs in DB
        {
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();

                    string sqlCommand = Comenzi_SQL.Search_Database_product_name(Product_name_TextBox.Text);
                    if (Dirty_work.pass_string(Product_name_TextBox))
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

        private void Product_name_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
