using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTGLibrary
{
    public class TransBooking : Booking // inheritance between the parent booking class
    {
        #region//Variables
        private int noAdults;
        private int noChildren;
        private int noInfants;
        private DateTime reservationDate;
        private string reservationTime;
        #endregion

        #region//Properties
        public int NoAdults { get; set; }
        public int NoChildren { get; set; }
        public int NoInfants { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationTime { get; set; }
        #endregion


        #region//Constructors
        //default constructor
        public TransBooking()
        {
            noAdults = 0;
            noChildren= 0;
            noInfants = 0;
            reservationDate = DateTime.Now;
            reservationTime = "";
    }

        //primary constructor
        public TransBooking(int NoAdults, int NoChildren, int NoInfants, DateTime ReservationDate, string ReservationTime)
        {
            noAdults = NoAdults;
            noChildren = NoChildren;
            noInfants = NoInfants;
            reservationDate = ReservationDate;
            reservationTime = ReservationTime;
        }

        //copy constructor
        public TransBooking(TransBooking transBooking)
        {
            noAdults = transBooking.NoAdults;
            noChildren = transBooking.NoChildren;
            noInfants = transBooking.NoInfants;
            reservationDate = transBooking.ReservationDate;
            reservationTime = transBooking.ReservationTime;
        }
        #endregion


        #region//to overridden methods for the abstract function from the booking abstract class
        public override void CreateBooking()
        {

        }

        public override void GetBooking()
        {

        }

        public override void UpdateBooking()
        {

        }

        public override void DeleteBooking()
        {

        }
        #endregion

    }
}
