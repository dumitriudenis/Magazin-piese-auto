using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Clase
{
    class Comenzi
    {
        private int id_order;
        private string oder_date;
        private int produs_quantity;
        private int id_client;
        private double price;

        public Comenzi(int id_order, string oder_date, int produs_quantity, int id_client, double price)
        {
            this.id_order = id_order;
            this.oder_date = oder_date;
            this.produs_quantity = produs_quantity;
            this.id_client = id_client;
            this.price = price;
        }

        public int Id_order { get => id_order; set => id_order = value; }
        public string Oder_date { get => oder_date; set => oder_date = value; }
        public int Produs_quantity { get => produs_quantity; set => produs_quantity = value; }
        public int Id_client { get => id_client; set => id_client = value; }
        public double Price { get => price; set => price = value; }
    }
}
