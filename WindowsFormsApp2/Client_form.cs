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
    public partial class Client_form : Form
    {
        private static string CONNECTION_STRING = "Data Source=localhost:1521/orcl; User Id=hr;Password=hr;";
        OracleConnection conn = new OracleConnection();
        public Client_form()
        {
            InitializeComponent();
            //actualizare lista produse la initializare forma
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

        private void Client_form_Load(object sender, EventArgs e)
        {

        }

        private void albToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void spateToolStripMenuItem_Click(object sender, EventArgs e)
            //categoria CAROSERIE   
        {
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();

                    string sqlCommand = Comenzi_SQL.Ascending_Order_product("price");
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

        private void motorToolStripMenuItem_Click(object sender, EventArgs e)
        //categoria MOTOR
        {
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();

                    string sqlCommand = Comenzi_SQL.Search_Database_product_category("motor");
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

        private void esteticaToolStripMenuItem_Click(object sender, EventArgs e)
            //categoria ESTETICA
        {  
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();

                    string sqlCommand = Comenzi_SQL.Search_Database_product_category("estetica");
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

        private void confortToolStripMenuItem_Click(object sender, EventArgs e)
            //categoria CONFORT
        {
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();

                    string sqlCommand = Comenzi_SQL.Search_Database_product_category("confort");
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

        private void crescatorToolStripMenuItem_Click(object sender, EventArgs e)
            //pret crescator 
        {
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();

                    string sqlCommand = Comenzi_SQL.Ascending_Order_product("price");
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

        private void descrescatorToolStripMenuItem_Click(object sender, EventArgs e)
            //descrescator pret
        {
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();

                    string sqlCommand = Comenzi_SQL.Descending_Order_product("price");
                    using (OracleDataAdapter oda = new OracleDataAdapter(sqlCommand, conn))
                    {
                        // Utilizare DataAdapter pentru a seta datele intr-un DataTable
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        // setare dataSource pentru controld grid
                        dataGridView1.DataSource = dt;
                    }
                    Update();
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

        private void crescatorToolStripMenuItem1_Click(object sender, EventArgs e)
            //crescator nume
        {
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();

                    string sqlCommand = Comenzi_SQL.Ascending_Order_product("product_name");
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

        private void descrescatorToolStripMenuItem1_Click(object sender, EventArgs e)
            //descrescator nume
        {
            try
            {
                using (conn = new OracleConnection(CONNECTION_STRING))
                {
                    //deschiderea conexiunii
                    conn.Open();

                    string sqlCommand = Comenzi_SQL.Descending_Order_product("product_name");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Main_form m = new Main_form();
            m.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
            //cauta produs
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

    }
}
