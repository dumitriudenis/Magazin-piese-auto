using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Clase
{
    class Lista_produse
    {
        private int id;
        private string product_name;
        private double price;
        private string category;

        public Lista_produse(int id, string product_name, double price, string category)
        {
            this.id = id;
            this.product_name = product_name;
            this.price = price;
            this.category = category;
        }

        public int Id { get => id; set => id = value; }
        public string Product_name { get => product_name; set => product_name = value; }
        public double Price { get => price; set => price = value; }
        public string Category { get => category; set => category = value; }
    }
}
