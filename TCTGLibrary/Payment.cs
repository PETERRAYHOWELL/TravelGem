using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTGLibrary
{
    public class Payment : Booking
    {
        #region//Constructors
        private string invoiceNo;
        private string paymentOption;
        private string cardNumber;
        private string expirationDate;
        private int cVC;
        private string streetAddress;
        private string apt;
        private string country;
        private string city;
        private string state;
        private string zipCode;
        private string balance;
        private string paymentDate;
        private string gCT;
        private string subTotal;
        private string total;
        #endregion


        #region//Properties
        public string InvoiceNo { get; set; }
        public string PaymentOption { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public int CVC { get; set; }
        public string StreetAddress { get; set; }
        public string Apt { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Balance { get; set; }
        public string PaymentDate { get; set; }
        public string GCT { get; set; }
        public string SubTotal { get; set; }
        public string Total { get; set; }
        #endregion


        #region//Constructors
        public Payment()
        {
            invoiceNo = "";
            paymentOption = "";
            cardNumber = "";
            expirationDate = "";
            cVC = 0;
            streetAddress = "";
            apt = "";
            country = "";
            city = "";
            state = "";
            zipCode = "";
            balance = "";
            paymentDate = "";
            gCT = "";
            subTotal = "";
            total = "";
    }

        public Payment(string InvoiceNo,string PaymentOption,string CardNumber,string ExpirationDate,int CVC,string StreetAddress,
                        string Apt,string Country,string City,string State, string ZipCode, string Balance,string PaymentDate,
                        string GCT,string SubTotal,string Total)
            
        {
            invoiceNo = InvoiceNo;
            paymentOption = PaymentOption;
            cardNumber = CardNumber;
            expirationDate = ExpirationDate;
            cVC = CVC;
            streetAddress = StreetAddress;
            apt = Apt;
            country = Country;
            city = City;
            state = State;
            zipCode = ZipCode;
            balance = Balance;
            paymentDate = PaymentDate;
            gCT = GCT;
            subTotal = SubTotal;
            total = Total;
        }

        public Payment( Payment payment)
        {
            invoiceNo = payment.InvoiceNo;
            paymentOption = payment.PaymentOption;
            cardNumber = payment.CardNumber;
            expirationDate = payment.ExpirationDate;
            cVC = payment.CVC;
            streetAddress = payment.StreetAddress;
            apt = payment.Apt;
            country = payment.Country;
            city = payment.City;
            state = payment.State;
            zipCode = payment.ZipCode;
            balance = payment.Balance;
            paymentDate = payment.PaymentDate;
            gCT = payment.GCT;
            subTotal = payment.SubTotal;
            total = payment.Total;
        }
        #endregion

        //public void Total(float total)
        //{

        //    float SubTotal;
        //    float GCT = 0.15f;

        //    SubTotal = (NoGuest * price) * GCT;
        //}

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
