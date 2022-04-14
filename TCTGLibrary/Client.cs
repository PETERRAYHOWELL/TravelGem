using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTGLibrary
{
    public class Client
    {
        private string firstName;
        private string lastName;
        private DateTime dob;
        private string telephone1;
        private string telephone2;
        private string country;
        private string gender;
        private string email;
        private string nationality;
        private string username;
        private string password;


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string fullName()
        {
            return this.firstName + " " + lastName;
        }


        public Client()
        {
            //Client client = new Client();
            //client.FirstName = "";
            //client.LastName = "";
            //client.DOB = "";
            //client.Telephone = "";
            //client.Country = "";
            //client.Gender = "";
            //client.Email = "";
            //client.Nationality = "";
            //client.Username = "";
            //client.Password = "";

            //Console.WriteLine(client.FirstName);
        }



    }
}
