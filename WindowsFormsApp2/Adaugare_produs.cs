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
    public partial class Adaugare_produs : Form
    {
        private static string CONNECTION_STRING = "Data Source=localhost:1521/orcl; User Id=hr;Password=hr;";
        OracleConnection conn = new OracleConnection();
        public Adaugare_produs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool cond1,cond2,cond3,cond4 ;
            int val,val2,val3,val4;
            cond1 = Int32.TryParse(id_value.Text, out val);
            cond2 = Int32.TryParse(order_id.Text, out val2);
            cond3 = Int32.TryParse(price.Text, out val3);
            cond4 = Int32.TryParse(quality.Text, out val4);
            if (Dirty_work.pass_string(product_name) && Dirty_work.pass_string(description) && Dirty_work.pass_string(category) 
                && Dirty_work.pass_number(order_id) && Dirty_work.pass_number(price) && Dirty_work.pass_number(id_value) && Dirty_work.pass_number(quality)
                && cond1 && cond2 && cond3 && cond4)
            {
                try
                {
                    using (conn = new OracleConnection(CONNECTION_STRING))
                    {
                        //deschiderea conexiunii
                        conn.Open();
                        string command = Comenzi_SQL.UpdateProdus(val,val2,product_name.Text,val3,description.Text,val4,category.Text);

                        if (Comenzi_SQL.ExecuteOracleCommand(command, conn))
                        {
                            MessageBox.Show("Datele au fost introduse cu succes");
                            this.Hide();
                            Lista_produse f = new Lista_produse();
                            f.Show();
                        }

                        else
                            MessageBox.Show("ID-ul acesta este deja atribuit altui produs");

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

        private void button3_Click(object sender, EventArgs e)
        {
            Lista_produse l = new Lista_produse();
            l.Show();
            this.Hide();
        }
    }
}
