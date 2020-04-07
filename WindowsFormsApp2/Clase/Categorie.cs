using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Clase
{
    class Categorie
    {
        private int id;
        private string category_name;

        public Categorie(int id, string category_name)
        {
            this.id = id;
            this.category_name = category_name;
        }

        public int Id { get => id; set => id = value; }
        public string Category_name { get => category_name; set => category_name = value; }
    }
}
