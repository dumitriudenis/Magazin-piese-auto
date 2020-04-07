using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Clase
{
    class Clienti
    {
        private string email;
        private string password;
        private int client_id;

        public Clienti(string email, string password, int client_id)
        {
            this.email = email;
            this.password = password;
            this.client_id = client_id;
        }

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Client_id { get => client_id; set => client_id = value; }
    }
}
