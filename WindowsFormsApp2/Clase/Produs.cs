using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Clase
{
    class Produs
    {
        private int id;
        private int order_id;
        private string product_name;
        private double price;
        private string description;
        private int quality;
        private string category;

        public Produs(int id, int order_id, string product_name, double price, string description, int quality, string category)
        {
            this.id = id;
            this.order_id = order_id;
            this.product_name = product_name;
            this.price = price;
            this.description = description;
            this.quality = quality;
            this.category = category;
        }

        public int Id { get => id; set => id = value; }
        public int Order_id { get => order_id; set => order_id = value; }
        public string Product_name { get => product_name; set => product_name = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public int Quality { get => quality; set => quality = value; }
        public string Category { get => category; set => category = value; }
    }
}
