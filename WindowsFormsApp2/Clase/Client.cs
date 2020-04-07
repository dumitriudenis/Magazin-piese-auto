using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Clase
{
    class Client
    {
        private int id;
        private string city;
        private string firstName;
        private string lastName;
        private string birthday;
        private string address;
        private string phoneNumber;
        private string password;
        private string email;

        public Client(int id, string city, string firstName, string lastName, string birthday, string address, string phoneNumber, string password, string email)
        {
            this.id = id;
            this.city = city;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.password = password;
            this.email = email;
        }

        public int Id { get => id; set => id = value; }
        public string City { get => city; set => city = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Address{ get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
    }
}
