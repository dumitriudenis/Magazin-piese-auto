using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Clase
{
    class Detalii_comanda
    {
        private int order_id;
        private string name;
        private int product_quantity;
        private string date;
        private int product_id;
        private double price;

        public Detalii_comanda(int order_id, string name, int product_quantity, string date, int product_id, double price)
        {
            this.order_id = order_id;
            this.name = name;
            this.product_quantity = product_quantity;
            this.date = date;
            this.product_id = product_id;
            this.price = price;
        }

        public int Order_id { get => order_id; set => order_id = value; }
        public string Name { get => name; set => name = value; }
        public int Product_quantity { get => product_quantity; set => product_quantity = value; }
        public string Date { get => date; set => date = value; }
        public int Product_id { get => product_id; set => product_id = value; }
        public double Price { get => price; set => price = value; }
    }
}
