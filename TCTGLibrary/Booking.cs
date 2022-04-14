using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTGLibrary
{
    public abstract class Booking : Information
    {
        #region//Variables
        private string reservation_Id;
        private string firstName;
        private string lastName;
        private string email;
        private string telephone;
        private int noGuest;
        private string specialComments;
        #endregion

        #region//Properties
        public string Reservation_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public int NoGuest { get; set; }
        public string SpecialComments { get; set; }
        #endregion

        public string fullName()
        {
            return this.firstName + " " + lastName;
        }



        #region//Constructors
        //default constructor
        public Booking()
        {
            
            firstName = "";
            lastName = "";
            email = "";
            telephone = "";
            noGuest = 0;
            specialComments = "";
            price = 0.0f;

    }

        //primary constructor
        public Booking(string FirstName, string LastName, string Email, string Telephone, int NoGuest, string SpecialComments, 
                        float Price )
        {
            firstName = FirstName;
            lastName = LastName;
            email = Email;
            telephone = Telephone;
            noGuest = NoGuest;
            specialComments = SpecialComments;
            price = Price;
        }

        //copy constructor
        public Booking(Booking booking)
        {
            firstName = booking.FirstName;
            lastName = booking.LastName;
            email = booking.Email;
            telephone = booking.Telephone;
            noGuest = booking.NoGuest;
            specialComments = booking.SpecialComments;
            price = booking.Price;
        }
        #endregion


        #region//to abstraact methods for the booking abstract class
        public abstract void CreateBooking();
        public abstract void GetBooking();
        public abstract void UpdateBooking();
        public abstract void DeleteBooking();
        #endregion
    }

}

